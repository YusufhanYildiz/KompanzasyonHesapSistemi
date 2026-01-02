using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmAnaSayfa : BaseForm
    {
        private string _displayName;
        private readonly BackupService _backupService; 
        private readonly UpdateService _updateService;
        private readonly IServiceProvider _serviceProvider;
        private bool _isClosing = false;

        public FrmAnaSayfa(BackupService backupService, UpdateService updateService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _backupService = backupService;
            _updateService = updateService;
            _serviceProvider = serviceProvider;
            _displayName = "Admin";

            _updateService.NotifyMessage = (message, duration) => ShowSnackBar(message, duration);
            
            FormAyarlari();
            
            this.FormClosing += FrmAnaSayfa_FormClosing;
            CheckForUpdatesSilently();
        }

        public void SetUser(string displayName)
        {
            _displayName = displayName;
            lblHosgeldiniz.Text = $"Hoş Geldiniz, {_displayName}";
        }
        
        private async void CheckForUpdatesSilently()
        {
            await Task.Delay(2000); 
            await _updateService.CheckAndApplyUpdatesAsync(true);
        }

        private void FormAyarlari()
        {
            lblHosgeldiniz.Text = $"Hoş Geldiniz, {_displayName}";
            TarihSaatGuncelle();
        }

        private void TarihSaatGuncelle()
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd MMMM yyyy dddd - HH:mm:ss");
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            TarihSaatGuncelle();
        }

        private void btnSirketler_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmSirketIslemleri>())
            {
                frm.ShowDialog();
            }
        }

        private void btnHesaplamalar_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmHesaplamalar>())
            {
                frm.ShowDialog();
            }
        }

        private void btnIsTakip_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmIsTakip>())
            {
                frm.ShowDialog();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmDashboard>())
            {
                frm.ShowDialog();
            }
        }
        
        private async void FrmAnaSayfa_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (_isClosing) return;

            DialogResult result = MessageBox.Show(
                "Uygulamadan çıkmadan önce verileri yedeklemek istiyor musunuz?",
                "Yedekleme ve Çıkış Onayı",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                _isClosing = true;
                try
                {
                    await _backupService.CreateBackupAsync();
                    ShowSnackBar("Veriler başarıyla yedeklendi.", 3000); 
                }
                catch (Exception ex)
                {
                    ShowSnackBar($"Yedekleme sırasında bir hata oluştu: {ex.Message}", 5000); 
                }
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                _isClosing = true;
                Application.Exit();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmYedekleme>())
            {
                frm.ShowDialog();
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmSifreDegistir>())
            {
                frm.ShowDialog();
            }
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmIletisim>())
            {
                frm.ShowDialog();
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await _updateService.CheckAndApplyUpdatesAsync(false);
            Cursor.Current = Cursors.Default;
        }
    }
}