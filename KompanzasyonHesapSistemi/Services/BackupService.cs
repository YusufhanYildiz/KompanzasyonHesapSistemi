using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KompanzasyonHesapSistemi.Models;
using Newtonsoft.Json;

namespace KompanzasyonHesapSistemi.Services
{
    public class BackupService
    {
        private readonly JsonService _jsonService;
        private readonly string _dataDirectory;
        private BackupSettings _settings = null!;

        public BackupService(JsonService jsonService)
        {
            _jsonService = jsonService;
            // JsonService ile aynı veri klasörünü kullan (AppData/Local)
            _dataDirectory = _jsonService.GetDataFolderPath();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Try to load settings from backup_settings.json, if it exists and is valid
            // Otherwise, use default settings.
            try
            {
                _settings = _jsonService.ReadData<BackupSettings>("backup_settings.json", createIfNotExist: true) ?? new BackupSettings();
                if (_settings == null)
                {
                    _settings = new BackupSettings();
                    // Save default settings if they were just created
                    _jsonService.SaveData("backup_settings.json", _settings);
                }
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine($"Error loading backup settings: {ex.Message}");
                _settings = new BackupSettings(); // Fallback to default settings
            }

            // Ensure BackupPath is an absolute path - use AppData/Local if relative
            if (!Path.IsPathRooted(_settings.BackupPath))
            {
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                _settings.BackupPath = Path.Combine(appDataFolder, "KompanzasyonHesapSistemi", _settings.BackupPath);
            }
            
            // Yedekleme klasörünü oluştur
            if (!Directory.Exists(_settings.BackupPath))
            {
                Directory.CreateDirectory(_settings.BackupPath);
            }
        }

        public async Task CreateBackupAsync()
        {
            if (!_settings.IsEnabled)
            {
                Console.WriteLine("Backup service is disabled.");
                return;
            }

            if (!Directory.Exists(_dataDirectory))
            {
                Console.WriteLine($"Data directory not found: {_dataDirectory}");
                return;
            }

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string currentBackupDirectory = Path.Combine(_settings.BackupPath, timestamp);

            try
            {
                if (!Directory.Exists(currentBackupDirectory))
                {
                    Directory.CreateDirectory(currentBackupDirectory);
                }

                foreach (var fileName in _settings.FilesToBackup)
                {
                    string sourceFilePath = Path.Combine(_dataDirectory, fileName);
                    if (File.Exists(sourceFilePath))
                    {
                        string destinationFilePath = Path.Combine(currentBackupDirectory, fileName);
                        await Task.Run(() => File.Copy(sourceFilePath, destinationFilePath, overwrite: true));
                        Console.WriteLine($"Backed up {fileName} to {currentBackupDirectory}");
                    }
                    else
                    {
                        Console.WriteLine($"File not found for backup: {fileName}");
                    }
                }

                CleanOldBackups();
                Console.WriteLine("Backup created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during backup: {ex.Message}");
            }
        }

        private void CleanOldBackups()
        {
            if (!Directory.Exists(_settings.BackupPath))
            {
                return;
            }

            var backupDirectories = Directory.GetDirectories(_settings.BackupPath)
                                             .Select(d => new DirectoryInfo(d))
                                             .OrderByDescending(d => d.CreationTime) // Or LastWriteTime, depending on preference
                                             .ToList();

            // Clean by RetentionDays
            if (_settings.RetentionDays > 0)
            {
                DateTime cutoffDate = DateTime.Now.AddDays(-_settings.RetentionDays);
                var backupsToCleanByDate = backupDirectories.Where(d => d.CreationTime < cutoffDate).ToList();

                foreach (var dir in backupsToCleanByDate)
                {
                    try
                    {
                        Directory.Delete(dir.FullName, true);
                        Console.WriteLine($"Deleted old backup directory: {dir.Name}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting old backup directory {dir.Name}: {ex.Message}");
                    }
                }
            }

            // Clean by MaxBackupCount (if RetentionDays is not enough or both are specified)
            if (_settings.MaxBackupCount > 0)
            {
                // Re-fetch or re-sort after date-based cleaning
                backupDirectories = Directory.GetDirectories(_settings.BackupPath)
                                             .Select(d => new DirectoryInfo(d))
                                             .OrderByDescending(d => d.CreationTime)
                                             .ToList();

                if (backupDirectories.Count > _settings.MaxBackupCount)
                {
                    var backupsToRemove = backupDirectories.Skip(_settings.MaxBackupCount).ToList();
                    foreach (var dir in backupsToRemove)
                    {
                        try
                        {
                            Directory.Delete(dir.FullName, true);
                            Console.WriteLine($"Deleted excess backup directory: {dir.Name}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deleting excess backup directory {dir.Name}: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
