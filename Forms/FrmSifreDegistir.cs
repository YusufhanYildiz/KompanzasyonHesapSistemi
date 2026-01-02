using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmSifreDegistir : BaseForm
    {
        private readonly AuthService _authService;

        public FrmSifreDegistir(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEskiSifre.Text) || 
                    string.IsNullOrWhiteSpace(txtYeniSifre.Text) || 
                    string.IsNullOrWhiteSpace(txtYeniSifreTekrar.Text))
                {
                    NotifyWarning("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                {
                    NotifyError("Yeni şifreler birbiriyle uyuşmuyor!");
                    return;
                }

                var adminCredentials = await _authService.GetAdminCredentialsAsync();
                if (adminCredentials == null)
                {
                    NotifyError("Admin bilgileri okunamadı!");
                    return;
                }

                if (!PasswordService.VerifyPassword(txtEskiSifre.Text, adminCredentials.PasswordHash))
                {
                    NotifyError("Eski şifreniz hatalı!");
                    return;
                }

                adminCredentials.PasswordHash = PasswordService.HashPassword(txtYeniSifre.Text);
                await _authService.SaveAdminCredentialsAsync(adminCredentials);

                NotifySuccess("Şifreniz başarıyla değiştirildi.");
                this.Close();
            }
            catch (Exception ex)
            {
                NotifyError($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}