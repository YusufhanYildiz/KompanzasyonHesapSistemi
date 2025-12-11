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

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmIsTakip : Form
    {
        private readonly JsonService _jsonService;
        private readonly ExcelService _excelService;
        private const string ISTAKIP_FILE = "istakip.json";
        private const string SIRKETLER_FILE = "sirketler.json";
        private int _secilenIsId = 0;

        public FrmIsTakip()
        {
            InitializeComponent();
            _jsonService = new JsonService();
            _excelService = new ExcelService();

            ThemeHelper.ApplyTheme(this);

            DataGridViewAyarlari();
            SirketleriYukle();
            IsleriYukle();
            OzetBilgileriGuncelle();


            // TextBox'lara KeyPress event'i ekle
            txtIsUcreti.KeyPress += SayisalAlan_KeyPress;
            txtAlinanTutar.KeyPress += SayisalAlan_KeyPress;

            // TextBox'lara TextChanged event'i ekle (bakiye hesaplama için)
            txtIsUcreti.TextChanged += Bakiye_TextChanged;
            txtAlinanTutar.TextChanged += Bakiye_TextChanged;
        }
        private void SayisalAlan_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece rakam, backspace, virgül ve nokta kabul et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Virgül ve noktadan sadece bir tane olsun
            if (sender is TextBox txt && (e.KeyChar == ',' || e.KeyChar == '.') &&
                (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Bakiye hesapla ve göster
        /// </summary>
        private void Bakiye_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                decimal isUcreti = 0;
                decimal alinanTutar = 0;

                if (!string.IsNullOrWhiteSpace(txtIsUcreti.Text))
                {
                    decimal.TryParse(txtIsUcreti.Text.Replace('.', ','), out isUcreti);
                }

                if (!string.IsNullOrWhiteSpace(txtAlinanTutar.Text))
                {
                    decimal.TryParse(txtAlinanTutar.Text.Replace('.', ','), out alinanTutar);
                }

                decimal bakiye = isUcreti - alinanTutar;
                lblBakiyeGoster.Text = $"Bakiye: ₺{bakiye:N2}";
                lblBakiyeGoster.ForeColor = bakiye >= 0 ? Color.Green : Color.Red;
            }
            catch { }
        }
        /// <summary>
        /// Şirketleri ComboBox'a yükle
        /// </summary>
        private void SirketleriYukle()
        {
            try
            {
                var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);

                // Veri girişi için
                cmbSirket.DataSource = null;
                cmbSirket.DataSource = new List<Sirket>(sirketler);
                cmbSirket.DisplayMember = "SirketAdi";
                cmbSirket.ValueMember = "Id";
                cmbSirket.SelectedIndex = -1;

                // Filtreleme için
                var filtreSirketler = new List<Sirket>(sirketler);
                cmbSirketFiltrele.DataSource = null;
                cmbSirketFiltrele.DataSource = filtreSirketler;
                cmbSirketFiltrele.DisplayMember = "SirketAdi";
                cmbSirketFiltrele.ValueMember = "Id";
                cmbSirketFiltrele.SelectedIndex = -1;
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
            dgvIsler.AutoGenerateColumns = false;
            dgvIsler.Columns.Clear();

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tarih",
                HeaderText = "Tarih",
                DataPropertyName = "Tarih",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SirketAdi",
                HeaderText = "Şirket Adı",
                DataPropertyName = "SirketAdi",
                Width = 150
            });

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IsAciklamasi",
                HeaderText = "İş Açıklaması",
                DataPropertyName = "IsAciklamasi",
                Width = 200
            });

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IsUcreti",
                HeaderText = "İş Ücreti (₺)",
                DataPropertyName = "IsUcreti",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AlinanTutar",
                HeaderText = "Alınan (₺)",
                DataPropertyName = "AlinanTutar",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvIsler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Bakiye",
                HeaderText = "Bakiye (₺)",
                DataPropertyName = "Bakiye",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
        }
        /// <summary>
        /// İşleri yükle
        /// </summary>
        private void IsleriYukle()
        {
            try
            {
                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);
                dgvIsler.DataSource = null;
                dgvIsler.DataSource = isler;

                // Bakiye durumuna göre satır renklendirme
                RenklendirmeUygula();

                if (dgvIsler.Rows.Count > 0)
                {
                    dgvIsler.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşler yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Özet bilgileri güncelle
        /// </summary>
        private void OzetBilgileriGuncelle()
        {
            try
            {
                if (dgvIsler.Rows.Count == 0)
                {
                    lblToplamIsSayisi.Text = "Toplam İş: 0";
                    lblToplamIsUcreti.Text = "Toplam İş Ücreti: ₺0,00";
                    lblToplamAlinan.Text = "Toplam Alınan: ₺0,00";
                    lblToplamBakiye.Text = "TOPLAM BAKİYE: ₺0,00";
                    lblToplamBakiye.ForeColor = Color.Navy;
                    return;
                }

                int toplamIsSayisi = dgvIsler.Rows.Count;
                decimal toplamIsUcreti = 0;
                decimal toplamAlinan = 0;
                decimal toplamBakiye = 0;

                foreach (DataGridViewRow row in dgvIsler.Rows)
                {
                    if (row.Cells["IsUcreti"].Value != null)
                        toplamIsUcreti += Convert.ToDecimal(row.Cells["IsUcreti"].Value);

                    if (row.Cells["AlinanTutar"].Value != null)
                        toplamAlinan += Convert.ToDecimal(row.Cells["AlinanTutar"].Value);

                    if (row.Cells["Bakiye"].Value != null)
                        toplamBakiye += Convert.ToDecimal(row.Cells["Bakiye"].Value);
                }

                lblToplamIsSayisi.Text = $"Toplam İş: {toplamIsSayisi}";
                lblToplamIsUcreti.Text = $"Toplam İş Ücreti: ₺{toplamIsUcreti:N2}";
                lblToplamAlinan.Text = $"Toplam Alınan: ₺{toplamAlinan:N2}";
                lblToplamBakiye.Text = $"TOPLAM BAKİYE: ₺{toplamBakiye:N2}";

                lblToplamBakiye.ForeColor = toplamBakiye >= 0 ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Özet bilgiler güncellenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Alanları temizle
        /// </summary>
        private void AlanlariTemizle()
        {
            txtIsAciklamasi.Clear();
            txtIsUcreti.Clear();
            txtAlinanTutar.Clear();
            dtpTarih.Value = DateTime.Now;
            cmbSirket.SelectedIndex = -1;
            lblBakiyeGoster.Text = "Bakiye: ₺0,00";
            lblBakiyeGoster.ForeColor = Color.Navy;
            _secilenIsId = 0;
            txtIsAciklamasi.Focus();
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

                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);
                var filtrelenmisListe = isler
                    .Where(i => i.Tarih.Date >= baslangicTarihi && i.Tarih.Date <= bitisTarihi);

                // Şirket filtresi
                if (cmbSirketFiltrele.SelectedIndex != -1 && cmbSirketFiltrele.SelectedItem is Sirket secilenSirket)
                {
                    filtrelenmisListe = filtrelenmisListe.Where(i => i.SirketId == secilenSirket.Id);
                }

                dgvIsler.DataSource = null;
                dgvIsler.DataSource = filtrelenmisListe.ToList();
                
                // Renklendirmeyi tekrar uygula
                RenklendirmeUygula();
                OzetBilgileriGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtreleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            cmbSirketFiltrele.SelectedIndex = -1;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            IsleriYukle();
        }

        private void RenklendirmeUygula()
        {
            foreach (DataGridViewRow row in dgvIsler.Rows)
            {
                decimal bakiye = Convert.ToDecimal(row.Cells["Bakiye"].Value);
                if (bakiye > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (bakiye == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtIsAciklamasi.Text))
                {
                    MessageBox.Show("İş açıklaması boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIsAciklamasi.Focus();
                    return;
                }

                // Sayısal değer kontrolü
                if (!decimal.TryParse(txtIsUcreti.Text.Replace('.', ','), out decimal isUcreti) || isUcreti <= 0)
                {
                    MessageBox.Show("İş ücreti geçerli bir sayı olmalı ve 0'dan büyük olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIsUcreti.Focus();
                    return;
                }

                decimal alinanTutar = 0;
                if (!string.IsNullOrWhiteSpace(txtAlinanTutar.Text))
                {
                    if (!decimal.TryParse(txtAlinanTutar.Text.Replace('.', ','), out alinanTutar) || alinanTutar < 0)
                    {
                        MessageBox.Show("Alınan tutar geçerli bir sayı olmalıdır!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAlinanTutar.Focus();
                        return;
                    }
                }

                // Şirket seçimi kontrolü
                if (cmbSirket.SelectedItem is not Sirket secilenSirket)
                {
                    MessageBox.Show("Lütfen bir şirket seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mevcut işleri oku
                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);

                // Yeni iş oluştur
                var yeniIs = new IsTakip
                {
                    Id = isler.Count > 0 ? isler.Max(i => i.Id) + 1 : 1,
                    Tarih = dtpTarih.Value,
                    SirketId = secilenSirket.Id,
                    SirketAdi = secilenSirket.SirketAdi,
                    IsAciklamasi = txtIsAciklamasi.Text.Trim(),
                    IsUcreti = isUcreti,
                    AlinanTutar = alinanTutar
                };

                // Bakiyeyi hesapla
                yeniIs.HesaplaBakiye();

                isler.Add(yeniIs);
                _jsonService.SaveList(ISTAKIP_FILE, isler);

                MessageBox.Show("İş başarıyla kaydedildi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                AlanlariTemizle();
                IsleriYukle();
                OzetBilgileriGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İş kaydetme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Güncelle butonu
        /// </summary>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenIsId == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek işi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtIsAciklamasi.Text))
                {
                    MessageBox.Show("İş açıklaması boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIsAciklamasi.Focus();
                    return;
                }

                // Sayısal değer kontrolü
                if (!decimal.TryParse(txtIsUcreti.Text.Replace('.', ','), out decimal isUcreti) || isUcreti <= 0)
                {
                    MessageBox.Show("İş ücreti geçerli bir sayı olmalı ve 0'dan büyük olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIsUcreti.Focus();
                    return;
                }

                decimal alinanTutar = 0;
                if (!string.IsNullOrWhiteSpace(txtAlinanTutar.Text))
                {
                    if (!decimal.TryParse(txtAlinanTutar.Text.Replace('.', ','), out alinanTutar) || alinanTutar < 0)
                    {
                        MessageBox.Show("Alınan tutar geçerli bir sayı olmalıdır!", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAlinanTutar.Focus();
                        return;
                    }
                }

                // Şirket seçimi kontrolü
                if (cmbSirket.SelectedItem is not Sirket secilenSirket)
                {
                    MessageBox.Show("Lütfen bir şirket seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);
                var guncellenecekIs = isler.FirstOrDefault(i => i.Id == _secilenIsId);

                if (guncellenecekIs != null)
                {
                    guncellenecekIs.Tarih = dtpTarih.Value;
                    guncellenecekIs.SirketId = secilenSirket.Id;
                    guncellenecekIs.SirketAdi = secilenSirket.SirketAdi;
                    guncellenecekIs.IsAciklamasi = txtIsAciklamasi.Text.Trim();
                    guncellenecekIs.IsUcreti = isUcreti;
                    guncellenecekIs.AlinanTutar = alinanTutar;
                    guncellenecekIs.HesaplaBakiye();

                    _jsonService.SaveList(ISTAKIP_FILE, isler);

                    MessageBox.Show("İş başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AlanlariTemizle();
                    IsleriYukle();
                    OzetBilgileriGuncelle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Temizle butonu
        /// </summary>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }
        /// <summary>
        /// Sil butonu
        /// </summary>
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIsler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek işi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bu işi silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvIsler.SelectedRows[0].Cells["Id"].Value);

                    var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);
                    var silinecekIs = isler.FirstOrDefault(i => i.Id == id);

                    if (silinecekIs != null)
                    {
                        isler.Remove(silinecekIs);
                        _jsonService.SaveList(ISTAKIP_FILE, isler);

                        MessageBox.Show("İş başarıyla silindi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AlanlariTemizle();
                        IsleriYukle();
                        OzetBilgileriGuncelle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvIsler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvIsler.Rows[e.RowIndex];

                    _secilenIsId = Convert.ToInt32(row.Cells["Id"].Value);
                    dtpTarih.Value = Convert.ToDateTime(row.Cells["Tarih"].Value);
                    txtIsAciklamasi.Text = row.Cells["IsAciklamasi"].Value?.ToString() ?? string.Empty;
                    txtIsUcreti.Text = Convert.ToDecimal(row.Cells["IsUcreti"].Value).ToString("F2");
                    txtAlinanTutar.Text = Convert.ToDecimal(row.Cells["AlinanTutar"].Value).ToString("F2");

                    // Şirketi seç
                    string? sirketAdi = row.Cells["SirketAdi"].Value?.ToString();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seçim hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Yenile butonu
        /// </summary>
        private void btnYenile_Click(object sender, EventArgs e)
        {
            IsleriYukle();
            OzetBilgileriGuncelle();
        }
        /// <summary>
        /// Özet Rapor butonu (Şimdilik boş, PDF eklerken yapacağız)
        /// </summary>
        private void btnOzetRapor_Click(object sender, EventArgs e)
        {
            try
            {
                var isler = dgvIsler.DataSource as List<IsTakip>;

                if (isler == null || isler.Count == 0)
                {
                    MessageBox.Show("Rapor oluşturmak için en az bir iş kaydı olmalıdır!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PdfService pdfService = new PdfService();
                string dosyaYolu = pdfService.IsTakipRaporuOlustur(isler);

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

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            _excelService.ExportToExcel(dgvIsler);
        }
    }
}
