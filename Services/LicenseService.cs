using KompanzasyonHesapSistemi.Models;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Services
{
    public class LicenseService
    {
        private readonly IJsonSingletonService<LicenseInfo> _jsonLicenseService;
        private readonly HardwareService _hardwareService;

        public LicenseService(IJsonSingletonService<LicenseInfo> jsonLicenseService, HardwareService hardwareService)
        {
            _jsonLicenseService = jsonLicenseService;
            _hardwareService = hardwareService;
        }

        /// <summary>
        /// Kayıtlı lisans bilgisini okur.
        /// </summary>
        /// <returns>Lisans bilgisi nesnesi veya bulunamazsa yeni bir varsayılan lisans.</returns>
        public async Task<LicenseInfo> GetLicenseAsync()
        {
            var license = await _jsonLicenseService.GetAsync();
            // If no license exists in the JSON file, GetAsync returns a new default LicenseInfo.
            // Ensure HardwareId is set if it's a new license.
            if (string.IsNullOrEmpty(license.HardwareId) || license.HardwareId == "HWID_ERROR" || license.HardwareId == "UNABLE_TO_READ_HWID")
            {
                license.HardwareId = _hardwareService.GetHardwareId();
                await _jsonLicenseService.SaveAsync(license); // Save the newly generated HardwareId
            }
            return license;
        }

        /// <summary>
        /// Lisans bilgisini JSON dosyasına kaydeder.
        /// </summary>
        /// <param name="licenseInfo">Kaydedilecek lisans bilgisi.</param>
        public async Task SaveLicenseAsync(LicenseInfo licenseInfo)
        {
            await _jsonLicenseService.SaveAsync(licenseInfo);
        }
    }
}
