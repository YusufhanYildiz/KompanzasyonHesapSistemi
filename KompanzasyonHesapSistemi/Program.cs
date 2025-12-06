using KompanzasyonHesapSistemi.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Global Exception Handlers - Yakalanmayan hatalar için güvenlik ağı
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            ApplicationConfiguration.Initialize();

            try
            {
                var licenseService = new LicenseService();
                var licenseInfo = licenseService.GetLicense();
                var hardwareId = HardwareService.GetHardwareId();

                bool validLicenseFound = false;

                if (licenseInfo != null && licenseInfo.HardwareId == hardwareId)
                {
                    if (licenseInfo.LicenseType == LicenseType.Full)
                    {
                        Application.Run(new FrmAnaSayfa("Admin"));
                        validLicenseFound = true;
                    }
                    else if (licenseInfo.LicenseType == LicenseType.Demo)
                    {
                        var elapsedDays = (DateTime.UtcNow - licenseInfo.StartDate).TotalDays;
                        if (elapsedDays <= 30)
                        {
                            Application.Run(new FrmAnaSayfa("Demo Kullanıcısı"));
                            validLicenseFound = true;
                        }
                    }
                }

                if (!validLicenseFound)
                {
                    // Geçerli bir lisans bulunamazsa veya süresi dolmuşsa giriş ekranını göster
                    Application.Run(new FrmGiris());
                }
            }
            catch (Exception ex)
            {
                HandleException(ex, "Uygulama başlatılırken");
            }
        }

        /// <summary>
        /// UI Thread'inde oluşan yakalanmayan hatalar
        /// </summary>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception, "İşlem sırasında");
        }

        /// <summary>
        /// Tüm AppDomain'de oluşan yakalanmayan hatalar
        /// </summary>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                HandleException(ex, "Kritik");
            }
        }

        /// <summary>
        /// Merkezi hata yönetimi - Hatayı logla ve kullanıcıya göster
        /// </summary>
        private static void HandleException(Exception ex, string context)
        {
            try
            {
                // Hata logunu dosyaya yaz
                LogError(ex, context);

                // Kullanıcıya dostça mesaj göster
                string message = $"{context} beklenmeyen bir hata oluştu.\n\n" +
                                $"Hata: {ex.Message}\n\n" +
                                "Hata detayları log dosyasına kaydedildi.\n" +
                                "Program kapatılacak.";

                MessageBox.Show(message, "Kritik Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                // Log yazma da başarısız olduysa en azından mesaj göster
                MessageBox.Show($"Kritik hata: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hatayı log dosyasına yaz
        /// </summary>
        private static void LogError(Exception ex, string context)
        {
            try
            {
                string logFolder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "KompanzasyonHesapSistemi", "Logs");

                if (!Directory.Exists(logFolder))
                {
                    Directory.CreateDirectory(logFolder);
                }

                string logFile = Path.Combine(logFolder, $"error_{DateTime.Now:yyyyMMdd}.log");
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{context}]\n" +
                                 $"Message: {ex.Message}\n" +
                                 $"Source: {ex.Source}\n" +
                                 $"StackTrace: {ex.StackTrace}\n" +
                                 $"-------------------------------------------\n";

                File.AppendAllText(logFile, logEntry);
            }
            catch
            {
                // Log yazma başarısız olsa bile uygulamayı çökertme
            }
        }
    }
}