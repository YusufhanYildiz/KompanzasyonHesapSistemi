using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velopack;
using Velopack.Sources;

namespace KompanzasyonHesapSistemi.Services
{
    public class UpdateService
    {
        private readonly string _updateUrl;
        public Action<string, int>? NotifyMessage { get; set; }

        public UpdateService(string updateUrl = "" +
            "https://github.com/YusufhanYildiz/KompanzasyonHesapSistemi")
        {
            _updateUrl = updateUrl;
        }

        public async Task CheckAndApplyUpdatesAsync(bool silent = false)
        {
            try
            {
                var mgr = new UpdateManager(new GithubSource(_updateUrl, null, false));

                // Güncelleme kontrolü
                var newVersion = await mgr.CheckForUpdatesAsync();
                if (newVersion == null)
                {
                    if (!silent)
                    {
                        NotifyMessage?.Invoke("Uygulama güncel.", 3000);
                    }
                    return;
                }

                // Güncelleme bulundu
                if (!silent)
                {
                    var result = MessageBox.Show($"Yeni bir sürüm mevcut ({newVersion.TargetFullRelease.Version}). İndirilsin mi?", 
                        "Güncelleme Mevcut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result != DialogResult.Yes) return;
                }

                // Güncellemeyi indir
                await mgr.DownloadUpdatesAsync(newVersion);

                // Güncellemeyi uygula ve yeniden başlat
                if (!silent)
                {
                    NotifyMessage?.Invoke("Güncelleme indirildi. Uygulama şimdi yeniden başlatılacak.", 3000);
                }

                mgr.ApplyUpdatesAndRestart(newVersion);
            }
            catch (Exception ex)
            {
                if (!silent)
                {
                    NotifyMessage?.Invoke($"Güncelleme kontrolü sırasında bir hata oluştu: {ex.Message}", 5000);
                }
            }
        }
    }
}
