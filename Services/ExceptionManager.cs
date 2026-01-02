using Serilog;
using System;
using System.IO;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Services
{
    /// <summary>
    /// Merkezi Hata Yönetimi (Simplified)
    /// Dil bağımlılığı kaldırıldı, doğrudan Türkçe mesajlar kullanılıyor.
    /// </summary>
    public static class ExceptionManager
    {
        public static void HandleException(Exception ex, string context = "Sistem")
        {
            Log.Error(ex, "[{Context}] Beklenmeyen hata yakalandı.", context);

            if (ex is InvalidDataException || ex is Newtonsoft.Json.JsonException)
            {
                NotificationService.ShowError("Veri dosyası okunamıyor veya bozuk. Lütfen yedeği geri yüklemeyi deneyin.");
            }
            else if (ex is UnauthorizedAccessException)
            {
                NotificationService.ShowError("Dosya erişim yetkisi yok. Lütfen yönetici olarak çalıştırmayı deneyin.");
            }
            else
            {
                NotificationService.ShowError($"Beklenmeyen bir hata oluştu: {ex.Message}");
            }
        }

        public static void HandleFatalException(Exception ex)
        {
            Log.Fatal(ex, "UYGULAMA ÇÖKTÜ: Kritik hata.");

            string message = $"Kritik bir sistem hatası oluştu:\n\n{ex.Message}\n\nUygulama güvenlik nedeniyle kapatılacak.";
            MessageBox.Show(message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            Log.CloseAndFlush();
            Environment.Exit(1);
        }
    }
}

