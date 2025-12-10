using KompanzasyonHesapSistemi.Models;
using System;

namespace KompanzasyonHesapSistemi.Services
{
    public class LicenseService
    {
        private readonly JsonService _jsonService;
        private const string LICENSE_FILE = "license.json";

        public LicenseService()
        {
            _jsonService = new JsonService();
        }

        /// <summary>
        /// Kayıtlı lisans bilgisini okur.
        /// </summary>
        /// <returns>Lisans bilgisi nesnesi veya bulunamazsa null.</returns>
        public LicenseInfo? GetLicense()
        {
            return _jsonService.ReadData<LicenseInfo>(LICENSE_FILE);
        }

        /// <summary>
        /// Lisans bilgisini dosyaya kaydeder.
        /// </summary>
        /// <param name="licenseInfo">Kaydedilecek lisans bilgisi.</param>
        public void SaveLicense(LicenseInfo licenseInfo)
        {
            _jsonService.SaveData(LICENSE_FILE, licenseInfo);
        }
    }
}
