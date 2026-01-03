using KompanzasyonHesapSistemi.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Velopack;
using Velopack.Locators;
using MaterialSkin;

namespace KompanzasyonHesapSistemi
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            bool isPortable = false;
            try
            {
                isPortable = VelopackLocator.Current?.IsPortable ?? false;
            }
            catch 
            {
                isPortable = false;
            }

            string baseDataPath;
            // Force Portable Mode as per user request to fix portability issues
            baseDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            /* 
            if (isPortable)
            {
                baseDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            }
            else
            {
                baseDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KompanzasyonHesap", "Data");
            } 
            */

            string logFolder = Path.Combine(baseDataPath, "..", "Logs"); 
            logFolder = Path.GetFullPath(logFolder);

            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            string logFile = Path.Combine(logFolder, "log-.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information() // ULTRATHINK: Reduced log verbosity for production
                .WriteTo.File(logFile, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 30)
                .CreateLogger();
            
            Log.Information($"Application Starting. Mode: {(isPortable ? "Portable" : "Installed")}. Base Path: {baseDataPath}");

            VelopackApp.Build()
                .OnBeforeUninstallFastCallback(v => 
                {
                    try
                    {
                        if (!isPortable) 
                        {
                            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                            string dataPath = Path.Combine(appDataFolder, "KompanzasyonHesap");
                            if (Directory.Exists(dataPath)) Directory.Delete(dataPath, true);
                        }
                    }
                    catch { }
                })
                .Run();

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services, baseDataPath);
            ServiceProvider = services.BuildServiceProvider();

            try
            {
                Log.Information("Uygulama başlatılıyor...");
                
                // Sabit ve Yüksek Kontrastlı Açık Tema Uygula
                var manager = MaterialSkinManager.Instance;
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
                manager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, 
                    Accent.Orange400, TextShade.WHITE
                );

                var frmGiris = ServiceProvider.GetRequiredService<FrmGiris>();
                Application.Run(frmGiris);
            }
            catch (Exception ex)
            {
                // Merkezi hata yönetimi (Dil bağımlılığı kaldırıldı)
                Log.Fatal(ex, "Kritik hata.");
                MessageBox.Show($"Kritik hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static void ConfigureServices(IServiceCollection services, string baseDataPath)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddSerilog(dispose: true);
            });

            services.AddSingleton<IJsonDataService<Sirket>, JsonDataService<Sirket>>(s => new JsonDataService<Sirket>("sirketler.json", baseDataPath));
            services.AddSingleton<IJsonDataService<Hesaplama>, JsonDataService<Hesaplama>>(s => new JsonDataService<Hesaplama>("hesaplamalar.json", baseDataPath));
            services.AddSingleton<IJsonDataService<IsTakip>, JsonDataService<IsTakip>>(s => new JsonDataService<IsTakip>("istakip.json", baseDataPath));
            
            services.AddSingleton<IJsonSingletonService<AdminCredentials>, JsonSingletonService<AdminCredentials>>(s => new JsonSingletonService<AdminCredentials>("admincredentials.json", baseDataPath));
            services.AddSingleton<IJsonSingletonService<LicenseInfo>, JsonSingletonService<LicenseInfo>>(s => new JsonSingletonService<LicenseInfo>("licenseinfo.json", baseDataPath));
            services.AddSingleton<IJsonSingletonService<Dictionary<string, string>>, JsonSingletonService<Dictionary<string, string>>>(s => new JsonSingletonService<Dictionary<string, string>>("settings.json", baseDataPath));
            services.AddSingleton<IJsonSingletonService<BackupSettings>, JsonSingletonService<BackupSettings>>(s => new JsonSingletonService<BackupSettings>("backupsettings.json", baseDataPath)); 

            services.AddScoped<AuthService>();
            services.AddScoped<BackupService>();
            services.AddScoped<ExcelService>();
            services.AddScoped<HesaplamaService>();
            services.AddScoped<IsTakipService>();
            services.AddScoped<LicenseService>();
            services.AddScoped<PdfService>();
            services.AddScoped<SirketService>();
            services.AddScoped<TimeService>();
            services.AddSingleton<HardwareService>();
            services.AddScoped<UpdateService>();
            
            services.AddTransient<FrmGiris>();
            services.AddTransient<FrmAnaSayfa>();
            services.AddTransient<FrmDashboard>();
            services.AddTransient<FrmHesaplamalar>();
            services.AddTransient<FrmIletisim>();
            services.AddTransient<FrmInputDialog>();
            services.AddTransient<FrmIsTakip>();
            services.AddTransient<FrmSifreDegistir>();
            services.AddTransient<FrmSirketIslemleri>();
            services.AddTransient<FrmYedekleme>();
            services.AddTransient<FrmAyarlar>();
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception, "Arayüz Hatası");
            MessageBox.Show($"Bir hata oluştu:\n{e.Exception.Message}", "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                Log.Error(ex, "Arkaplan Hatası");
            }
        }
    }
}