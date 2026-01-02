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
using Serilog;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmHesaplamalar : BaseForm
    {
        private readonly SirketService _sirketService;
        private readonly HesaplamaService _hesaplamaService;
        private readonly ExcelService _excelService;

        // Pagination Properties
        private int _currentPage = 1;
        private int _pageSize = 50;
        private int _totalRecords = 0;
        private List<Hesaplama> _allHesaplamalarCache = new List<Hesaplama>(); // Keep full list in memory for filtering/sorting
        private bool _showAll = false;

        // UI Controls for Pagination (Created dynamically)
        private Panel? pnlPagination;
        private Button? btnPrevPage;
        private Button? btnNextPage;
        private Label? lblPageInfo;
        private CheckBox? chkShowAll;

        public FrmHesaplamalar(SirketService sirketService, HesaplamaService hesaplamaService, ExcelService excelService)
        {
            InitializeComponent();
            _sirketService = sirketService;
            _hesaplamaService = hesaplamaService;
            _excelService = excelService;

            // Buton olaylarını bağla
            btnHesapla.Click += BtnHesapla_Click;
            btnTemizle.Click += BtnTemizle_Click;
            btnSil.Click += BtnSil_Click;
            btnYenile.Click += BtnYenile_Click;
            btnPdfRapor.Click += BtnPdfRapor_Click;
            btnKapat.Click += BtnKapat_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
            btnFiltrele.Click += BtnFiltrele_Click;
            btnFiltreyiTemizle.Click += BtnFiltreyiTemizle_Click;
            btnExcelAl.Click += BtnExcelAl_Click;

            InitializePaginationControls();

            // Verileri yükle
            this.Load += async (s, e) =>
            {
                DataGridViewAyarlari();
                dgvHesaplamalar.CellDoubleClick += DgvHesaplamalar_CellDoubleClick;
                dgvHesaplamalar.CellFormatting += DgvHesaplamalar_CellFormatting;
                await SirketleriYukle();
                await HesaplamalariYukle();
            };
        }

        private void InitializePaginationControls()
        {
            // Panel for pagination at the bottom
            pnlPagination = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                Padding = new Padding(5),
                BackColor = Color.WhiteSmoke
            };

            chkShowAll = new CheckBox
            {
                Text = "Tümünü Göster",
                AutoSize = true,
                Location = new Point(10, 10),
                Font = new Font("Segoe UI", 9F)
            };
            chkShowAll.CheckedChanged += ChkShowAll_CheckedChanged;

            btnPrevPage = new Button
            {
                Text = "< Önceki",
                Width = 80,
                Height = 30,
                Location = new Point(chkShowAll.Right + 20, 5),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnPrevPage.Click += (s, e) => ChangePage(-1);

            lblPageInfo = new Label
            {
                Text = "Sayfa 1 / 1",
                AutoSize = true,
                Location = new Point(btnPrevPage.Right + 10, 12),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            btnNextPage = new Button
            {
                Text = "Sonraki >",
                Width = 80,
                Height = 30,
                Location = new Point(lblPageInfo.Right + 10, 5), // Will be adjusted in Resize
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnNextPage.Click += (s, e) => ChangePage(1);

            pnlPagination.Controls.Add(chkShowAll);
            pnlPagination.Controls.Add(btnPrevPage);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(btnNextPage);

            // Add panel to form - assuming dgvHesaplamalar is Dock.Fill or similar, we might need to adjust parent container
            // If dgvHesaplamalar is inside a panel, add this panel to that parent.
            // Based on typical Designer code, we'll try to add it to the form's controls, but ensure it's at the bottom.
            // If there is a bottom panel already, we might need to place it above or inside it.
            // Safest bet: Add to the same parent as DGV and bring to front, ensuring Dock=Bottom
            
            if (dgvHesaplamalar.Parent != null)
            {
                dgvHesaplamalar.Parent.Controls.Add(pnlPagination);
                pnlPagination.BringToFront();
            }
            else
            {
                this.Controls.Add(pnlPagination);
            }
        }

        private void ChkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAll == null) return;
            _showAll = chkShowAll.Checked;
            _currentPage = 1;
            UpdateGridWithPagination();
        }

        private void ChangePage(int direction)
        {
            _currentPage += direction;
            UpdateGridWithPagination();
        }

        private void UpdatePaginationUI()
        {
            if (btnPrevPage == null || btnNextPage == null || lblPageInfo == null) return;

            if (_showAll)
            {
                btnPrevPage.Enabled = false;
                btnNextPage.Enabled = false;
                lblPageInfo.Text = $"Toplam {_totalRecords} kayıt";
                return;
            }

            int totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            if (totalPages == 0) totalPages = 1;

            if (_currentPage < 1) _currentPage = 1;
            if (_currentPage > totalPages) _currentPage = totalPages;

            btnPrevPage.Enabled = _currentPage > 1;
            btnNextPage.Enabled = _currentPage < totalPages;
            lblPageInfo.Text = $"Sayfa {_currentPage} / {totalPages} (Top: {_totalRecords})";
            
            // Adjust label position if text grows
            btnNextPage.Location = new Point(lblPageInfo.Right + 10, 5);
        }

        private void UpdateGridWithPagination()
        {
            if (_allHesaplamalarCache == null) return;

            _totalRecords = _allHesaplamalarCache.Count;
            
            IEnumerable<Hesaplama> pageData;

            if (_showAll)
            {
                pageData = _allHesaplamalarCache;
            }
            else
            {
                // Ensure page is valid before skipping
                int totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
                if (totalPages == 0) totalPages = 1;
                if (_currentPage > totalPages) _currentPage = totalPages;
                if (_currentPage < 1) _currentPage = 1;

                pageData = _allHesaplamalarCache
                    .Skip((_currentPage - 1) * _pageSize)
                    .Take(_pageSize);
            }

            dgvHesaplamalar.DataSource = null;
            dgvHesaplamalar.DataSource = pageData.ToList();

            if (dgvHesaplamalar.Rows.Count > 0)
            {
                dgvHesaplamalar.ClearSelection();
            }

            UpdatePaginationUI();
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

                cmbSirket.DataSource = null;
                cmbSirket.DataSource = siraliSirketler;
                cmbSirket.DisplayMember = "SirketAdi";
                cmbSirket.ValueMember = "Id";

                if (cmbSirket.Items.Count > 0)
                {
                    cmbSirket.SelectedIndex = -1;
                }

                // Filtreleme combobox'ını da doldur
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

            foreach (DataGridViewColumn col in dgvHesaplamalar.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            dgvHesaplamalar.ColumnHeaderMouseClick += DgvHesaplamalar_ColumnHeaderMouseClick;
        }

        private bool _isAscending = true;
        private string _lastSortedColumn = "";

        private void DgvHesaplamalar_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string columnName = dgvHesaplamalar.Columns[e.ColumnIndex].Name;
                if (_allHesaplamalarCache == null || _allHesaplamalarCache.Count == 0) return;

                if (_lastSortedColumn == columnName)
                {
                    _isAscending = !_isAscending;
                }
                else
                {
                    _isAscending = true;
                    _lastSortedColumn = columnName;
                }

                IEnumerable<Hesaplama> siraliListe;

                switch (columnName)
                {
                    case "Id":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.Id) : _allHesaplamalarCache.OrderByDescending(h => h.Id);
                        break;
                    case "Tarih":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.Tarih) : _allHesaplamalarCache.OrderByDescending(h => h.Tarih);
                        break;
                    case "SirketAdi":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.SirketAdi) : _allHesaplamalarCache.OrderByDescending(h => h.SirketAdi);
                        break;
                    case "OncekiAktif":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.OncekiAktif) : _allHesaplamalarCache.OrderByDescending(h => h.OncekiAktif);
                        break;
                    case "OncekiEnduktif":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.OncekiEnduktif) : _allHesaplamalarCache.OrderByDescending(h => h.OncekiEnduktif);
                        break;
                    case "OncekiKapasitif":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.OncekiKapasitif) : _allHesaplamalarCache.OrderByDescending(h => h.OncekiKapasitif);
                        break;
                    case "MevcutAktif":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.MevcutAktif) : _allHesaplamalarCache.OrderByDescending(h => h.MevcutAktif);
                        break;
                    case "MevcutEnduktif":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.MevcutEnduktif) : _allHesaplamalarCache.OrderByDescending(h => h.MevcutEnduktif);
                        break;
                    case "MevcutKapasitif":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.MevcutKapasitif) : _allHesaplamalarCache.OrderByDescending(h => h.MevcutKapasitif);
                        break;
                    case "AktifTuketim":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.AktifTuketim) : _allHesaplamalarCache.OrderByDescending(h => h.AktifTuketim);
                        break;
                    case "EnduktifTuketim":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.EnduktifTuketim) : _allHesaplamalarCache.OrderByDescending(h => h.EnduktifTuketim);
                        break;
                    case "KapasitifTuketim":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.KapasitifTuketim) : _allHesaplamalarCache.OrderByDescending(h => h.KapasitifTuketim);
                        break;
                    case "EnduktifOran":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.EnduktifOran) : _allHesaplamalarCache.OrderByDescending(h => h.EnduktifOran);
                        break;
                    case "KapasitifOran":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.KapasitifOran) : _allHesaplamalarCache.OrderByDescending(h => h.KapasitifOran);
                        break;
                    case "CezaDurumu":
                        siraliListe = _isAscending ? _allHesaplamalarCache.OrderBy(h => h.CezaDurumu) : _allHesaplamalarCache.OrderByDescending(h => h.CezaDurumu);
                        break;
                    default:
                        return;
                }

                // Update cache with sorted list
                _allHesaplamalarCache = siraliListe.ToList();
                _currentPage = 1; // Reset to first page after sort

                // Clear sorting glyphs from other columns
                foreach (DataGridViewColumn col in dgvHesaplamalar.Columns)
                {
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
                
                UpdateGridWithPagination();
                
                dgvHesaplamalar.Columns[columnName].HeaderCell.SortGlyphDirection = 
                    _isAscending ? SortOrder.Ascending : SortOrder.Descending;
            }
            catch (Exception ex)
            {
                NotifyError($"Sıralama hatası: {ex.Message}");
            }
        }
        
        // Bu metod artık internal olarak UpdateGridWithPagination tarafından kullanılıyor
        // Dışarıdan doğrudan çağırmak yerine cache güncellenip UpdateGridWithPagination çağrılmalı
        private void GosterimListesiniGuncelle(IEnumerable<Hesaplama> hesaplamalar)
        {
            _allHesaplamalarCache = hesaplamalar.ToList();
            _currentPage = 1;
            UpdateGridWithPagination();
        }

        private void DgvHesaplamalar_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHesaplamalar.Rows.Count) return;

            var row = dgvHesaplamalar.Rows[e.RowIndex];
            var cezaDurumu = row.Cells["CezaDurumu"].Value?.ToString();

            if (cezaDurumu == "CEZA VAR")
            {
                e.CellStyle.BackColor = Color.LightPink;
                e.CellStyle.ForeColor = Color.DarkRed;
            }
            else if (cezaDurumu == "CEZA YOK")
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.ForeColor = Color.DarkGreen;
            }
        }

        /// <summary>
        /// Hesaplamaları yükle (Async)
        /// </summary>
        private async Task HesaplamalariYukle()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var hesaplamalar = await _hesaplamaService.TumHesaplamalariGetirAsync();
                
                // Varsayılan sıralama: Tarih (Yeniden Eskiye)
                var siraliHesaplamalar = hesaplamalar.OrderByDescending(h => h.Tarih).ToList();
                
                GosterimListesiniGuncelle(siraliHesaplamalar);
            }
            catch (Exception ex)
            {
                NotifyError($"Hesaplamalar yüklenirken hata: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private bool ValidateHesaplama(Hesaplama hesaplama)
        {
            var validator = new HesaplamaValidator();
            ValidationResult result = validator.Validate(hesaplama);

            if (!result.IsValid)
            {
                var firstError = result.Errors.FirstOrDefault()?.ErrorMessage ?? "Validasyon hatası";
                NotifyWarning(firstError);
                return false;
            }
            return true;
        }

        private async void BtnHesapla_Click(object sender, EventArgs e)
        {
            await RunSafeTaskAsync(async () =>
            {
                // Değerleri Parse Et (Safe Parsing)
                double.TryParse(txtOncekiAktif.Text, out double oncekiAktif);
                double.TryParse(txtOncekiEnduktif.Text, out double oncekiEnduktif);
                double.TryParse(txtOncekiKpstfTuketim.Text, out double oncekiKapasitif);
                
                double.TryParse(txtAktif.Text, out double mevcutAktif);
                double.TryParse(txtEnduktif.Text, out double mevcutEnduktif);
                double.TryParse(txtKapasitif.Text, out double mevcutKapasitif);

                // Şirket Seçimi
                int sirketId = 0;
                string sirketAdi = string.Empty;
                if (cmbSirket.SelectedItem is Sirket secilenSirket)
                {
                    sirketId = secilenSirket.Id;
                    sirketAdi = secilenSirket.SirketAdi;
                }

                // Hesaplama Nesnesini Oluştur
                var hesaplama = new Hesaplama
                {
                    SirketId = sirketId,
                    SirketAdi = sirketAdi,
                    Tarih = dtpTarih.Value,
                    OncekiAktif = oncekiAktif,
                    OncekiEnduktif = oncekiEnduktif,
                    OncekiKapasitif = oncekiKapasitif,
                    MevcutAktif = mevcutAktif,
                    MevcutEnduktif = mevcutEnduktif,
                    MevcutKapasitif = mevcutKapasitif
                };
                
                // Tüketim Hesapla
                hesaplama.HesaplaTuketim();

                Log.Information("Tüketim Hesaplandı - Aktif: {Aktif}, Enduktif: {Enduktif}, Kapasitif: {Kapasitif}",
                    hesaplama.AktifTuketim, hesaplama.EnduktifTuketim, hesaplama.KapasitifTuketim);

                // Validasyon (The Gatekeeper)
                if (!ValidateHesaplama(hesaplama)) return;

                // İş Mantığı (Oran Hesapla)
                hesaplama.HesaplaOranlari();

                Log.Information("Hesaplama Sonuçları - EnduktifOran: {EnduktifOran}, KapasitifOran: {KapasitifOran}, CezaDurumu: {CezaDurumu}",
                    hesaplama.EnduktifOran, hesaplama.KapasitifOran, hesaplama.CezaDurumu);

                // UI Güncelleme (Sonuç Gösterimi)
                lblEnduktifOran.Text = $"Endüktif Oran: %{hesaplama.EnduktifOran:F2}";
                lblEnduktifOran.ForeColor = hesaplama.EnduktifOran > 20 ? Color.Red : Color.Green;
                lblKapasitifOran.Text = $"Kapasitif Oran: %{hesaplama.KapasitifOran:F2}";
                lblKapasitifOran.ForeColor = hesaplama.KapasitifOran > 15 ? Color.Red : Color.Green;

                if (hesaplama.CezaDurumu == "CEZA VAR")
                {
                    Log.Information("Ceza VAR - Kırmızı renk uygulanıyor");
                    lblCezaDurumuSonuc.Text = "CEZA VAR";
                    lblCezaDurumuSonuc.ForeColor = Color.DarkRed;
                    lblCezaDurumuSonuc.BackColor = Color.LightPink;
                }
                else
                {
                    Log.Information("Ceza YOK - Yeşil renk uygulanıyor");
                    lblCezaDurumuSonuc.Text = "CEZA YOK";
                    lblCezaDurumuSonuc.ForeColor = Color.DarkGreen;
                    lblCezaDurumuSonuc.BackColor = Color.LightGreen;
                }

                lblCezaDurumuSonuc.Refresh();

                await _hesaplamaService.HesaplamaEkleAsync(hesaplama);
                Log.Information("Hesaplama kaydedildi - Son kaydın ceza durumu: {CezaDurumu}", hesaplama.CezaDurumu);

                NotifySuccess("Hesaplama başarıyla kaydedildi!");

                await HesaplamalariYukle();
                AlanlariTemizle();
            });
        }
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

            //lblEnduktifOran.Text = "Endüktif Oran: %0,00";
            //lblEnduktifOran.ForeColor = Color.Green;
            //lblKapasitifOran.Text = "Kapasitif Oran: %0,00";
            //lblKapasitifOran.ForeColor = Color.Green;
            //lblCezaDurumuSonuc.Text = "CEZA YOK";
            //lblCezaDurumuSonuc.ForeColor = Color.DarkGreen;
            //lblCezaDurumuSonuc.BackColor = Color.White;

            cmbSirket.Focus();
        }
        /// <summary>
        /// Temizle butonu
        /// </summary>
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private async void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHesaplamalar.SelectedRows.Count == 0)
                {
                    NotifyWarning("Lütfen silinecek kaydı seçiniz!");
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
                    await _hesaplamaService.HesaplamaSilAsync(id);

                    NotifySuccess("Kayıt başarıyla silindi!");

                    await HesaplamalariYukle();
                }
            }
            catch (Exception ex)
            {
                NotifyError($"Silme hatası: {ex.Message}");
            }
        }
        /// <summary>
        /// Yenile butonu
        /// </summary>
        private async void BtnYenile_Click(object sender, EventArgs e)
        {
            await HesaplamalariYukle();
        }
        /// <summary>
        /// PDF Rapor butonu (Şimdilik boş, sonra ekleyeceğiz)
        /// </summary>
        private async void BtnPdfRapor_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var hesaplamalar = await _hesaplamaService.TumHesaplamalariGetirAsync();
                Cursor.Current = Cursors.Default;

                if (hesaplamalar.Count == 0)
                {
                    NotifyWarning("Rapor oluşturmak için en az bir hesaplama kaydı olmalıdır!");
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

                IEnumerable<Hesaplama> raporHesaplamalari;
                string? sirketAdi = null;

                if (result == DialogResult.No)
                {
                    // Sadece seçili şirket
                    if (cmbSirket.SelectedIndex == -1 || cmbSirket.SelectedItem is not Sirket secilenSirket)
                    {
                        NotifyWarning("Lütfen bir şirket seçiniz!");
                        return;
                    }

                    raporHesaplamalari = hesaplamalar.Where(h => h.SirketId == secilenSirket.Id);
                    sirketAdi = secilenSirket.SirketAdi;

                    if (!raporHesaplamalari.Any())
                    {
                        NotifyWarning("Seçili şirket için hesaplama kaydı bulunamadı!");
                        return;
                    }
                }
                else
                {
                    // Tüm kayıtlar
                    raporHesaplamalari = hesaplamalar;
                }

                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "PDF Dosyası|*.pdf",
                    FileName = $"Kompanzasyon_Raporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf",
                    Title = "PDF Raporunu Kaydet"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var pdfService = new PdfService();
                        pdfService.HesaplamaRaporuOlustur(sfd.FileName, raporHesaplamalari, sirketAdi ?? string.Empty);

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

                var tumHesaplamalar = await _hesaplamaService.TumHesaplamalariGetirAsync();
                var filtrelenmisListe = tumHesaplamalar
                    .Where(h => h.Tarih.Date >= baslangicTarihi && h.Tarih.Date <= bitisTarihi);

                // Şirket filtresi
                if (cmbSirketFiltrele.SelectedIndex != -1 && cmbSirketFiltrele.SelectedItem is Sirket secilenSirket)
                {
                    filtrelenmisListe = filtrelenmisListe.Where(h => h.SirketId == secilenSirket.Id);
                }

                GosterimListesiniGuncelle(filtrelenmisListe);
            }
            catch (Exception ex)
            {
                NotifyError($"Filtreleme sırasında bir hata oluştu: {ex.Message}");
            }
        }

        private async void BtnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            cmbSirketFiltrele.SelectedIndex = -1;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            await HesaplamalariYukle();
        }

        private void BtnExcelAktar_Click(object sender, EventArgs e)
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
                    if (cmbSirket.Items[i] is Sirket sirket && sirket.SirketAdi == sirketAdi)
                        {
                            cmbSirket.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // Kullanıcıya bilgi ver
                NotifyInfo("Seçilen kaydın mevcut değerleri önceki alanlara aktarıldı. Şimdi mevcut sayaç değerlerini girebilirsiniz.");

                // Mevcut aktif alanına odaklan
                txtAktif.Focus();
            }
            catch (Exception ex)
            {
                NotifyError($"Değerler aktarılırken hata: {ex.Message}");
            }
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
                            await _sirketService.AddAsync(sirket); // Ensure async
                            
                            // Yeni eklenen şirketi listeye de ekleyelim ki sonraki satırlarda bulabilsin
                            sirketler = await _sirketService.GetAllAsync(); // Yeniden çekmek en garantisi
                            sirket = sirketler.FirstOrDefault(s => s.SirketAdi.Equals(sirketAdi, StringComparison.OrdinalIgnoreCase));
                            
                            sirketlerGuncellendi = true;
                        }
                        
                        if (sirket == null) { hataSayisi++; continue; }

                        var hesaplama = new Hesaplama
                        {
                            SirketId = sirket.Id,
                            SirketAdi = sirket.SirketAdi,
                            Tarih = DateTime.TryParse(row[1]?.ToString(), out DateTime tarih) ? tarih : DateTime.Now,
                            OncekiAktif = double.TryParse(row[2]?.ToString(), out double oa) ? oa : 0,
                            OncekiEnduktif = double.TryParse(row[3]?.ToString(), out double oe) ? oe : 0,
                            OncekiKapasitif = double.TryParse(row[4]?.ToString(), out double ok) ? ok : 0,
                            MevcutAktif = double.TryParse(row[5]?.ToString(), out double ma) ? ma : 0,
                            MevcutEnduktif = double.TryParse(row[6]?.ToString(), out double me) ? me : 0,
                            MevcutKapasitif = double.TryParse(row[7]?.ToString(), out double mk) ? mk : 0
                        };

                        hesaplama.HesaplaTuketim();

                        // Validasyon
                        var validator = new HesaplamaValidator();
                        if (validator.Validate(hesaplama).IsValid)
                        {
                            await _hesaplamaService.HesaplamaEkleAsync(hesaplama);
                            eklenenSayisi++;
                        }
                        else
                        {
                            hataSayisi++;
                        }
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
                    await HesaplamalariYukle();
                }
            }
            catch (Exception ex)
            {
                NotifyError($"Excel'den veri alma hatası: {ex.Message}");
            }
        }
    }
}
