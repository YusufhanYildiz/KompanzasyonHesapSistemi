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
using KompanzasyonHesapSistemi.Validators;
using FluentValidation.Results;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmIsTakip : BaseForm
    {
        private readonly IsTakipService _isTakipService;
        private readonly SirketService _sirketService;
        private readonly ExcelService _excelService;
        private int _secilenIsId = 0;

        public FrmIsTakip(IsTakipService isTakipService, SirketService sirketService, ExcelService excelService)
        {
            InitializeComponent();
            _isTakipService = isTakipService;
            _sirketService = sirketService;
            _excelService = excelService;

            // ExcelService'in bildirim delegate'ini ata
            _excelService.NotifyMessage = (message, duration) => ShowSnackBar(message, duration);

            // TextBox'lara KeyPress event'i ekle
            txtIsUcreti.KeyPress += SayisalAlan_KeyPress;
            txtAlinanTutar.KeyPress += SayisalAlan_KeyPress;

            // TextBox'lara TextChanged event'i ekle (bakiye hesaplama için)
            txtIsUcreti.TextChanged += Bakiye_TextChanged;
            txtAlinanTutar.TextChanged += Bakiye_TextChanged;

            // Buton olaylarını bağla
            btnKaydet.Click += BtnKaydet_Click;
            btnGuncelle.Click += BtnGuncelle_Click;
            btnTemizle.Click += BtnTemizle_Click;
            btnSil.Click += BtnSil_Click;
            btnYenile.Click += BtnYenile_Click;
            btnOzetRapor.Click += BtnOzetRapor_Click;
            btnKapat.Click += BtnKapat_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
            btnExcelAl.Click += BtnExcelAl_Click;
            btnFiltrele.Click += BtnFiltrele_Click;
            btnFiltreyiTemizle.Click += BtnFiltreyiTemizle_Click;

            // DataGridView olaylarını bağla
            dgvIsler.CellClick += DgvIsler_CellClick;

            // Verileri yükle
            this.Load += async (s, e) =>
            {
                DataGridViewAyarlari();
                await SirketleriYukle();
                await IsleriYukle();
                OzetBilgileriGuncelle();
            };
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
                lblBakiyeGoster.ForeColor = bakiye < 0 ? Color.Red : Color.Green;
            }
            catch { }
        }
        /// <summary>
        /// Şirketleri ComboBox'a yükle
        /// </summary>
        private async Task SirketleriYukle()
        {
            try
            {
                var sirketler = await _sirketService.GetAllAsync();
                var siraliSirketler = sirketler.OrderBy(s => s.SirketAdi).ToList();

                // Veri girişi için
                cmbSirket.DataSource = null;
                cmbSirket.DataSource = siraliSirketler;
                cmbSirket.DisplayMember = "SirketAdi";
                cmbSirket.ValueMember = "Id";
                cmbSirket.SelectedIndex = -1;

                // Filtreleme için
                var filtreSirketler = new List<Sirket>(siraliSirketler);
                cmbSirketFiltrele.DataSource = null;
                cmbSirketFiltrele.DataSource = filtreSirketler;
                cmbSirketFiltrele.DisplayMember = "SirketAdi";
                cmbSirketFiltrele.ValueMember = "Id";
                cmbSirketFiltrele.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                NotifyError($"Şirketler yüklenirken hata: {ex.Message}");
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

            foreach (DataGridViewColumn col in dgvIsler.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            dgvIsler.ColumnHeaderMouseClick += DgvIsler_ColumnHeaderMouseClick;
        }

        private bool _isAscending = true;
        private string _lastSortedColumn = "";

        private void DgvIsler_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string columnName = dgvIsler.Columns[e.ColumnIndex].Name;
                if (dgvIsler.DataSource is not List<IsTakip> isler || isler.Count == 0) return;

                if (_lastSortedColumn == columnName)
                {
                    _isAscending = !_isAscending;
                }
                else
                {
                    _isAscending = true;
                    _lastSortedColumn = columnName;
                }

                var siraliListe = new List<IsTakip>();

                switch (columnName)
                {
                    case "Id":
                        siraliListe = _isAscending
                            ? isler.OrderBy(i => i.Id).ToList()
                            : isler.OrderByDescending(i => i.Id).ToList();
                        break;

                    case "SirketAdi":
                        siraliListe = _isAscending
                            ? isler.OrderBy(i => i.SirketAdi).ToList()
                            : isler.OrderByDescending(i => i.SirketAdi).ToList();
                        break;

                    case "Tarih":
                        siraliListe = _isAscending
                           ? isler.OrderBy(i => i.Tarih).ToList()
                           : isler.OrderByDescending(i => i.Tarih).ToList();
                        break;
                    
                    case "IsAciklamasi":
                        siraliListe = _isAscending
                           ? isler.OrderBy(i => i.IsAciklamasi).ToList()
                           : isler.OrderByDescending(i => i.IsAciklamasi).ToList();
                        break;

                    case "IsUcreti":
                        siraliListe = _isAscending
                           ? isler.OrderBy(i => i.IsUcreti).ToList()
                           : isler.OrderByDescending(i => i.IsUcreti).ToList();
                        break;

                    case "AlinanTutar":
                        siraliListe = _isAscending
                           ? isler.OrderBy(i => i.AlinanTutar).ToList()
                           : isler.OrderByDescending(i => i.AlinanTutar).ToList();
                        break;

                    case "Bakiye":
                        siraliListe = _isAscending
                           ? isler.OrderBy(i => i.Bakiye).ToList()
                           : isler.OrderByDescending(i => i.Bakiye).ToList();
                        break;

                    default:
                        return;
                }

                // Clear sorting glyphs from other columns
                foreach (DataGridViewColumn col in dgvIsler.Columns)
                {
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;
                }

                dgvIsler.DataSource = null;
                dgvIsler.DataSource = siraliListe;
                
                dgvIsler.Columns[columnName].HeaderCell.SortGlyphDirection = 
                    _isAscending ? SortOrder.Ascending : SortOrder.Descending;

                RenklendirmeUygula();
            }
            catch (Exception ex)
            {
                NotifyError($"Sıralama hatası: {ex.Message}");
            }
        }
        /// <summary>
        /// İşleri yükle (Async)
        /// </summary>
        private async Task IsleriYukle()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var isler = await _isTakipService.GetAllAsync();
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
                NotifyError($"İşler yüklenirken hata: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
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

                lblToplamBakiye.ForeColor = toplamBakiye < 0 ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                NotifyError($"Özet bilgiler güncellenirken hata: {ex.Message}");
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

        private async void BtnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                var baslangicTarihi = dtpBaslangic.Value.Date;
                var bitisTarihi = dtpBitis.Value.Date;

                if (baslangicTarihi > bitisTarihi)
                {
                    NotifyWarning("Başlangıç tarihi, bitiş tarihinden sonra olamaz!");
                    return;
                }

                // Şirket filtresi
                int? sirketId = null;
                if (cmbSirketFiltrele.SelectedIndex != -1 && cmbSirketFiltrele.SelectedItem is Sirket secilenSirket)
                {
                    sirketId = secilenSirket.Id;
                }

                var filtrelenmisListe = await _isTakipService.GetFilteredAsync(baslangicTarihi, bitisTarihi, sirketId);

                dgvIsler.DataSource = null;
                dgvIsler.DataSource = filtrelenmisListe;

                // Renklendirmeyi tekrar uygula
                RenklendirmeUygula();
                OzetBilgileriGuncelle();
            }
            catch (Exception ex)
            {
                NotifyError($"Filtreleme hatası: {ex.Message}");
            }
        }
        private async void BtnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtpBitis.Value = DateTime.Now;
            cmbSirketFiltrele.SelectedIndex = -1;
            await IsleriYukle();
            OzetBilgileriGuncelle();
        }

        private void RenklendirmeUygula()
        {
            foreach (DataGridViewRow row in dgvIsler.Rows)
            {
                decimal bakiye = Convert.ToDecimal(row.Cells["Bakiye"].Value);
                if (bakiye < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
            }
        }

        private bool ValidateIsTakip(IsTakip isTakip)
        {
            var validator = new IsTakipValidator();
            ValidationResult result = validator.Validate(isTakip);

            if (!result.IsValid)
            {
                var firstError = result.Errors.FirstOrDefault()?.ErrorMessage ?? "Validasyon hatası";
                NotifyWarning(firstError);
                return false;
            }
            return true;
        }

        private async void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // UI'from verileri al (Güvenli Parse)
                decimal.TryParse(txtIsUcreti.Text.Replace('.', ','), out decimal isUcreti);
                decimal.TryParse(txtAlinanTutar.Text.Replace('.', ','), out decimal alinanTutar);

                int sirketId = 0;
                string sirketAdi = string.Empty;

                if (cmbSirket.SelectedItem is Sirket secilenSirket)
                {
                    sirketId = secilenSirket.Id;
                    sirketAdi = secilenSirket.SirketAdi;
                }

                // Yeni iş oluştur
                var yeniIs = new IsTakip
                {
                    Tarih = dtpTarih.Value,
                    SirketId = sirketId,
                    SirketAdi = sirketAdi,
                    IsAciklamasi = txtIsAciklamasi.Text.Trim(),
                    IsUcreti = isUcreti,
                    AlinanTutar = alinanTutar
                };
                
                // Bakiyeyi hesapla (Helper method)
                yeniIs.HesaplaBakiye();

                // Validasyon (The Gatekeeper)
                if (!ValidateIsTakip(yeniIs)) return;

                Cursor.Current = Cursors.WaitCursor;
                bool basarili = await _isTakipService.AddAsync(yeniIs);

                if (basarili)
                {
                    NotifySuccess("İş başarıyla kaydedildi!");

                    AlanlariTemizle();
                    await IsleriYukle();
                    OzetBilgileriGuncelle();
                }
                else
                {
                    NotifyError("İş kaydedilirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                NotifyError($"İş kaydetme hatası: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Güncelle butonu
        /// </summary>
        private async void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenIsId == 0)
                {
                    NotifyWarning("Lütfen güncellenecek işi seçiniz!");
                    return;
                }

                // UI'dan verileri al
                decimal.TryParse(txtIsUcreti.Text.Replace('.', ','), out decimal isUcreti);
                decimal.TryParse(txtAlinanTutar.Text.Replace('.', ','), out decimal alinanTutar);

                int sirketId = 0;
                string sirketAdi = string.Empty;

                if (cmbSirket.SelectedItem is Sirket secilenSirket)
                {
                    sirketId = secilenSirket.Id;
                    sirketAdi = secilenSirket.SirketAdi;
                }

                var guncellenecekIs = new IsTakip
                {
                    Id = _secilenIsId,
                    Tarih = dtpTarih.Value,
                    SirketId = sirketId,
                    SirketAdi = sirketAdi,
                    IsAciklamasi = txtIsAciklamasi.Text.Trim(),
                    IsUcreti = isUcreti,
                    AlinanTutar = alinanTutar
                };
                
                guncellenecekIs.HesaplaBakiye();

                // Validasyon (The Gatekeeper)
                if (!ValidateIsTakip(guncellenecekIs)) return;

                Cursor.Current = Cursors.WaitCursor;
                bool basarili = await _isTakipService.UpdateAsync(guncellenecekIs);

                if (basarili)
                {
                    NotifySuccess("İş başarıyla güncellendi!");

                    AlanlariTemizle();
                    await IsleriYukle();
                    OzetBilgileriGuncelle();
                }
                else
                {
                    NotifyError("İş güncellenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                NotifyError($"Güncelleme hatası: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Temizle butonu
        /// </summary>
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }
        /// <summary>
        /// Sil butonu
        /// </summary>
        private async void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIsler.SelectedRows.Count == 0)
                {
                    NotifyWarning("Lütfen silinecek işi seçiniz!");
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

                    Cursor.Current = Cursors.WaitCursor;
                    bool deleted = await _isTakipService.DeleteAsync(id);

                    if (deleted)
                    {
                        NotifySuccess("İş başarıyla silindi!");

                        AlanlariTemizle();
                        await IsleriYukle();
                        OzetBilgileriGuncelle();
                    }
                    else
                    {
                        NotifyError("İş silinemedi veya zaten silinmiş.");
                    }
                }
            }
            catch (Exception ex)
            {
                NotifyError($"Silme hatası: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void DgvIsler_CellClick(object sender, DataGridViewCellEventArgs e)
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
                NotifyError($"Seçim hatası: {ex.Message}");
            }
        }
        /// <summary>
        /// Yenile butonu
        /// </summary>
        private async void BtnYenile_Click(object sender, EventArgs e)
        {
            await IsleriYukle();
            OzetBilgileriGuncelle();
        }
        /// <summary>
        /// Özet Rapor butonu (Şimdilik boş, PDF eklerken yapacağız)
        /// </summary>
        private void BtnOzetRapor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIsler.DataSource is not List<IsTakip> isler || isler.Count == 0)
                {
                    NotifyWarning("Rapor oluşturmak için en az bir iş kaydı olmalıdır!");
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "PDF Dosyası|*.pdf",
                    FileName = $"IsTakip_Raporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf",
                    Title = "İş Takip Raporunu Kaydet"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var pdfService = new PdfService();
                        pdfService.IsTakipRaporuOlustur(sfd.FileName, isler);

                        DialogResult acilsinMi = MessageBox.Show(
                            "PDF rapor başarıyla oluşturuldu!\n\nRaporu açmak ister misiniz?",
                            "Başarılı",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information
                        );

                        if (acilsinMi == DialogResult.Yes)
                        {
                            pdfService.PdfAc(sfd.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                NotifyError($"PDF oluşturma hatası: {ex.Message}");
            }
        }
        /// <summary>
        /// Kapat butonu
        /// </summary>
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcelAktar_Click(object sender, EventArgs e)
        {
            _excelService.ExportToExcel(dgvIsler);
        }
        private async void BtnExcelAl_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = _excelService.ImportFromExcel();
                if (dt == null || dt.Rows.Count == 0) return;

                Cursor.Current = Cursors.WaitCursor;
                var sirketler = await _sirketService.GetAllAsync();
                int eklenenSayisi = 0;
                int hataSayisi = 0;

                bool sirketlerGuncellendi = false;
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        string sirketAdi = row[0]?.ToString()?.Trim() ?? "";
                        if (string.IsNullOrWhiteSpace(sirketAdi)) continue;

                        var sirket = sirketler.FirstOrDefault(s => s.SirketAdi.Equals(sirketAdi, StringComparison.OrdinalIgnoreCase));
                        if (sirket == null)
                        {
                            // Yeni şirket oluştur
                            sirket = new Sirket
                            {
                                SirketAdi = sirketAdi,
                                KayitTarihi = DateTime.Now
                            };
                            await _sirketService.AddAsync(sirket);
                            sirketler.Add(sirket); // Listeye de ekle ki sonraki satırlarda bulunsun
                            sirketlerGuncellendi = true;
                        }

                        var yeniIs = new IsTakip
                        {
                            SirketId = sirket.Id,
                            SirketAdi = sirket.SirketAdi,
                            Tarih = DateTime.TryParse(row[1]?.ToString(), out DateTime tarih) ? tarih : DateTime.Now,
                            IsAciklamasi = row[2]?.ToString() ?? "",
                            IsUcreti = decimal.TryParse(row[3]?.ToString(), out decimal iu) ? iu : 0,
                            AlinanTutar = decimal.TryParse(row[4]?.ToString(), out decimal at) ? at : 0
                        };

                        yeniIs.HesaplaBakiye();
                        await _isTakipService.AddAsync(yeniIs);
                        eklenenSayisi++;
                    }
                    catch
                    {
                        hataSayisi++;
                    }
                }

                if (eklenenSayisi > 0)
                {
                    if (sirketlerGuncellendi)
                    {
                        await SirketleriYukle(); // ComboBox'ları yenile
                    }
                    
                    NotifySuccess($"{eklenenSayisi} kayıt başarıyla eklendi. {(sirketlerGuncellendi ? "Yeni şirketler oluşturuldu. " : "")}{hataSayisi} kayıt atlandı.");
                    await IsleriYukle();
                    OzetBilgileriGuncelle();
                }
                else
                {
                    NotifyWarning("Eklenecek geçerli kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                NotifyError($"Excel'den veri alma hatası: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
