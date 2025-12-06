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
        private int _secilenIsId = 0;

        public FrmIsTakip()
        {
            InitializeComponent();
            _jsonService = new JsonService();
            _excelService = new ExcelService();

            DataGridViewAyarlari();
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
                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);

                int toplamIsSayisi = isler.Count;
                decimal toplamIsUcreti = isler.Sum(i => i.IsUcreti);
                decimal toplamAlinan = isler.Sum(i => i.AlinanTutar);
                decimal toplamBakiye = isler.Sum(i => i.Bakiye);

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
            lblBakiyeGoster.Text = "Bakiye: ₺0,00";
            lblBakiyeGoster.ForeColor = Color.Navy;
            _secilenIsId = 0;
            txtIsAciklamasi.Focus();
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

                // Mevcut işleri oku
                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);

                // Yeni iş oluştur
                var yeniIs = new IsTakip
                {
                    Id = isler.Count > 0 ? isler.Max(i => i.Id) + 1 : 1,
                    Tarih = dtpTarih.Value,
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

                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);
                var guncellenecekIs = isler.FirstOrDefault(i => i.Id == _secilenIsId);

                if (guncellenecekIs != null)
                {
                    guncellenecekIs.Tarih = dtpTarih.Value;
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
                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);

                if (isler.Count == 0)
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
