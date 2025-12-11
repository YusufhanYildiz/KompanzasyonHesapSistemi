using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services; // Add this line
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
    public partial class FrmAnaSayfa : Form
    {
        private readonly string _displayName;
        private readonly JsonService _jsonService; 
        private readonly BackupService _backupService; 
        private bool _isClosing = false; // Çıkış işleminin tekrar tetiklenmesini önlemek için bayrak

        public FrmAnaSayfa(string displayName)
        {
            InitializeComponent();
            _displayName = displayName;
            _jsonService = new JsonService(); 
            _backupService = new BackupService(_jsonService);
            
            // Modern Temayı Uygula
            ThemeHelper.ApplyTheme(this);
            
            FormAyarlari();
            
            this.FormClosing += FrmAnaSayfa_FormClosing;
        }
        
        private void FormAyarlari()
        {
            lblHosgeldiniz.Text = $"Hoş Geldiniz, {_displayName}";
            TarihSaatGuncelle();
        }
        /// <summary>
        /// Tarih saat güncelle
        /// </summary>
        private void TarihSaatGuncelle()
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd MMMM yyyy dddd - HH:mm:ss");
        }
        /// <summary>
        /// Timer tick - Her saniye tarih saat güncelle
        /// </summary>
        private void timerSaat_Tick(object sender, EventArgs e)
        {
            TarihSaatGuncelle();
        }
        /// <summary>
        /// Şirket İşlemleri butonu
        /// </summary>
        private void btnSirketler_Click(object sender, EventArgs e)
        {
            FrmSirketIslemleri frm = new FrmSirketIslemleri();
            frm.ShowDialog();
        }
        /// <summary>
        /// Hesaplamalar butonu
        /// </summary>
        private void btnHesaplamalar_Click(object sender, EventArgs e)
        {
            FrmHesaplamalar frm = new FrmHesaplamalar();
            frm.ShowDialog();
        }
        /// <summary>
        /// İş Takip butonu
        /// </summary>
        private void btnIsTakip_Click(object sender, EventArgs e)
        {
            FrmIsTakip frm = new FrmIsTakip();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // FormClosing event'ini tetikleyerek merkezi çıkış mantığını kullanır.
            this.Close();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.ShowDialog();
        }
        
        /// <summary>
        /// Form kapatılırken çalışan merkezi çıkış mantığı.
        /// Hem 'X' butonu hem de 'Çıkış Yap' butonu bu metodu tetikler.
        /// </summary>
        private async void FrmAnaSayfa_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Eğer zaten bir kapanma işlemi devam ediyorsa, tekrar çalıştırma.
            if (_isClosing) return;

            // Kullanıcıya yedekleme seçeneğini sun.
            DialogResult result = MessageBox.Show(
                "Uygulamadan çıkmadan önce verileri yedeklemek istiyor musunuz?",
                "Yedekleme ve Çıkış Onayı",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                _isClosing = true; // Kapanma işlemini başlat.
                try
                {
                    await _backupService.CreateBackupAsync();
                    MessageBox.Show("Veriler başarıyla yedeklendi.", "Yedekleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Yedekleme sırasında bir hata oluştu: {ex.Message}", "Yedekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit(); // Uygulamayı kapat.
            }
            else if (result == DialogResult.No)
            {
                _isClosing = true; // Kapanma işlemini başlat.
                Application.Exit(); // Yedekleme yapmadan uygulamayı kapat.
            }
            else if (result == DialogResult.Cancel)
            {
                // Kapatma işlemini iptal et. Bayrak set edilmez.
                e.Cancel = true;
            }
        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            // Yedekleme formunu, mevcut backupService örneğiyle başlat
            FrmYedekleme frm = new FrmYedekleme(_backupService);
            frm.ShowDialog();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            FrmSifreDegistir frm = new FrmSifreDegistir();
            frm.ShowDialog();
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            FrmIletisim frm = new FrmIletisim();
            frm.ShowDialog();
        }
    }
}
