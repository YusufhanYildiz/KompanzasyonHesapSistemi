using KompanzasyonHesapSistemi.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using System;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi
{
    public partial class FrmGiris : Form
    {
        private readonly JsonService _jsonService;

        public FrmGiris()
        {
            InitializeComponent();
            _jsonService = new JsonService();
        }

        /// <summary>
        /// Admin Girişi butonu
        /// </summary>
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtKullaniciAdi.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    MessageBox.Show("Şifre boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtSifre.Focus();
                    return;
                }

                // Admin bilgilerini JSON'dan oku veya varsayılan oluştur
                var adminCredentials = _jsonService.ReadData<AdminCredentials>("admin_credentials.json");
                
                if (adminCredentials == null)
                {
                    // İlk kullanımda varsayılan admin oluştur
                    adminCredentials = AdminCredentials.CreateDefault();
                    _jsonService.SaveData("admin_credentials.json", adminCredentials);
                    
                    MessageBox.Show(
                        "İlk kullanım tespit edildi!\n\n" +
                        "Varsayılan admin bilgileri oluşturuldu:\n" +
                        "Kullanıcı adı: admin\n" +
                        "Şifre: admin123\n\n" +
                        "Lütfen giriş yapın.", 
                        "İlk Kurulum", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    return;
                }

                // Kullanıcı adı ve şifre kontrolü (BCrypt hash ile)
                if (txtKullaniciAdi.Text.Trim() == adminCredentials.Username && 
                    PasswordService.VerifyPassword(txtSifre.Text, adminCredentials.PasswordHash))
                {
                    // Giriş başarılı, son giriş tarihini güncelle
                    adminCredentials.LastLoginAt = DateTime.UtcNow;
                    _jsonService.SaveData("admin_credentials.json", adminCredentials);
                    
                    // Lisansı tam sürüme yükselt
                    var licenseService = new LicenseService();
                    var hardwareId = HardwareService.GetHardwareId();

                    var licenseInfo = new LicenseInfo
                    {
                        HardwareId = hardwareId,
                        LicenseType = LicenseType.Full,
                        StartDate = DateTime.UtcNow
                    };
                    
                    licenseService.SaveLicense(licenseInfo);

                    MessageBox.Show("Admin girişi başarılı! Program tam sürüm olarak lisanslandı.", "Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Ana sayfayı aç
                    FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa("Admin");
                    frmAnaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    // Giriş başarısız
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtSifre.Clear();
                    txtKullaniciAdi.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giriş hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Demo Girişi butonu
        /// </summary>
        private void btnDemoGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var licenseService = new LicenseService();
                var hardwareId = HardwareService.GetHardwareId();

                if (hardwareId.Contains("ERROR"))
                {
                    MessageBox.Show("Donanım kimliği okunamadı. Program açılamıyor.", "Lisans Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var licenseInfo = licenseService.GetLicense();

                if (licenseInfo == null || licenseInfo.HardwareId != hardwareId)
                {
                    // İlk kullanım veya başka bir PC'den kopyalanmış data durumu. Yeni demo lisansı oluştur.
                    licenseInfo = new LicenseInfo
                    {
                        HardwareId = hardwareId,
                        LicenseType = LicenseType.Demo,
                        StartDate = DateTime.UtcNow
                    };
                    licenseService.SaveLicense(licenseInfo);

                    MessageBox.Show("Programa hoş geldiniz! 30 günlük deneme sürümünüz başladı.", "Demo Başladı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa("Demo Kullanıcısı");
                    frmAnaSayfa.Show();
                    this.Hide();
                }
                else if (licenseInfo.LicenseType == LicenseType.Full)
                {
                    MessageBox.Show("Program zaten tam sürüm olarak lisanslı. Lütfen Admin girişi yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Demo lisansı var ve HWID eşleşiyor
                {
                    var elapsedDays = (DateTime.UtcNow - licenseInfo.StartDate).TotalDays;
                    if (elapsedDays > 30)
                    {
                        MessageBox.Show("30 günlük deneme süreniz dolmuştur. Programı kullanmaya devam etmek için lütfen admin olarak giriş yapıp lisansınızı yükseltin.", "Deneme Süresi Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int remainingDays = (int)Math.Ceiling(30 - elapsedDays);
                        MessageBox.Show($"Deneme sürümünüzün bitmesine {remainingDays} gün kaldı.", "Demo Sürüm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa("Demo Kullanıcısı");
                        frmAnaSayfa.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Demo giriş hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Şifreyi göster/gizle
        /// </summary>
        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '*';
        }


        /// <summary>
        /// Enter tuşu ile giriş
        /// </summary>
        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGirisYap_Click(sender, e);
            }
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}