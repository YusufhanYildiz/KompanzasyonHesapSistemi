using KompanzasyonHesapSistemi.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace KompanzasyonHesapSistemi
{
    public partial class FrmGiris : BaseForm
    {
        private readonly AuthService _authService;
        private readonly LicenseService _licenseService;
        private readonly IServiceProvider _serviceProvider;
        private readonly TimeService _timeService;
        private readonly HardwareService _hardwareService;

        public FrmGiris(AuthService authService, LicenseService licenseService, IServiceProvider serviceProvider, TimeService timeService, HardwareService hardwareService)
        {
            InitializeComponent();
            _authService = authService;
            _licenseService = licenseService;
            _serviceProvider = serviceProvider;
            _timeService = timeService;
            _hardwareService = hardwareService;
            this.AcceptButton = btnGirisYap;
        }

        private async void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
                {
                    MessageBox.Show("Kullanıcı adı boş olamaz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    MessageBox.Show("Şifre boş olamaz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var adminCredentials = await _authService.GetAdminCredentialsAsync();
                
                if (adminCredentials == null || string.IsNullOrEmpty(adminCredentials.PasswordHash))
                {
                    adminCredentials = await _authService.InitializeDefaultAdminAsync();
                    
                    MessageBox.Show(
                        "İlk kullanım tespit edildi!\n\n" +
                        "Varsayılan admin bilgileri oluşturuldu:\n" +
                        "Lütfen giriş yapın.", 
                        "İlk Kurulum", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    return;
                }

                if (txtKullaniciAdi.Text.Trim() == adminCredentials.Username && 
                    PasswordService.VerifyPassword(txtSifre.Text, adminCredentials.PasswordHash))
                {
                    await _authService.UpdateLastLoginAsync(adminCredentials.Username);
                    
                    var hardwareId = _hardwareService.GetHardwareId();

                    var licenseInfo = new LicenseInfo
                    {
                        HardwareId = hardwareId,
                        LicenseType = LicenseType.Full,
                        StartDate = DateTime.UtcNow
                    };
                    
                    await _licenseService.SaveLicenseAsync(licenseInfo);

                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Admin girişi başarılı! Program tam sürüm olarak lisanslandı.", "TAMAM", true);
                    SnackBarMessage.Show(this);

                    var frmAnaSayfa = _serviceProvider.GetRequiredService<FrmAnaSayfa>();
                    frmAnaSayfa.SetUser("Admin");
                    frmAnaSayfa.Show();
                    this.Hide();
                }
                else
                {
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

        private async void btnDemoGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Information("Demo girişi başlatılıyor...");
                var hardwareId = _hardwareService.GetHardwareId();
                Log.Information("Hardware ID alındı: {HardwareId}", hardwareId);

                if (hardwareId.Contains("ERROR"))
                {
                    Log.Error("Hardware ID hatalı: {HardwareId}", hardwareId);
                    MessageBox.Show("Donanım kimliği okunamadı. Program açılamıyor.", "Lisans Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime currentTime = await _timeService.GetReliableTimeAsync();
                Log.Information("Güvenilir zaman alındı: {CurrentTime}", currentTime);

                var licenseInfo = await _licenseService.GetLicenseAsync();
                Log.Information("Lisans bilgisi alındı. LicenseType: {LicenseType}, HWID: {LicenseHWID}", licenseInfo.LicenseType, licenseInfo.HardwareId);

                if (licenseInfo == null || licenseInfo.HardwareId != hardwareId)
                {
                    Log.Information("Yeni demo lisansı oluşturuluyor...");
                    licenseInfo = new LicenseInfo
                    {
                        HardwareId = hardwareId,
                        LicenseType = LicenseType.Demo,
                        StartDate = currentTime
                    };
                    await _licenseService.SaveLicenseAsync(licenseInfo);
                    Log.Information("Demo lisansı kaydedildi");

                    MessageBox.Show("Programa hoş geldiniz! 30 günlük deneme sürümünüz başladı.", "Demo Başladı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var frmAnaSayfa = _serviceProvider.GetRequiredService<FrmAnaSayfa>();
                    frmAnaSayfa.SetUser("Demo Kullanıcısı");
                    frmAnaSayfa.Show();
                    this.Hide();
                }
                else if (licenseInfo.LicenseType == LicenseType.Full)
                {
                    Log.Information("Program tam sürüm olarak lisanslı");
                    MessageBox.Show("Program zaten tam sürüm olarak lisanslı. Lütfen Admin girişi yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var elapsedDays = (currentTime - licenseInfo.StartDate).TotalDays;
                    Log.Information("Demo süresi kontrol ediliyor. Geçen gün: {ElapsedDays}", elapsedDays);
                    if (elapsedDays > 30)
                    {
                        Log.Warning("Demo süresi doldu: {ElapsedDays} gün", elapsedDays);
                        MessageBox.Show("30 günlük deneme süreniz dolmuştur. Programı kullanmaya devam etmek için lütfen admin olarak giriş yapıp lisansınızı yükseltin.", "Deneme Süresi Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int remainingDays = (int)Math.Ceiling(30 - elapsedDays);
                        Log.Information("Demo sürümü aktif. Kalan gün: {RemainingDays}", remainingDays);
                        MessageBox.Show($"Deneme sürümünüzün bitmesine {remainingDays} gün kaldı.", "Demo Sürüm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var frmAnaSayfa = _serviceProvider.GetRequiredService<FrmAnaSayfa>();
                        frmAnaSayfa.SetUser("Demo Kullanıcısı");
                        frmAnaSayfa.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Demo giriş hatası");
                MessageBox.Show($"Demo giriş hatası:\n{ex.Message}\n\nDetaylar: {ex.StackTrace}", "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '*';
        }

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