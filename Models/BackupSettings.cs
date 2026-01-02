using System;
using System.IO;
using Newtonsoft.Json; // Added for consistency

namespace KompanzasyonHesapSistemi.Models
{
    public class BackupSettings
    {
        public bool IsEnabled { get; set; } = true;
        
        // Varsayılan yedekleme yolu: AppData/Local altında
        public string BackupPath { get; set; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "KompanzasyonHesapSistemi", 
            "Backups");
        
        public int RetentionDays { get; set; } = 30; // 0 means keep all backups
        public int MaxBackupCount { get; set; } = 0; // 0 means no limit based on count
    }
}
