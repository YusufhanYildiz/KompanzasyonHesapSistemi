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
using Velopack;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmAnaSayfa : BaseForm
    {
        private string _displayName;
        private readonly BackupService _backupService; 
        private readonly UpdateService _updateService;
        private readonly IServiceProvider _serviceProvider;
        private bool _isClosing = false;
        private UpdateInfo? _pendingUpdate = null;

        public FrmAnaSayfa(BackupService backupService, UpdateService updateService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _backupService = backupService;
            _updateService = updateService;
            _serviceProvider = serviceProvider;
            _displayName = "Admin";

            _updateService.NotifyMessage = (message, duration) => 
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => ShowSnackBar(message, duration)));
                }
                else
                {
                    ShowSnackBar(message, duration);
                }
            };
            
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
            await Task.Delay(5000); // Açılışta sistemi yormamak için biraz daha bekle
            var updateInfo = await _updateService.CheckAndDownloadUpdatesAsync(true);
            
            if (updateInfo != null)
            {
                _pendingUpdate = updateInfo;
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => 
                    {
                        btnGuncelle.Text = "YENİDEN BAŞLAT";
                        btnGuncelle.BackColor = Color.DarkOrange; // Dikkat çek
                        ShowSnackBar("Yeni sürüm indirildi. Yüklemek için 'YENİDEN BAŞLAT' butonuna basın.", 5000);
                    }));
                }
                else
                {
                    btnGuncelle.Text = "YENİDEN BAŞLAT";
                    btnGuncelle.BackColor = Color.DarkOrange;
                    ShowSnackBar("Yeni sürüm indirildi. Yüklemek için 'YENİDEN BAŞLAT' butonuna basın.", 5000);
                }
            }
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

            e.Cancel = true;

            try
            {
                // Ensure settings are loaded
                await _backupService.InitializeAsync();

                if (_backupService.AutoBackupOnExit)
                {
                    // Otomatik yedekleme aktif
                    Cursor.Current = Cursors.WaitCursor;
                    // Kullanıcıya bilgi ver (kısa süreli) veya splash
                    // Form kapanırken MessageBox açmak can sıkıcı olabilir, ama güvenli.
                    // "Yedekleniyor..." diye bir yazı güncellemesi yapabiliriz status bar'da.
                    /* StatusStrip removed as it doesn't exist
                    if (statusStrip1 != null && statusStrip1.Items.Count > 0)
                         statusStrip1.Items[0].Text = "Otomatik yedek alınıyor, lütfen bekleyin...";
                    */
                    
                    await _backupService.CreateBackupAsync();
                    
                    Cursor.Current = Cursors.Default;
                    // Başarılı ise sessizce çık
                    _isClosing = true;
                    Application.Exit();
                }
                else
                {
                    // Manuel onay iste
                    DialogResult result = MessageBox.Show(
                        "Uygulamadan çıkmadan önce verileri yedeklemek istiyor musunuz?",
                        "Yedekleme ve Çıkış Onayı",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        await _backupService.CreateBackupAsync();
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Veriler başarıyla yedeklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _isClosing = true;
                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        _isClosing = true;
                        Application.Exit();
                    }
                    else
                    {
                        _isClosing = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show($"Yedekleme sırasında bir hata oluştu:\n{ex.Message}\n\nUygulama yine de kapatılsın mı?", 
                    "Yedekleme Hatası", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
                if (DialogResult.Yes == MessageBox.Show("Hata oluştu. Çıkış yapılsın mı?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                     _isClosing = true;
                     Application.Exit();
                }
                else
                {
                    _isClosing = false;
                }
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
            if (_pendingUpdate != null)
            {
                var result = MessageBox.Show(
                    "Güncelleme zaten indirildi ve hazır. Uygulamayı şimdi yeniden başlatıp güncellemek ister misiniz?",
                    "Güncelleme Hazır",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _updateService.ApplyUpdatesAndRestart(_pendingUpdate);
                }
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            var updateInfo = await _updateService.CheckAndDownloadUpdatesAsync(false);
            Cursor.Current = Cursors.Default;

            if (updateInfo != null)
            {
                _pendingUpdate = updateInfo;
                var result = MessageBox.Show(
                    "Güncelleme başarıyla indirildi. Uygulamayı şimdi yeniden başlatıp güncellemek ister misiniz?",
                    "Güncelleme Hazır",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _updateService.ApplyUpdatesAndRestart(updateInfo);
                }
                else
                {
                    btnGuncelle.Text = "YENİDEN BAŞLAT";
                    btnGuncelle.BackColor = Color.DarkOrange;
                }
            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            using (var frm = _serviceProvider.GetRequiredService<FrmAyarlar>())
            {
                frm.ShowDialog();
            }
        }
    }
}