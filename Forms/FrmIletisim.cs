using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmIletisim : BaseForm
    {
        // Geliştirici E-posta Adresi - Burayı kendi mail adresinizle değiştirin
        private const string DeveloperEmail = "yusufhanyildiz10@gmail.com"; 

        public FrmIletisim()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtMesaj.Text) ||
                cmbKonu.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string subject = $"{cmbKonu.SelectedItem} - {txtAdSoyad.Text}";
                string body = $"Gönderen: {txtAdSoyad.Text}\n" +
                              $"E-Posta: {txtEmail.Text}\n\n" +
                              $"Mesaj:\n{txtMesaj.Text}";

                // Mailto linki oluşturma
                string mailtoUrl = $"mailto:{DeveloperEmail}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

                // Varsayılan mail uygulamasını açma
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mailtoUrl,
                    UseShellExecute = true
                };
                Process.Start(psi);

                MessageBox.Show("E-posta istemciniz açıldı. Lütfen gönder butonuna basarak işlemi tamamlayınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta istemcisi açılamadı.\nHata: {ex.Message}\n\nLütfen manuel olarak {DeveloperEmail} adresine mail atınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
