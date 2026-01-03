using System;
using System.IO;
using Newtonsoft.Json; // Added for consistency

namespace KompanzasyonHesapSistemi.Models
{
    public class BackupSettings
    {
        public bool IsEnabled { get; set; } = true;
        
        // Varsayılan yedekleme yolu: Uygulama dizini/Backups
        public string BackupPath { get; set; } = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, 
            "Backups");
        
        public int RetentionDays { get; set; } = 30; // 0 means keep all backups
        public int MaxBackupCount { get; set; } = 0; // 0 means no limit based on count
        public bool AutoBackupOnExit { get; set; } = true;
    }
}
