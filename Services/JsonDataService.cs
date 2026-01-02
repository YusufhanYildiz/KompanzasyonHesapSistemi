using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Serilog;

namespace KompanzasyonHesapSistemi.Services
{
    public class JsonDataService<T> : IJsonDataService<T> where T : class
    {
        private readonly string _filePath;
        private readonly string _dataDirectory;
        private readonly SemaphoreSlim _fileLock = new SemaphoreSlim(1, 1);
        private readonly JSchema _schema;
        
        // Tier 1 Optimization: In-Memory Cache
        private List<T> _cache;
        private bool _isCacheLoaded = false;

        public JsonDataService(string fileName, string? baseDirectory = null)
        {
            _dataDirectory = baseDirectory ?? GetDataDirectory();
            _filePath = Path.Combine(_dataDirectory, fileName);
            EnsureDataDirectoryExists();
            
            // Generate schema for the list of T
            JSchemaGenerator generator = new JSchemaGenerator();
            _schema = generator.Generate(typeof(List<T>));
            
            Log.Debug($"JsonDataService initialized for type {typeof(T).Name}. Schema generated.");
            
            // Initialize cache as empty list, it will be populated on first access
            _cache = new List<T>();
        }

        private string GetDataDirectory()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appDataFolder, "KompanzasyonHesapSistemi", "Data");
        }

        private void EnsureDataDirectoryExists()
        {
            try
            {
                if (!Directory.Exists(_dataDirectory))
                {
                    Log.Information($"Creating data directory: {_dataDirectory}");
                    Directory.CreateDirectory(_dataDirectory);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to ensure data directory exists at {_dataDirectory}");
            }
        }

        private async Task EnsureCacheLoadedAsync()
        {
            if (_isCacheLoaded) return;

            await _fileLock.WaitAsync();
            try
            {
                if (_isCacheLoaded) return;

                if (!File.Exists(_filePath))
                {
                    Log.Information($"File not found: {_filePath}. Initializing empty cache.");
                    _cache = new List<T>();
                }
                else
                {
                    // ULTRATHINK OPTIMIZATION: Streaming API
                    // Replaced File.ReadAllText (Huge String) with Stream Reader
                    using (var fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (var sr = new StreamReader(fs))
                    using (var reader = new JsonTextReader(sr))
                    {
                        // Optimization: Load directly to JToken from stream, skipping string allocation
                        JArray jArray = await Task.Run(() => JArray.Load(reader));
                        
                        IList<string> errorMessages;
                        bool isValid = jArray.IsValid(_schema, out errorMessages);

                        if (!isValid)
                        {
                            Log.Error($"JSON Schema validation failed for {_filePath}. Errors: {string.Join(", ", errorMessages)}");
                            throw new InvalidDataException($"Data file corrupted or invalid schema: {_filePath}");
                        }

                        _cache = jArray.ToObject<List<T>>() ?? new List<T>();
                        Log.Debug($"Successfully loaded and validated {_cache.Count} items (Streamed).");
                    }
                }
                _isCacheLoaded = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to load data from file: {_filePath}");
                _cache = new List<T>();
                _isCacheLoaded = true; 
            }
            finally
            {
                _fileLock.Release();
            }
        }

        private async Task SaveCacheToDiskAsync()
        {
            await _fileLock.WaitAsync();
            try
            {
                // Verify cache against schema before writing
                // Optimization: Serialize to JArray first for validation, then stream to disk
                JArray jArray = JArray.FromObject(_cache);
                if (jArray.IsValid(_schema))
                {
                    using (var fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (var sw = new StreamWriter(fs))
                    using (var writer = new JsonTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented;
                        await Task.Run(() => jArray.WriteTo(writer));
                    }
                    Log.Information($"Successfully persisted validated cache to {_filePath} (Streamed)");
                }
                else
                {
                    Log.Error($"Attempted to save invalid data to {_filePath}. Operation aborted.");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Failed to write cache to file: {_filePath}");
            }
            finally
            {
                _fileLock.Release();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            await EnsureCacheLoadedAsync();
            return new List<T>(_cache); 
        }

        public async Task AddAsync(T item)
        {
            await EnsureCacheLoadedAsync();

            await _fileLock.WaitAsync();
            try
            {
                var idProperty = typeof(T).GetProperty("Id");
                if (idProperty != null && idProperty.PropertyType == typeof(int))
                {
                    int currentMaxId = _cache.Any() ? _cache.Max(x => (int)idProperty.GetValue(x)) : 0;
                    idProperty.SetValue(item, currentMaxId + 1);
                }

                _cache.Add(item);
            }
            finally
            {
                _fileLock.Release();
            }

            await SaveCacheToDiskAsync();
        }

        public async Task UpdateAsync(T item)
        {
            await EnsureCacheLoadedAsync();

            await _fileLock.WaitAsync();
            try
            {
                var idProperty = typeof(T).GetProperty("Id");

                if (idProperty == null || idProperty.PropertyType != typeof(int))
                {
                    throw new InvalidOperationException($"Type {typeof(T).Name} must have an 'Id' property of type int.");
                }

                int itemId = (int)idProperty.GetValue(item);
                var existingItem = _cache.FirstOrDefault(x => (int)idProperty.GetValue(x) == itemId);

                if (existingItem != null)
                {
                    int index = _cache.IndexOf(existingItem);
                    _cache[index] = item;
                }
                else
                {
                    throw new KeyNotFoundException($"Item with Id {itemId} not found.");
                }
            }
            finally
            {
                _fileLock.Release();
            }

            await SaveCacheToDiskAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await EnsureCacheLoadedAsync();

            await _fileLock.WaitAsync();
            try
            {
                var idProperty = typeof(T).GetProperty("Id");
                if (idProperty == null || idProperty.PropertyType != typeof(int))
                {
                    throw new InvalidOperationException($"Type {typeof(T).Name} must have an 'Id' property of type int.");
                }

                var itemToRemove = _cache.FirstOrDefault(x => (int)idProperty.GetValue(x) == id);
                if (itemToRemove != null)
                {
                    _cache.Remove(itemToRemove);
                }
                else
                {
                    throw new KeyNotFoundException($"Item with Id {id} not found.");
                }
            }
            finally
            {
                _fileLock.Release();
            }

            await SaveCacheToDiskAsync();
        }

        public async Task SaveChangesAsync(List<T> items)
        {
            await _fileLock.WaitAsync();
            try
            {
                _cache = new List<T>(items);
                _isCacheLoaded = true;
            }
            finally
            {
                _fileLock.Release();
            }

            await SaveCacheToDiskAsync();
        }
    }
}
