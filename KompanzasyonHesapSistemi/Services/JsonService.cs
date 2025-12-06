using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace KompanzasyonHesapSistemi.Services
{
    public class JsonService
    {
        private readonly string _dataFolder;
        public JsonService()
        {
            // Production için AppData/Local klasörünü kullan
            // Bu sayede uygulama her yerden çalıştırılabilir ve veriler güvenli bir yerde saklanır
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _dataFolder = Path.Combine(appDataFolder, "KompanzasyonHesapSistemi", "Data");

            // Data klasörü yoksa oluştur
            if (!Directory.Exists(_dataFolder))
            {
                Directory.CreateDirectory(_dataFolder);
            }
        }
        
        public List<T> ReadList<T>(string fileName) where T : class
        {
            string filePath = Path.Combine(_dataFolder, fileName);

            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<T>();
            }

            try
            {
                var data = JsonConvert.DeserializeObject<List<T>>(json);
                return data ?? new List<T>();
            }
            catch (JsonException)
            {
                // Hatalı formatlanmış JSON durumunda (nesne vs liste gibi) çökme, boş liste dön.
                return new List<T>();
            }
        }
        
        public void SaveList<T>(string fileName, List<T> data) where T : class
        {
            try
            {
                string filePath = Path.Combine(_dataFolder, fileName);
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"JSON yazma hatası ({fileName}): {ex.Message}");
            }
        }
        
        public void SaveData<T>(string fileName, T obj) where T : class
        {
            try
            {
                string filePath = Path.Combine(_dataFolder, fileName);
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"JSON yazma hatası ({fileName}): {ex.Message}");
            }
        }
        
        public T? ReadData<T>(string fileName, bool createIfNotExist = false) where T : class, new()
        {
            string filePath = Path.Combine(_dataFolder, fileName);

            if (!File.Exists(filePath))
            {
                if (createIfNotExist)
                {
                    T newObject = new T();
                    SaveData(fileName, newObject);
                    return newObject;
                }
                return null;
            }

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                if (createIfNotExist)
                {
                    T newObject = new T();
                    SaveData(fileName, newObject);
                    return newObject;
                }
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (JsonException)
            {
                if (createIfNotExist)
                {
                    T newObject = new T();
                    SaveData(fileName, newObject);
                    return newObject;
                }
                // Hatalı format durumunda null dön.
                return null;
            }
        }
        
        public void DeleteFile(string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataFolder, fileName);

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya silme hatası ({fileName}): {ex.Message}");
            }
        }
        
        public bool FileExists(string fileName)
        {
            string filePath = Path.Combine(_dataFolder, fileName);
            return File.Exists(filePath);
        }

        public string GetDataFolderPath()
        {
            return _dataFolder;
        }
    }
}
