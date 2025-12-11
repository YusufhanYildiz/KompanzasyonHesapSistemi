using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KompanzasyonHesapSistemi.Services;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmYedekleme : Form
    {
        private readonly BackupService _backupService;
        private Dictionary<string, string> _availableBackups;

        public FrmYedekleme(BackupService backupService)
        {
            InitializeComponent();
            _backupService = backupService;
            _availableBackups = new Dictionary<string, string>();
        }

        private void FrmYedekleme_Load(object sender, EventArgs e)
        {
            LoadBackups();
        }

        private void LoadBackups()
        {
            lstBackups.DataSource = null;
            _availableBackups = _backupService.GetAvailableBackups();
            
            if (_availableBackups.Count > 0)
            {
                // ListBox'a sadece yedek adlarını (klasör adları) ekle
                lstBackups.DataSource = new BindingSource(_availableBackups, null);
                lstBackups.DisplayMember = "Key";
                lstBackups.ValueMember = "Value";
                lblInfo.Text = $"{_availableBackups.Count} adet yedek bulundu.";
            }
            else
            {
                lblInfo.Text = "Henüz hiç yedek oluşturulmamış.";
            }
        }

        private async void btnCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                Application.UseWaitCursor = true;
                await _backupService.CreateBackupAsync();
                MessageBox.Show("Yeni yedek başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBackups();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yedekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lütfen geri yüklenecek bir yedek seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBackup = (KeyValuePair<string, string>)lstBackups.SelectedItem;
            string backupPath = selectedBackup.Value;
            string backupName = selectedBackup.Key;

            var result = MessageBox.Show(
                $"'{{backupName}}' adlı yedeği geri yüklemek istediğinizden emin misiniz?\n\n" +
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
                        MessageBox.Show("Veriler başarıyla geri yüklendi.\nUygulamanın yeniden başlatılması gerekebilir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Geri yükleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Geri yükleme sırasında kritik bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Enabled = true;
                    Application.UseWaitCursor = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBackups();
        }
    }
}
