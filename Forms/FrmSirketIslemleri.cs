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
    public partial class FrmSirketIslemleri : BaseForm
    {
        private readonly SirketService _sirketService;
        private int _secilenSirketId = 0;

        public FrmSirketIslemleri(SirketService sirketService)
        {
            InitializeComponent();
            _sirketService = sirketService;

            // Event handlers
            btnYeniSirket.Click += btnYeniSirket_Click;
            btnGuncelle.Click += btnGuncelle_Click;
            btnSil.Click += btnSil_Click;
            btnTemizle.Click += btnTemizle_Click;
            dgvSirketler.CellClick += dgvSirketler_CellClick;

            this.Load += async (s, e) =>
            {
                DataGridViewAyarlari();
                await SirketleriYukleAsync();
            };
        }
        private void DataGridViewAyarlari()
        {
            dgvSirketler.AutoGenerateColumns = false;
            dgvSirketler.Columns.Clear();

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SirketAdi",
                HeaderText = "Şirket Adı",
                DataPropertyName = "SirketAdi",
                Width = 150
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VergiNo",
                HeaderText = "Vergi No",
                DataPropertyName = "VergiNo",
                Width = 100
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telefon",
                HeaderText = "Telefon",
                DataPropertyName = "Telefon",
                Width = 100
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "KayitTarihi",
                HeaderText = "Kayıt Tarihi",
                DataPropertyName = "KayitTarihi",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd.MM.yyyy HH:mm"
                }
            });

            foreach (DataGridViewColumn col in dgvSirketler.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            dgvSirketler.ColumnHeaderMouseClick += DgvSirketler_ColumnHeaderMouseClick;
        }

        private bool _isAscending = true;
        private string _lastSortedColumn = "";

        private void DgvSirketler_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string columnName = dgvSirketler.Columns[e.ColumnIndex].Name;
                var sirketler = dgvSirketler.DataSource as List<Sirket>;

                if (sirketler == null || sirketler.Count == 0) return;

                // Aynı kolona tıklandıysa yönü ters çevir, farklı kolonsa artan sırala
                if (_lastSortedColumn == columnName)
                {
                    _isAscending = !_isAscending;
                }
                else
                {
                    _isAscending = true;
                    _lastSortedColumn = columnName;
                }

                List<Sirket> siraliListe = new List<Sirket>();

                switch (columnName)
                {
                    case "Id":
                        siraliListe = _isAscending
                            ? sirketler.OrderBy(s => s.Id).ToList()
                            : sirketler.OrderByDescending(s => s.Id).ToList();
                        break;

                    case "SirketAdi":
                        siraliListe = _isAscending
                            ? sirketler.OrderBy(s => s.SirketAdi).ToList()
                            : sirketler.OrderByDescending(s => s.SirketAdi).ToList();
                        break;
                    
                    case "VergiNo":
                        siraliListe = _isAscending
                            ? sirketler.OrderBy(s => s.VergiNo).ToList()
                            : sirketler.OrderByDescending(s => s.VergiNo).ToList();
                        break;

                    case "Telefon":
                        siraliListe = _isAscending
                            ? sirketler.OrderBy(s => s.Telefon).ToList()
                            : sirketler.OrderByDescending(s => s.Telefon).ToList();
                        break;

                    case "KayitTarihi":
                        siraliListe = _isAscending
                            ? sirketler.OrderBy(s => s.KayitTarihi).ToList()
                            : sirketler.OrderByDescending(s => s.KayitTarihi).ToList();
                        break;

                    default:
                        return; // Diğer kolonlar için sıralama yapma
                }

                // Clear sorting glyphs from other columns
                foreach (DataGridViewColumn col in dgvSirketler.Columns)
                {
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;
                }

                dgvSirketler.DataSource = null;
                dgvSirketler.DataSource = siraliListe;
                
                dgvSirketler.Columns[columnName].HeaderCell.SortGlyphDirection = 
                    _isAscending ? SortOrder.Ascending : SortOrder.Descending;
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Sirket Siralama");
            }
        }
        /// <summary>
        /// Şirketleri yükle (Async)
        /// </summary>
        private async Task SirketleriYukleAsync()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var sirketler = await _sirketService.GetAllAsync();
                dgvSirketler.DataSource = null;
                dgvSirketler.DataSource = sirketler;

                if (dgvSirketler.Rows.Count > 0)
                {
                    dgvSirketler.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Sirket Yukleme");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Alanları temizle
        /// </summary>
        private void AlanlariTemizle()
        {
            txtSirketAdi.Clear();
            txtVergiNo.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            _secilenSirketId = 0;
            txtSirketAdi.Focus();
        }

        private bool ValidateSirket(Sirket sirket)
        {
            var validator = new SirketValidator();
            ValidationResult result = validator.Validate(sirket);

            if (!result.IsValid)
            {
                var firstError = result.Errors.FirstOrDefault()?.ErrorMessage ?? "Validasyon hatası";
                NotifyWarning(firstError);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Yeni Şirket Ekle butonu
        /// </summary>
        private async void btnYeniSirket_Click(object sender, EventArgs e)
        {
            await RunSafeTaskAsync(async () =>
            {
                var yeniSirket = new Sirket
                {
                    SirketAdi = txtSirketAdi.Text.Trim(),
                    VergiNo = txtVergiNo.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Adres = txtAdres.Text.Trim(),
                    KayitTarihi = DateTime.Now
                };

                if (!ValidateSirket(yeniSirket)) return;

                // Vergi no kontrolü
                var sirketler = await _sirketService.GetAllAsync();
                var mevcutSirket = sirketler.FirstOrDefault(s =>
                    s.VergiNo.ToLower() == yeniSirket.VergiNo.ToLower());

                if (mevcutSirket != null)
                {
                    NotifyWarning("Bu vergi numarası zaten kayıtlı!");
                    return;
                }

                await _sirketService.AddAsync(yeniSirket);
                NotifySuccess("Şirket başarıyla eklendi!");

                AlanlariTemizle();
                await SirketleriYukleAsync();
            });
        }
        /// <summary>
        /// Güncelle butonu
        /// </summary>
        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenSirketId == 0)
            {
                NotifyWarning("Lütfen güncellenecek şirketi seçiniz!");
                return;
            }

            await RunSafeTaskAsync(async () =>
            {
                var guncellenecekSirket = await _sirketService.GetByIdAsync(_secilenSirketId);

                if (guncellenecekSirket != null)
                {
                    var tempSirket = new Sirket 
                    { 
                        SirketAdi = txtSirketAdi.Text.Trim(),
                        VergiNo = txtVergiNo.Text.Trim(),
                        Telefon = txtTelefon.Text.Trim(),
                        Adres = txtAdres.Text.Trim()
                    };

                    if (!ValidateSirket(tempSirket)) return;

                    guncellenecekSirket.SirketAdi = tempSirket.SirketAdi;
                    guncellenecekSirket.VergiNo = tempSirket.VergiNo;
                    guncellenecekSirket.Telefon = tempSirket.Telefon;
                    guncellenecekSirket.Adres = tempSirket.Adres;

                    await _sirketService.UpdateAsync(guncellenecekSirket);
                    NotifySuccess("Şirket başarıyla güncellendi!");

                    AlanlariTemizle();
                    await SirketleriYukleAsync();
                }
            });
        }
        /// <summary>
        /// Sil butonu
        /// </summary>
        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenSirketId == 0)
            {
                NotifyWarning("Lütfen silinecek şirketi seçiniz!");
                return;
            }

            var result = MessageBox.Show("Bu şirketi ve şirkete ait TÜM HESAPLAMALARI silmek istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await RunSafeTaskAsync(async () =>
                {
                    await _sirketService.DeleteAsync(_secilenSirketId);
                    NotifySuccess("Şirket ve ilişkili veriler silindi!");

                    AlanlariTemizle();
                    await SirketleriYukleAsync();
                });
            }
        }
        /// <summary>
        /// Temizle butonu
        /// </summary>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void dgvSirketler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dgvSirketler.Rows[e.RowIndex];
                    var sirket = selectedRow.DataBoundItem as Sirket;

                    if (sirket != null)
                    {
                        _secilenSirketId = sirket.Id;
                        txtSirketAdi.Text = sirket.SirketAdi;
                        txtVergiNo.Text = sirket.VergiNo;
                        txtTelefon.Text = sirket.Telefon;
                        txtAdres.Text = sirket.Adres;
                    }
                }
            }
            catch
            {
                // Sessizce geç veya logla
            }
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
