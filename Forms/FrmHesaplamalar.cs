using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using System.Linq;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmHesaplamalar : Form
    {
        private readonly JsonService _jsonService;
        private readonly HesaplamaService _hesaplamaService;
        private readonly ExcelService _excelService;
        private const string SIRKETLER_FILE = "sirketler.json";

        public FrmHesaplamalar()
        {
            InitializeComponent();
            _jsonService = new JsonService();
            _hesaplamaService = new HesaplamaService();
            _excelService = new ExcelService();

            ThemeHelper.ApplyTheme(this);

            DataGridViewAyarlari();
            SirketleriYukle();
            HesaplamalariYukle();
            
            // DataGridView çift tıklama olayını bağla
            dgvHesaplamalar.CellDoubleClick += DgvHesaplamalar_CellDoubleClick;
        }
        /// <summary>
        /// Şirketleri ComboBox'a yükle
        /// </summary>
        private void SirketleriYukle()
        {
            try
            {
                var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);

                cmbSirket.DataSource = null;
                cmbSirket.DataSource = sirketler;
                cmbSirket.DisplayMember = "SirketAdi";
                cmbSirket.ValueMember = "Id";

                if (cmbSirket.Items.Count > 0)
                {
                    cmbSirket.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şirketler yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// DataGridView ayarları
        /// </summary>
        private void DataGridViewAyarlari()
        {
            dgvHesaplamalar.AutoGenerateColumns = false;
            dgvHesaplamalar.Columns.Clear();

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 40
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tarih",
                HeaderText = "Tarih",
                DataPropertyName = "Tarih",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SirketAdi",
                HeaderText = "Şirket Adı",
                DataPropertyName = "SirketAdi",
                Width = 120
            });

            // ========== ÖNCEKİ SAYAÇ DEĞERLERİ ==========
            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OncekiAktif",
                HeaderText = "Önc. Aktif",
                DataPropertyName = "OncekiAktif",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OncekiEnduktif",
                HeaderText = "Önc. Endüktif",
                DataPropertyName = "OncekiEnduktif",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OncekiKapasitif",
                HeaderText = "Önc. Kapasitif",
                DataPropertyName = "OncekiKapasitif",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            // ========== MEVCUT SAYAÇ DEĞERLERİ ==========
            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MevcutAktif",
                HeaderText = "Mev. Aktif",
                DataPropertyName = "MevcutAktif",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MevcutEnduktif",
                HeaderText = "Mev. Endüktif",
                DataPropertyName = "MevcutEnduktif",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MevcutKapasitif",
                HeaderText = "Mev. Kapasitif",
                DataPropertyName = "MevcutKapasitif",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            // ========== HESAPLANAN TÜKETİM (FARK) ==========
            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AktifTuketim",
                HeaderText = "Aktif Tük.",
                DataPropertyName = "AktifTuketim",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EnduktifTuketim",
                HeaderText = "End. Tük.",
                DataPropertyName = "EnduktifTuketim",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "KapasitifTuketim",
                HeaderText = "Kap. Tük.",
                DataPropertyName = "KapasitifTuketim",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            // ========== ORANLAR VE CEZA ==========
            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EnduktifOran",
                HeaderText = "End. Oran (%)",
                DataPropertyName = "EnduktifOran",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "KapasitifOran",
                HeaderText = "Kap. Oran (%)",
                DataPropertyName = "KapasitifOran",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CezaDurumu",
                HeaderText = "Ceza Durumu",
                DataPropertyName = "CezaDurumu",
                Width = 100
            });
        }
        /// <summary>
        /// Hesaplamaları yükle
        /// </summary>
        private void GosterimListesiniGuncelle(List<Hesaplama> hesaplamalar)
        {
            dgvHesaplamalar.DataSource = null;
            dgvHesaplamalar.DataSource = hesaplamalar;

            // Ceza durumuna göre satır renklendirme
            foreach (DataGridViewRow row in dgvHesaplamalar.Rows)
            {
                if (row.Cells["CezaDurumu"].Value?.ToString() == "CEZA VAR")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }

            if (dgvHesaplamalar.Rows.Count > 0)
            {
                dgvHesaplamalar.ClearSelection();
            }
        }

        /// <summary>
        /// Hesaplamaları yükle
        /// </summary>
        private void HesaplamalariYukle()
        {
            try
            {
                var hesaplamalar = _hesaplamaService.TumHesaplamalariGetir();
                GosterimListesiniGuncelle(hesaplamalar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hesaplamalar yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // Şirket seçimi kontrolü
                if (cmbSirket.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir şirket seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSirket.Focus();
                    return;
                }

                // ========== ÖNCEKİ DEĞERLER (Zorunlu) ==========
                if (!double.TryParse(txtOncekiAktif.Text, out double oncekiAktif) || oncekiAktif < 0)
                {
                    MessageBox.Show("Önceki aktif tüketim geçerli bir sayı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOncekiAktif.Focus();
                    return;
                }

                if (!double.TryParse(txtOncekiEnduktif.Text, out double oncekiEnduktif) || oncekiEnduktif < 0)
                {
                    MessageBox.Show("Önceki endüktif tüketim geçerli bir sayı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOncekiEnduktif.Focus();
                    return;
                }

                if (!double.TryParse(txtOncekiKpstfTuketim.Text, out double oncekiKapasitif) || oncekiKapasitif < 0)
                {
                    MessageBox.Show("Önceki kapasitif tüketim geçerli bir sayı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOncekiKpstfTuketim.Focus();
                    return;
                }

                // ========== MEVCUT DEĞERLER ==========
                if (!double.TryParse(txtAktif.Text, out double mevcutAktif) || mevcutAktif < 0)
                {
                    MessageBox.Show("Mevcut aktif tüketim geçerli bir sayı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAktif.Focus();
                    return;
                }

                if (!double.TryParse(txtEnduktif.Text, out double mevcutEnduktif) || mevcutEnduktif < 0)
                {
                    MessageBox.Show("Mevcut endüktif tüketim geçerli bir sayı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEnduktif.Focus();
                    return;
                }

                if (!double.TryParse(txtKapasitif.Text, out double mevcutKapasitif) || mevcutKapasitif < 0)
                {
                    MessageBox.Show("Mevcut kapasitif tüketim geçerli bir sayı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKapasitif.Focus();
                    return;
                }

                // ========== FARK HESAPLAMA (Mevcut - Önceki) ==========
                double aktifTuketim = mevcutAktif - oncekiAktif;
                double enduktifTuketim = mevcutEnduktif - oncekiEnduktif;
                double kapasitifTuketim = mevcutKapasitif - oncekiKapasitif;

                // Fark değerlerinin negatif olmaması kontrolü
                if (aktifTuketim <= 0)
                {
                    MessageBox.Show("Mevcut aktif tüketim, önceki değerden büyük olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAktif.Focus();
                    return;
                }

                if (enduktifTuketim < 0)
                {
                    MessageBox.Show("Mevcut endüktif tüketim, önceki değerden küçük olamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEnduktif.Focus();
                    return;
                }

                if (kapasitifTuketim < 0)
                {
                    MessageBox.Show("Mevcut kapasitif tüketim, önceki değerden küçük olamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKapasitif.Focus();
                    return;
                }

                // Seçilen şirketi al
                if (cmbSirket.SelectedItem is not Sirket secilenSirket)
                {
                    MessageBox.Show("Lütfen bir şirket seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hesaplama nesnesi oluştur (TÜM DEĞERLERİ İLE)
                var hesaplama = new Hesaplama
                {
                    SirketId = secilenSirket.Id,
                    SirketAdi = secilenSirket.SirketAdi,
                    Tarih = dtpTarih.Value,
                    
                    // Önceki sayaç değerleri
                    OncekiAktif = oncekiAktif,
                    OncekiEnduktif = oncekiEnduktif,
                    OncekiKapasitif = oncekiKapasitif,
                    
                    // Mevcut sayaç değerleri
                    MevcutAktif = mevcutAktif,
                    MevcutEnduktif = mevcutEnduktif,
                    MevcutKapasitif = mevcutKapasitif,
                    
                    // Hesaplanan tüketim (fark)
                    AktifTuketim = aktifTuketim,
                    EnduktifTuketim = enduktifTuketim,
                    KapasitifTuketim = kapasitifTuketim
                };

                // Hesaplama yap
                hesaplama.HesaplaOranlari();

                // Sonuçları göster
                lblEnduktifOran.Text = $"Endüktif Oran: %{hesaplama.EnduktifOran:F2}";
                lblKapasitifOran.Text = $"Kapasitif Oran: %{hesaplama.KapasitifOran:F2}";

                // Ceza durumunu göster
                if (hesaplama.CezaDurumu == "CEZA VAR")
                {
                    lblCezaDurumuSonuc.Text = "CEZA VAR";
                    lblCezaDurumuSonuc.ForeColor = Color.Red;
                    gbCezaDurumu.BackColor = Color.LightPink;
                }
                else
                {
                    lblCezaDurumuSonuc.Text = "CEZA YOK";
                    lblCezaDurumuSonuc.ForeColor = Color.Green;
                    gbCezaDurumu.BackColor = Color.LightGreen;
                }

                // Veritabanına kaydet
                _hesaplamaService.HesaplamaEkle(hesaplama);

                MessageBox.Show("Hesaplama başarıyla kaydedildi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile ve alanları temizle
                HesaplamalariYukle();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hesaplama hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Alanları temizle
        /// </summary>
        private void AlanlariTemizle()
        {
            cmbSirket.SelectedIndex = -1;
            
            // Önceki değerleri temizle
            txtOncekiAktif.Clear();
            txtOncekiEnduktif.Clear();
            txtOncekiKpstfTuketim.Clear();
            
            // Mevcut değerleri temizle
            txtAktif.Clear();
            txtEnduktif.Clear();
            txtKapasitif.Clear();
            
            dtpTarih.Value = DateTime.Now;

            lblEnduktifOran.Text = "Endüktif Oran: %0,00";
            lblKapasitifOran.Text = "Kapasitif Oran: %0,00";
            lblCezaDurumuSonuc.Text = "CEZA YOK";
            lblCezaDurumuSonuc.ForeColor = Color.Green;
            gbCezaDurumu.BackColor = SystemColors.Control;

            cmbSirket.Focus();
        }
        /// <summary>
        /// Temizle butonu
        /// </summary>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHesaplamalar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek kaydı seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bu kaydı silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvHesaplamalar.SelectedRows[0].Cells["Id"].Value);
                    _hesaplamaService.HesaplamaSil(id);

                    MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HesaplamalariYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Yenile butonu
        /// </summary>
        private void btnYenile_Click(object sender, EventArgs e)
        {
            HesaplamalariYukle();
        }
        /// <summary>
        /// PDF Rapor butonu (Şimdilik boş, sonra ekleyeceğiz)
        /// </summary>
        private void btnPdfRapor_Click(object sender, EventArgs e)
        {
            try
            {
                var hesaplamalar = _hesaplamaService.TumHesaplamalariGetir();

                if (hesaplamalar.Count == 0)
                {
                    MessageBox.Show("Rapor oluşturmak için en az bir hesaplama kaydı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcıya sor: Tüm kayıtlar mı, sadece seçili şirket mi?
                DialogResult result = MessageBox.Show(
                    "Tüm hesaplamalar için rapor oluşturulsun mu?\n\n" +
                    "EVET: Tüm kayıtlar\n" +
                    "HAYIR: Sadece seçili şirket",
                    "Rapor Türü",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Cancel)
                    return;

                List<Hesaplama> raporHesaplamalari;
                string? sirketAdi = null;

                if (result == DialogResult.No)
                {
                    // Sadece seçili şirket
                    if (cmbSirket.SelectedIndex == -1 || cmbSirket.SelectedItem is not Sirket secilenSirket)
                    {
                        MessageBox.Show("Lütfen bir şirket seçiniz!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    raporHesaplamalari = hesaplamalar.Where(h => h.SirketId == secilenSirket.Id).ToList();
                    sirketAdi = secilenSirket.SirketAdi;

                    if (raporHesaplamalari.Count == 0)
                    {
                        MessageBox.Show("Seçili şirket için hesaplama kaydı bulunamadı!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    // Tüm kayıtlar
                    raporHesaplamalari = hesaplamalar;
                }

                PdfService pdfService = new PdfService();
                string dosyaYolu = pdfService.HesaplamaRaporuOlustur(raporHesaplamalari, sirketAdi ?? string.Empty);

                DialogResult acilsinMi = MessageBox.Show(
                    $"PDF rapor başarıyla oluşturuldu!\n\n{dosyaYolu}\n\nRaporu açmak ister misiniz?",
                    "Başarılı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (acilsinMi == DialogResult.Yes)
                {
                    pdfService.PdfAc(dosyaYolu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PDF oluşturma hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Kapat butonu
        /// </summary>
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                var baslangicTarihi = dtpBaslangic.Value.Date;
                var bitisTarihi = dtpBitis.Value.Date;

                if (baslangicTarihi > bitisTarihi)
                {
                    MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tumHesaplamalar = _hesaplamaService.TumHesaplamalariGetir();
                var filtrelenmisListe = tumHesaplamalar
                    .Where(h => h.Tarih.Date >= baslangicTarihi && h.Tarih.Date <= bitisTarihi)
                    .ToList();

                GosterimListesiniGuncelle(filtrelenmisListe);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtreleme sırasında bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            HesaplamalariYukle();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            _excelService.ExportToExcel(dgvHesaplamalar);
        }

        /// <summary>
        /// DataGridView'e çift tıklandığında seçili satırın mevcut değerlerini önceki alanlara aktarır
        /// </summary>
        private void DgvHesaplamalar_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Header satırına tıklanmışsa işlem yapma
                if (e.RowIndex < 0)
                    return;

                // Seçili satırı al
                var selectedRow = dgvHesaplamalar.Rows[e.RowIndex];

                // Mevcut değerleri al ve önceki alanlara aktar
                var mevcutAktif = selectedRow.Cells["MevcutAktif"].Value;
                var mevcutEnduktif = selectedRow.Cells["MevcutEnduktif"].Value;
                var mevcutKapasitif = selectedRow.Cells["MevcutKapasitif"].Value;

                // Textbox'lara değerleri yaz
                txtOncekiAktif.Text = mevcutAktif?.ToString() ?? "0";
                txtOncekiEnduktif.Text = mevcutEnduktif?.ToString() ?? "0";
                txtOncekiKpstfTuketim.Text = mevcutKapasitif?.ToString() ?? "0";

                // Ayrıca şirketi ve tarihi de seçebiliriz (opsiyonel)
                var sirketId = selectedRow.Cells["Id"].Value;
                var sirketAdi = selectedRow.Cells["SirketAdi"].Value?.ToString();

                // Şirketi otomatik seç
                if (sirketAdi != null)
                {
                    for (int i = 0; i < cmbSirket.Items.Count; i++)
                    {
                        var sirket = cmbSirket.Items[i] as Sirket;
                        if (sirket != null && sirket.SirketAdi == sirketAdi)
                        {
                            cmbSirket.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // Kullanıcıya bilgi ver
                MessageBox.Show(
                    $"Seçilen kaydın mevcut değerleri önceki alanlara aktarıldı:\n\n" +
                    $"Önceki Aktif: {txtOncekiAktif.Text}\n" +
                    $"Önceki Endüktif: {txtOncekiEnduktif.Text}\n" +
                    $"Önceki Kapasitif: {txtOncekiKpstfTuketim.Text}\n\n" +
                    $"Şimdi mevcut sayaç değerlerini girebilirsiniz.",
                    "Değerler Aktarıldı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Mevcut aktif alanına odaklan
                txtAktif.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Değerler aktarılırken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
