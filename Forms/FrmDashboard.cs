using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;
using ScottPlot;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmDashboard : BaseForm
    {
        private readonly SirketService? _sirketService;
        private readonly HesaplamaService? _hesaplamaService;
        private readonly IsTakipService? _isTakipService;
        private readonly ExcelService? _excelService;

        private const double CezaWarningThreshold = 10.0;
        private const double CezaDangerThreshold = 25.0;

        // Data Storage
        private List<Hesaplama> _hesaplamaList = new List<Hesaplama>();
        private bool _isSortAscending = false;
        private string _lastSortedColumn = "Tarih";

        // Dynamic Chart Controls
        private ScottPlot.WinForms.FormsPlot formsPlotPasta = new ScottPlot.WinForms.FormsPlot();
        private ScottPlot.WinForms.FormsPlot formsPlotCizgi = new ScottPlot.WinForms.FormsPlot();

        public FrmDashboard() : this(null, null, null, null)
        {
        }

        public FrmDashboard(SirketService? sirketService, HesaplamaService? hesaplamaService, IsTakipService? isTakipService, ExcelService? excelService)
        {
            InitializeComponent();
            _sirketService = sirketService;
            _hesaplamaService = hesaplamaService;
            _isTakipService = isTakipService;
            _excelService = excelService;

            if (_excelService != null)
            {
                _excelService.NotifyMessage = (message, duration) => ShowSnackBar(message, duration);
            }

            SetupCharts();
            SetupGrid();
        }

        private void SetupCharts()
        {
            formsPlotPasta.Dock = DockStyle.Fill;
            formsPlotCizgi.Dock = DockStyle.Fill;
            
            panelChartLeft.Controls.Add(formsPlotPasta);
            panelChartRight.Controls.Add(formsPlotCizgi);
            
            lblChartLeftTitle.BringToFront();
            lblChartRightTitle.BringToFront();
            
            // Fixed Light Colors
            formsPlotPasta.Plot.FigureBackground.Color = ScottPlot.Colors.White;
            formsPlotPasta.Plot.DataBackground.Color = ScottPlot.Colors.White;
            formsPlotCizgi.Plot.FigureBackground.Color = ScottPlot.Colors.White;
            formsPlotCizgi.Plot.DataBackground.Color = ScottPlot.Colors.White;
        }

        private void SetupGrid()
        {
            dgvSonIslemler.AutoGenerateColumns = false;
            dgvSonIslemler.Columns.Clear();

            // Columns
            dgvSonIslemler.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SirketAdi", HeaderText = "ŞİRKET", Name = "SirketAdi", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvSonIslemler.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tarih", HeaderText = "TARİH", Name = "Tarih", Width = 150 });
            dgvSonIslemler.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EnduktifOran", HeaderText = "ENDÜKTİF %", Name = "EnduktifOran", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
            dgvSonIslemler.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "KapasitifOran", HeaderText = "KAPASİTİF %", Name = "KapasitifOran", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
            dgvSonIslemler.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CezaDurumu", HeaderText = "DURUM", Name = "CezaDurumu", Width = 120 });

            foreach (DataGridViewColumn col in dgvSonIslemler.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            // Styling
            dgvSonIslemler.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Regular, GraphicsUnit.Pixel);
            dgvSonIslemler.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, GraphicsUnit.Pixel);
            dgvSonIslemler.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(241, 245, 249); // Slate 100
            dgvSonIslemler.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139); // Slate 500
            dgvSonIslemler.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);
            dgvSonIslemler.ColumnHeadersHeight = 40;
            dgvSonIslemler.EnableHeadersVisualStyles = false;

            dgvSonIslemler.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            dgvSonIslemler.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSonIslemler.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85); // Slate 700
            dgvSonIslemler.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(226, 232, 240); // Slate 200
            dgvSonIslemler.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42); // Slate 900
            
            dgvSonIslemler.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252); // Slate 50
            dgvSonIslemler.RowTemplate.Height = 45;
            dgvSonIslemler.GridColor = System.Drawing.Color.FromArgb(226, 232, 240); // Slate 200
            dgvSonIslemler.BorderStyle = BorderStyle.None;
            dgvSonIslemler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSonIslemler.RowHeadersVisible = false;

            // Events
            dgvSonIslemler.CellFormatting += DgvSonIslemler_CellFormatting;
            dgvSonIslemler.ColumnHeaderMouseClick += DgvSonIslemler_ColumnHeaderMouseClick;
        }

        private void DgvSonIslemler_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string propName = dgvSonIslemler.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(propName)) return;

            if (_lastSortedColumn == propName)
                _isSortAscending = !_isSortAscending;
            else
            {
                _lastSortedColumn = propName;
                _isSortAscending = true;
            }

            SortGrid(propName, _isSortAscending);
        }

        private void SortGrid(string propertyName, bool ascending)
        {
            if (_hesaplamaList == null || !_hesaplamaList.Any()) return;

            IEnumerable<Hesaplama> sorted;
            switch (propertyName)
            {
                case "SirketAdi":
                    sorted = ascending ? _hesaplamaList.OrderBy(h => h.SirketAdi) : _hesaplamaList.OrderByDescending(h => h.SirketAdi);
                    break;
                case "Tarih":
                    sorted = ascending ? _hesaplamaList.OrderBy(h => h.Tarih) : _hesaplamaList.OrderByDescending(h => h.Tarih);
                    break;
                case "EnduktifOran":
                    sorted = ascending ? _hesaplamaList.OrderBy(h => h.EnduktifOran) : _hesaplamaList.OrderByDescending(h => h.EnduktifOran);
                    break;
                case "KapasitifOran":
                    sorted = ascending ? _hesaplamaList.OrderBy(h => h.KapasitifOran) : _hesaplamaList.OrderByDescending(h => h.KapasitifOran);
                    break;
                case "CezaDurumu":
                    sorted = ascending ? _hesaplamaList.OrderBy(h => h.CezaDurumu) : _hesaplamaList.OrderByDescending(h => h.CezaDurumu);
                    break;
                default:
                    return;
            }

            _hesaplamaList = sorted.ToList();
            
            // Clear sorting glyphs from other columns
            foreach (DataGridViewColumn col in dgvSonIslemler.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            dgvSonIslemler.DataSource = null;
            dgvSonIslemler.DataSource = _hesaplamaList;
            
            dgvSonIslemler.Columns[propertyName].HeaderCell.SortGlyphDirection = 
                ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void DgvSonIslemler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSonIslemler.Columns[e.ColumnIndex].DataPropertyName == "CezaDurumu" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "CEZA VAR")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38); // Red 600
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(185, 28, 28); // Red 700
                }
                else
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74); // Green 600
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(21, 128, 61); // Green 700
                }
            }
        }

        private async void FrmDashboard_Load(object sender, EventArgs e)
        {
            if (this.DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            await VerileriYukle();
        }

        private async Task VerileriYukle()
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            await RunSafeTaskAsync(async () =>
            {
                await Task.WhenAll(
                    KartlariGuncelle(),
                    GrafikleriOlustur(),
                    TabloyuGuncelle()
                );
            });
        }

        private async Task TabloyuGuncelle()
        {
             try
            {
                if (_hesaplamaService == null) return;
                var hesaplamalar = await _hesaplamaService.TumHesaplamalariGetirAsync();

                if (this.IsDisposed) return;

                await Task.Run(() =>
                {
                    _hesaplamaList = hesaplamalar
                        .OrderByDescending(h => h.Tarih)
                        .Take(20)
                        .ToList();

                    if (this.IsDisposed || !this.IsHandleCreated) return;

                    this.Invoke(new Action(() =>
                    {
                        if (this.IsDisposed) return;
                        dgvSonIslemler.DataSource = _hesaplamaList;
                        
                        // Set initial sort glyph
                        if (dgvSonIslemler.Columns.Contains("Tarih"))
                        {
                            dgvSonIslemler.Columns["Tarih"].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                        }
                    }));
                });
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Dashboard Tablo Guncelle");
            }
        }

        private async Task KartlariGuncelle()
        {
            try
            {
                if (_sirketService == null || _hesaplamaService == null) return;
                var sirketler = await _sirketService.GetAllAsync();
                var hesaplamalar = await _hesaplamaService.TumHesaplamalariGetirAsync();

                if (this.IsDisposed) return;

                await Task.Run(() =>
                {
                    // Usta için daha anlamlı: Sadece bu takvim ayı değil, "Son 30 Gün" performansına bakıyoruz
                    var son30GunBaslangic = DateTime.Now.AddDays(-30);
                    var sonDonemHesaplamalar = hesaplamalar.Where(h => h.Tarih >= son30GunBaslangic).ToList();

                    if (sonDonemHesaplamalar.Count == 0 && hesaplamalar.Count > 0)
                    {
                        sonDonemHesaplamalar = hesaplamalar;
                    }

                    double cezaOrani = 0;
                    string cezaOraniStr = "%0";
                    
                    if (sonDonemHesaplamalar.Count > 0)
                    {
                        var cezaliSayisi = sonDonemHesaplamalar.Count(h => h.CezaDurumu == "CEZA VAR");
                        cezaOrani = (double)cezaliSayisi / sonDonemHesaplamalar.Count * 100;
                        cezaOraniStr = $"%{cezaOrani:F1}";
                    }

                    if (this.IsDisposed || !this.IsHandleCreated) return;

                    this.Invoke(new Action(() =>
                    {
                        if (this.IsDisposed) return;
                        lblSirketValue.Text = sirketler.Count.ToString();
                        lblHesaplamaValue.Text = hesaplamalar.Count.ToString();
                        lblCezaValue.Text = cezaOraniStr;
                        ApplyCezaCardStyle(cezaOrani);
                    }));
                });
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Dashboard Kart Guncelle");
            }
        }

        private void ApplyCezaCardStyle(double cezaOrani)
        {
            if (this.IsDisposed) return;
            System.Drawing.Color accentColor;

            if (cezaOrani < CezaWarningThreshold)
                accentColor = System.Drawing.Color.FromArgb(22, 163, 74); // Green 600
            else if (cezaOrani < CezaDangerThreshold)
                accentColor = System.Drawing.Color.FromArgb(234, 88, 12); // Orange 600
            else
                accentColor = System.Drawing.Color.FromArgb(220, 38, 38); // Red 600

            lblCezaValue.ForeColor = accentColor;
        }

        private async Task GrafikleriOlustur()
        {
            try
            {
                if (_hesaplamaService == null) return;
                var hesaplamalar = await _hesaplamaService.TumHesaplamalariGetirAsync();

                if (this.IsDisposed) return;

                await Task.Run(() =>
                {
                    if (this.IsDisposed || !this.IsHandleCreated) return;
                    this.Invoke(new Action(() =>
                    {
                        if (this.IsDisposed) return;
                        RenderPieChart(hesaplamalar);
                        RenderLineChart(hesaplamalar);
                    }));
                });
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Dashboard Grafik Olustur");
            }
        }

        private void RenderPieChart(List<Hesaplama> hesaplamalar)
        {
            formsPlotPasta.Plot.Clear();

            formsPlotPasta.Plot.Axes.Left.IsVisible = false;
            formsPlotPasta.Plot.Axes.Right.IsVisible = false;
            formsPlotPasta.Plot.Axes.Top.IsVisible = false;
            formsPlotPasta.Plot.Axes.Bottom.IsVisible = false;
            formsPlotPasta.Plot.Grid.IsVisible = false;

            if (hesaplamalar.Count == 0) 
            {
                formsPlotPasta.Refresh();
                return;
            }

            var cezaliSayisi = hesaplamalar.Count(h => h.CezaDurumu == "CEZA VAR");
            var cezasizSayisi = hesaplamalar.Count - cezaliSayisi;

            var slice1 = new ScottPlot.PieSlice { Value = cezaliSayisi, Label = $"Cezalı\n({cezaliSayisi})" };
            slice1.Fill.Color = ScottPlot.Color.FromHex("#EF4444"); 

            var slice2 = new ScottPlot.PieSlice { Value = cezasizSayisi, Label = $"Cezasız\n({cezasizSayisi})" };
            slice2.Fill.Color = ScottPlot.Color.FromHex("#10B981"); 

            var slices = new List<ScottPlot.PieSlice> { slice1, slice2 };

            var pie = formsPlotPasta.Plot.Add.Pie(slices);
            pie.DonutFraction = 0.6;
            pie.SliceLabelDistance = 1.15;
            
            formsPlotPasta.Refresh();
        }

        private void RenderLineChart(List<Hesaplama> hesaplamalar)
        {
            formsPlotCizgi.Plot.Clear();

            formsPlotCizgi.Plot.Axes.Left.IsVisible = true; 
            formsPlotCizgi.Plot.Axes.Right.IsVisible = false;
            formsPlotCizgi.Plot.Axes.Top.IsVisible = false;

            if (hesaplamalar.Count == 0)
            {
                formsPlotCizgi.Refresh();
                return;
            }

            var son12Ay = Enumerable.Range(0, 12).Select(i => DateTime.Now.AddMonths(-11 + i)).ToList();
            var aylikVeriler = son12Ay.Select(ay =>
            {
                var start = new DateTime(ay.Year, ay.Month, 1);
                var end = start.AddMonths(1).AddDays(-1);
                return (double)hesaplamalar.Count(h => h.Tarih >= start && h.Tarih <= end);
            }).ToArray();

            var positions = Enumerable.Range(0, 12).Select(i => (double)i).ToArray();
            
            var scatter = formsPlotCizgi.Plot.Add.Scatter(positions, aylikVeriler);
            scatter.Color = ScottPlot.Color.FromHex("#3B82F6"); 
            scatter.LineWidth = 3;
            scatter.MarkerSize = 8;
            
            if (aylikVeriler.Length > 1)
            {
                double sumX = positions.Sum();
                double sumY = aylikVeriler.Sum();
                double sumXY = positions.Zip(aylikVeriler, (x, y) => x * y).Sum();
                double sumX2 = positions.Sum(x => x * x);
                int n = positions.Length;

                double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
                double intercept = (sumY - slope * sumX) / n;

                double x1 = 0;
                double y1 = slope * x1 + intercept;
                double x2 = 14; 
                double y2 = slope * x2 + intercept;

                var trendLine = formsPlotCizgi.Plot.Add.Line(x1, y1, x2, y2);
                trendLine.LineColor = ScottPlot.Color.FromHex("#94A3B8").WithAlpha(0.5f);
                trendLine.LineWidth = 2;
                trendLine.LinePattern = ScottPlot.LinePattern.Dashed;
                
                var legend = formsPlotCizgi.Plot.Add.Text("Tahmin Trendi", x2, y2);
                legend.LabelFontColor = ScottPlot.Color.FromHex("#94A3B8");
                legend.LabelFontSize = 10;
            }
            
            formsPlotCizgi.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                positions, 
                son12Ay.Select(d => d.ToString("MMM")).ToArray()
            );

            formsPlotCizgi.Refresh();
        }
        private async void btnYenile_Click(object sender, EventArgs e)
        {
            await VerileriYukle();
            NotifySuccess("Veriler güncellendi.");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}