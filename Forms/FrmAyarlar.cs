using System;
using System.Windows.Forms;
using KompanzasyonHesapSistemi.Services;
using MaterialSkin.Controls;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmAyarlar : BaseForm
    {
        private readonly BackupService _backupService;
        private bool _isLoading = true;

        public FrmAyarlar(BackupService backupService)
        {
            InitializeComponent();
            _backupService = backupService;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            await _backupService.InitializeAsync();
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => 
                {
                    swAutoBackup.Checked = _backupService.AutoBackupOnExit;
                    _isLoading = false;
                }));
            }
            else
            {
                swAutoBackup.Checked = _backupService.AutoBackupOnExit;
                _isLoading = false;
            }
        }

        private async void swAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            bool isChecked = swAutoBackup.Checked;
            
            try
            {
                await _backupService.UpdateSettingsAsync(settings => 
                {
                    settings.AutoBackupOnExit = isChecked;
                });
                
                // Kullanıcıya geri bildirim opsiyonel, switch zaten durumu gösteriyor.
                // Log.Information("Otomatik yedekleme ayarı değiştirildi: " + isChecked);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ayarlar kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata durumunda switch'i eski haline getir
                _isLoading = true;
                swAutoBackup.Checked = !isChecked;
                _isLoading = false;
            }
        }
    }
}
