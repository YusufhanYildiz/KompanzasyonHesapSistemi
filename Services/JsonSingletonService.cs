using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog; // Added for logging

namespace KompanzasyonHesapSistemi.Services
{
    public class JsonSingletonService<T> : IJsonSingletonService<T> where T : class, new()
    {
        private readonly string _filePath;
        private readonly string _dataDirectory;
        private readonly SemaphoreSlim _fileLock = new SemaphoreSlim(1, 1); // For basic file locking

        public JsonSingletonService(string fileName, string? baseDirectory = null)
        {
            _dataDirectory = baseDirectory ?? GetDataDirectory();
            _filePath = Path.Combine(_dataDirectory, fileName);
            EnsureDataDirectoryExists();
            Log.Debug($"JsonSingletonService initialized for type {typeof(T).Name}. Data directory: {_dataDirectory}, File path: {_filePath}");
        }

        private string GetDataDirectory()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        }

        private void EnsureDataDirectoryExists()
        {
            try
            {
                if (!Directory.Exists(_dataDirectory))
                {
                    Log.Information($"Creating data directory: {_dataDirectory}");
                    Directory.CreateDirectory(_dataDirectory);
                    Log.Information($"Data directory created: {_dataDirectory}");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to ensure data directory exists at {_dataDirectory}");
            }
        }

        public async Task<T> GetAsync()
        {
            await _fileLock.WaitAsync();
            try
            {
                if (!File.Exists(_filePath))
                {
                    Log.Information($"Singleton file not found: {_filePath}. Returning new instance.");
                    return new T(); // Return a new instance if file doesn't exist
                }

                Log.Debug($"Reading from singleton file: {_filePath}");
                
                // ULTRATHINK OPTIMIZATION: Streaming API
                // Direct Stream-to-Object deserialization
                using (var fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var sr = new StreamReader(fs))
                using (var reader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    var item = await Task.Run(() => serializer.Deserialize<T>(reader));
                    
                    Log.Debug($"Successfully read singleton item from {_filePath} (Streamed)");
                    return item ?? new T();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to read data from singleton file: {_filePath}. Returning new instance.");
                return new T();
            }
            finally
            {
                _fileLock.Release();
            }
        }

        public async Task SaveAsync(T item)
        {
            await _fileLock.WaitAsync();
            try
            {
                Log.Debug($"Writing singleton item to file: {_filePath}");
                
                // ULTRATHINK OPTIMIZATION: Streaming API
                // Direct Object-to-Stream serialization
                using (var fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var sw = new StreamWriter(fs))
                using (var writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    var serializer = new JsonSerializer();
                    await Task.Run(() => serializer.Serialize(writer, item));
                }
                
                Log.Information($"Successfully wrote singleton item to {_filePath} (Streamed)");
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to write data to singleton file: {_filePath}");
            }
            finally
            {
                _fileLock.Release();
            }
        }
    }
}
