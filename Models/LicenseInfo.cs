using System;
using Newtonsoft.Json; // Added for consistency

namespace KompanzasyonHesapSistemi.Models
{
    public enum LicenseType
    {
        Demo,
        Full
    }

    public class LicenseInfo
    {
        public string HardwareId { get; set; } = string.Empty;
        public LicenseType LicenseType { get; set; } = LicenseType.Demo;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
    }
}
