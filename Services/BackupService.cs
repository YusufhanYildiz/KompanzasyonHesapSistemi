using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using KompanzasyonHesapSistemi.Models;
using Newtonsoft.Json;
using Serilog;

namespace KompanzasyonHesapSistemi.Services
{
    public class BackupService
    {
        private readonly string _dataDirectory;
        private readonly IJsonSingletonService<BackupSettings> _backupSettingsService;
        private readonly IJsonSingletonService<Dictionary<string, string>> _generalSettingsService;
        private BackupSettings _settings;
        private readonly Lazy<Task> _initialization;

        public BackupService(
            IJsonSingletonService<BackupSettings> backupSettingsService,
            IJsonSingletonService<Dictionary<string, string>> generalSettingsService)
        {
            _dataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                          "KompanzasyonHesapSistemi", "Data");
            _backupSettingsService = backupSettingsService;
            _generalSettingsService = generalSettingsService;
            _settings = new BackupSettings();
            _initialization = new Lazy<Task>(LoadSettingsAsync);
        }

        private async Task LoadSettingsAsync()
        {
            try
            {
                _settings = await _backupSettingsService.GetAsync();

                // Ensure BackupPath is absolute
                if (!Path.IsPathRooted(_settings.BackupPath))
                {
                    _settings.BackupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                                        "KompanzasyonHesapSistemi", _settings.BackupPath);
                }

                if (!Directory.Exists(_settings.BackupPath))
                {
                    Directory.CreateDirectory(_settings.BackupPath);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Backup settings loading failed.");
                _settings = new BackupSettings();
                await SaveSettingsAsync(); 
            }
        }

        private async Task SaveSettingsAsync()
        {
            await _backupSettingsService.SaveAsync(_settings);
        }

        public async Task CreateBackupAsync()
        {
            await _initialization.Value;
            if (!_settings.IsEnabled) return;

            if (!Directory.Exists(_dataDirectory)) return;

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFilePath = Path.Combine(_settings.BackupPath, $"Backup_{timestamp}.zip");

            try
            {
                await Task.Run(() =>
                {
                    // Create a temporary directory to collect files if needed, 
                    // or just zip the data directory directly.
                    // Since we only want .json files from the data directory:
                    
                    using (var zipStream = new FileStream(backupFilePath, FileMode.Create))
                    using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                    {
                        var jsonFiles = Directory.GetFiles(_dataDirectory, "*.json");
                        foreach (var file in jsonFiles)
                        {
                            archive.CreateEntryFromFile(file, Path.GetFileName(file));
                        }
                    }
                });

                Log.Information($"Backup created successfully: {backupFilePath}");
                await CleanOldBackupsAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Backup creation failed.");
                throw;
            }
        }

        public async Task<bool> RestoreBackupAsync(string backupPath)
        {
            await _initialization.Value;
            if (!File.Exists(backupPath) && !Directory.Exists(backupPath)) return false;

            try
            {
                if (File.Exists(backupPath) && Path.GetExtension(backupPath).Equals(".zip", StringComparison.OrdinalIgnoreCase))
                {
                    // ZIP Restore
                    await Task.Run(() =>
                    {
                        // To avoid conflicts, we might want to clear or backup existing data first.
                        // For now, overwrite existing files.
                        ZipFile.ExtractToDirectory(backupPath, _dataDirectory);
                    });
                }
                else if (Directory.Exists(backupPath))
                {
                    // Legacy Folder Restore
                    var jsonFiles = Directory.GetFiles(backupPath, "*.json");
                    foreach (var file in jsonFiles)
                    {
                        string fileName = Path.GetFileName(file);
                        string destinationFilePath = Path.Combine(_dataDirectory, fileName);
                        await Task.Run(() => File.Copy(file, destinationFilePath, overwrite: true));
                    }
                }
                
                Log.Information($"Restore successful from: {backupPath}");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Restore failed.");
                return false;
            }
        }

        public async Task<Dictionary<string, string>> GetAvailableBackupsAsync()
        {
            await _initialization.Value;
            if (!Directory.Exists(_settings.BackupPath))
            {
                return new Dictionary<string, string>();
            }

            var backups = new Dictionary<string, string>();

            // 1. Get ZIP backups
            var zipFiles = Directory.GetFiles(_settings.BackupPath, "*.zip")
                                    .Select(f => new FileInfo(f))
                                    .OrderByDescending(f => f.CreationTime);

            foreach (var zip in zipFiles)
            {
                backups.Add(zip.Name, zip.FullName);
            }

            // 2. Get Legacy Folder backups (if any)
            var directories = Directory.GetDirectories(_settings.BackupPath)
                                       .Select(d => new DirectoryInfo(d))
                                       .OrderByDescending(d => d.CreationTime);

            foreach (var dir in directories)
            {
                if (!backups.ContainsKey(dir.Name))
                {
                    backups.Add("[Klasör] " + dir.Name, dir.FullName);
                }
            }

            return backups;
        }

        public async Task<bool> DeleteBackupAsync(string backupName)
        {
            await _initialization.Value;
            
            // Handle name with [Klasör] prefix
            bool isLegacy = backupName.StartsWith("[Klasör] ");
            string actualName = isLegacy ? backupName.Replace("[Klasör] ", "") : backupName;
            
            string fullPath = Path.Combine(_settings.BackupPath, actualName);

            try
            {
                if (isLegacy && Directory.Exists(fullPath))
                {
                    Directory.Delete(fullPath, true);
                    return true;
                }
                else if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to delete backup: {backupName}");
                return false;
            }
        }

        private async Task CleanOldBackupsAsync()
        {
            await Task.Run(() =>
            {
                if (!Directory.Exists(_settings.BackupPath)) return;

                // Combine files and directories for cleaning
                var backups = Directory.GetFiles(_settings.BackupPath, "*.zip")
                                       .Select(f => new FileInfo(f) as FileSystemInfo)
                                       .Concat(Directory.GetDirectories(_settings.BackupPath).Select(d => new DirectoryInfo(d) as FileSystemInfo))
                                       .OrderByDescending(i => i.CreationTime)
                                       .ToList();

                if (_settings.RetentionDays > 0)
                {
                    DateTime cutoffDate = DateTime.Now.AddDays(-_settings.RetentionDays);
                    var toClean = backups.Where(i => i.CreationTime < cutoffDate).ToList();

                    foreach (var item in toClean)
                    {
                        try 
                        { 
                            if (item is FileInfo) item.Delete();
                            else if (item is DirectoryInfo di) di.Delete(true);
                        } 
                        catch { }
                    }
                }

                if (_settings.MaxBackupCount > 0)
                {
                    // Refresh list
                    backups = Directory.GetFiles(_settings.BackupPath, "*.zip")
                                       .Select(f => new FileInfo(f) as FileSystemInfo)
                                       .Concat(Directory.GetDirectories(_settings.BackupPath).Select(d => new DirectoryInfo(d) as FileSystemInfo))
                                       .OrderByDescending(i => i.CreationTime)
                                       .ToList();

                    if (backups.Count > _settings.MaxBackupCount)
                    {
                        var toRemove = backups.Skip(_settings.MaxBackupCount).ToList();
                        foreach (var item in toRemove)
                        {
                            try 
                            { 
                                if (item is FileInfo) item.Delete();
                                else if (item is DirectoryInfo di) di.Delete(true);
                            } 
                            catch { }
                        }
                    }
                }
            });
        }
    }
}
