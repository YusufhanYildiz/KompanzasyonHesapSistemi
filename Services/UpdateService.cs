using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velopack;
using Velopack.Sources;

namespace KompanzasyonHesapSistemi.Services
{
    public class UpdateService
    {
        private readonly string _updateUrl;
        private static readonly SemaphoreSlim _updateLock = new SemaphoreSlim(1, 1);
        public Action<string, int>? NotifyMessage { get; set; }

        public UpdateService(string updateUrl = "https://github.com/YusufhanYildiz/KompanzasyonHesapSistemi")
        {
            _updateUrl = updateUrl;
        }

        public async Task<UpdateInfo?> CheckAndDownloadUpdatesAsync(bool silent = false)
        {
            // Eşzamanlı kontrolü engelle (Race Condition Fix)
            if (!await _updateLock.WaitAsync(0))
            {
                if (!silent) NotifyMessage?.Invoke("Güncelleme kontrolü zaten arka planda devam ediyor.", 3000);
                return null;
            }

            try
            {
                var mgr = new UpdateManager(new GithubSource(_updateUrl, null, false));

                // Geliştirme ortamında çalışıyorsa iptal et (Dev Environment Fix)
                if (!mgr.IsInstalled)
                {
                    if (!silent) NotifyMessage?.Invoke("Geliştirme modunda güncelleme kontrolü yapılmaz.", 3000);
                    return null;
                }

                // Güncelleme kontrolü
                var newVersion = await mgr.CheckForUpdatesAsync();
                if (newVersion == null)
                {
                    if (!silent) NotifyMessage?.Invoke("Uygulama güncel.", 3000);
                    return null;
                }

                // Güncelleme bulundu
                if (!silent)
                {
                    var result = MessageBox.Show($"Yeni bir sürüm mevcut ({newVersion.TargetFullRelease.Version}). İndirilsin mi?",
                        "Güncelleme Mevcut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result != DialogResult.Yes) return null;
                }

                // Güncellemeyi indir
                await mgr.DownloadUpdatesAsync(newVersion);

                if (!silent)
                {
                    NotifyMessage?.Invoke("Güncelleme indirildi. Kurulum için hazır.", 3000);
                }
                
                return newVersion;
            }
            catch (Exception ex)
            {
                if (!silent)
                {
                    NotifyMessage?.Invoke($"Güncelleme kontrolü sırasında hata: {ex.Message}", 5000);
                }
                return null;
            }
            finally
            {
                _updateLock.Release();
            }
        }

        public void ApplyUpdatesAndRestart(UpdateInfo updateInfo)
        {
            try
            {
                var mgr = new UpdateManager(new GithubSource(_updateUrl, null, false));
                mgr.ApplyUpdatesAndRestart(updateInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme uygulanırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
