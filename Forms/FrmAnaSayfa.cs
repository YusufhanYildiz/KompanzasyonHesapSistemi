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
            DialogResult result = MessageBox.Show(
                "Çıkış yapmak istediğinize emin misiniz?",
                "Çıkış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı tamamen kapat
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.ShowDialog();
        }
        /// <summary>
        /// Form kapatılırken uygulamayı kapat
        /// </summary>
        private async void FrmAnaSayfa_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Uygulamadan çıkış yapılıyor. Veriler yedeklensin mi?",
                "Yedekleme Onayı",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    await _backupService.CreateBackupAsync();
                    MessageBox.Show("Veriler başarıyla yedeklendi.", "Yedekleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Yedekleme sırasında bir hata oluştu: {ex.Message}", "Yedekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Kapatma işlemini iptal et
                return;
            }

            // Normalde bu kısımdan sonra uygulama kapanır.
            // Eğer FrmGiris'e geri dönülüyorsa, Application.Exit() burada çağrılmamalıdır.
            // btnCikis_Click zaten `this.Close()` çağırıp FrmGiris'i gösteriyor.
            // Bu event, pencere kapatma tuşuna basıldığında da tetiklenir.
            // Eğer uygulama tamamen kapanacaksa (örn: ana pencere X tuşu ile kapatıldığında) Application.Exit() çağrılabilir.
            // Ancak, FrmGiris'e geçiş senaryosunda Application.Exit() uygun olmayabilir.
            // Mevcut yapıda FrmGiris zaten tekrar gösterildiği için, buradaki Application.Exit() kaldırılabilir
            // veya sadece ana uygulama tamamen kapatıldığında çağrılacak bir mekanizma kurulabilir.
            // Şimdilik, FrmGiris'e geçişten sonra ana form kapanacağından, burada Application.Exit() çağırmıyorum.
            // Eğer FrmGiris'e dönülmüyorsa ve uygulama tamamen kapanıyorsa bu kod satırı gerekli olabilir.
            // Application.Exit(); 
        }

        private async void btnManualBackup_Click(object sender, EventArgs e)
        {
            try
            {
                await _backupService.CreateBackupAsync();
                MessageBox.Show("Manuel yedekleme başarıyla tamamlandı!", "Yedekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Manuel yedekleme sırasında bir hata oluştu: {ex.Message}", "Yedekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
