using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using KompanzasyonHesapSistemi.Services;
using Serilog;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmYedekleme : BaseForm
    {
        private readonly BackupService _backupService;
        private Dictionary<string, string> _availableBackups;

        public FrmYedekleme(BackupService backupService)
        {
            InitializeComponent();
            _backupService = backupService;
            _availableBackups = new Dictionary<string, string>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Log.Information("Yedekleme formu yükleniyor...");
            _ = LoadBackupsAsync();
        }

        private async Task LoadBackupsAsync()
        {
            try
            {
                Log.Information("Yedekler yükleniyor...");
                _availableBackups = await _backupService.GetAvailableBackupsAsync();
                Log.Information("{BackupCount} adet yedek bulundu", _availableBackups.Count);

                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        lstBackups.DataSource = null;
                        lstBackups.DataSource = new BindingSource(_availableBackups, null);
                        lstBackups.DisplayMember = "Key";
                        lstBackups.ValueMember = "Value";
                        lblInfo.Text = $"{_availableBackups.Count} adet yedek bulundu.";
                    }));
                }
                else
                {
                    lstBackups.DataSource = null;
                    lstBackups.DataSource = new BindingSource(_availableBackups, null);
                    lstBackups.DisplayMember = "Key";
                    lstBackups.ValueMember = "Value";
                    lblInfo.Text = $"{_availableBackups.Count} adet yedek bulundu.";
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Yedekler yüklenirken hata oluştu");
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        lblInfo.Text = $"Yedekler yüklenirken hata oluştu: {ex.Message}";
                    }));
                }
                else
                {
                    lblInfo.Text = $"Yedekler yüklenirken hata oluştu: {ex.Message}";
                }
            }
        }

        private async void btnCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                Application.UseWaitCursor = true;
                await _backupService.CreateBackupAsync();
                NotifySuccess("Yeni yedek başarıyla oluşturuldu.");
                await LoadBackupsAsync();
            }
            catch (Exception ex)
            {
                NotifyError($"Yedekleme sırasında bir hata oluştu: {ex.Message}");
            }
            finally
            {
                this.Enabled = true;
                Application.UseWaitCursor = false;
            }
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (lstBackups.SelectedItem == null)
            {
                NotifyWarning("Lütfen geri yüklenecek bir yedek seçin.");
                return;
            }

            var selectedBackup = (KeyValuePair<string, string>)lstBackups.SelectedItem;
            string backupPath = selectedBackup.Value;
            string backupName = selectedBackup.Key;

            var result = MessageBox.Show(
                $"'{backupName}' adlı yedeği geri yüklemek istediğinizden emin misiniz?\n\n" +
                "DİKKAT: Bu işlem mevcut verilerinizin üzerine yazılacaktır ve geri alınamaz!",
                "Geri Yükleme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Enabled = false;
                    Application.UseWaitCursor = true;
                    bool success = await _backupService.RestoreBackupAsync(backupPath);
                    if (success)
                    {
                        NotifySuccess("Veriler başarıyla geri yüklendi. Uygulamanın yeniden başlatılması gerekebilir.");
                    }
                    else
                    {
                        NotifyError("Geri yükleme sırasında bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"Geri yükleme sırasında kritik bir hata oluştu: {ex.Message}");
                }
                finally
                {
                    this.Enabled = true;
                    Application.UseWaitCursor = false;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBackups.SelectedItem == null)
            {
                NotifyWarning("Lütfen silinecek bir yedek seçin.");
                return;
            }

            var selectedBackup = (KeyValuePair<string, string>)lstBackups.SelectedItem;
            string backupName = selectedBackup.Key;

            var result = MessageBox.Show(
                $"'{backupName}' adlı yedeği silmek istediğinizden emin misiniz?\n\n" +
                "Bu işlem geri alınamaz!",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = await _backupService.DeleteBackupAsync(backupName);
                    if (success)
                    {
                        NotifySuccess("Yedek başarıyla silindi.");
                        await LoadBackupsAsync();
                    }
                    else
                    {
                        NotifyError("Yedek silinirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    NotifyError($"Silme işlemi sırasında bir hata oluştu: {ex.Message}");
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadBackupsAsync();
        }
    }
}
