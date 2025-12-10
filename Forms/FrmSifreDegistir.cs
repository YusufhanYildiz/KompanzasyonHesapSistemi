using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using System;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmSifreDegistir : Form
    {
        private readonly JsonService _jsonService;

        public FrmSifreDegistir()
        {
            
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            _jsonService = new JsonService();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtEskiSifre.Text) || 
                    string.IsNullOrWhiteSpace(txtYeniSifre.Text) || 
                    string.IsNullOrWhiteSpace(txtYeniSifreTekrar.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Yeni şifreler eşleşiyor mu?
                if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                {
                    MessageBox.Show("Yeni şifreler birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Mevcut admin bilgilerini oku
                var adminCredentials = _jsonService.ReadData<AdminCredentials>("admin_credentials.json");
                if (adminCredentials == null)
                {
                    MessageBox.Show("Admin bilgileri okunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Eski şifre doğru mu?
                if (!PasswordService.VerifyPassword(txtEskiSifre.Text, adminCredentials.PasswordHash))
                {
                    MessageBox.Show("Eski şifreniz hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 5. Yeni şifreyi kaydet
                adminCredentials.PasswordHash = PasswordService.HashPassword(txtYeniSifre.Text);
                _jsonService.SaveData("admin_credentials.json", adminCredentials);

                MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
