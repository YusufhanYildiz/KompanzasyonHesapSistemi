using System;

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
        public LicenseType LicenseType { get; set; }
        public DateTime StartDate { get; set; }
    }
}
