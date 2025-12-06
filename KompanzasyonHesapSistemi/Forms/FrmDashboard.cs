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
using ScottPlot;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmDashboard : Form
    {
        private readonly JsonService _jsonService;
        private readonly HesaplamaService _hesaplamaService;
        private readonly ExcelService _excelService;
        private const string SIRKETLER_FILE = "sirketler.json";
        private const string ISTAKIP_FILE = "istakip.json";

        public FrmDashboard()
        {
            InitializeComponent();
            _jsonService = new JsonService();
            _hesaplamaService = new HesaplamaService();
            _excelService = new ExcelService();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                // Kart değerlerini güncelle
                KartlariGuncelle();

                // Grafikleri oluştur
                GrafikleriOlustur();

                // Son hesaplamaları yükle
                SonHesaplamalariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KartlariGuncelle()
        {
            try
            {
                // Toplam Şirket Sayısı
                var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);
                lblKart1Deger.Text = sirketler.Count.ToString();

                // Toplam Hesaplama
                var hesaplamalar = _hesaplamaService.TumHesaplamalariGetir();
                lblKart2Deger.Text = hesaplamalar.Count.ToString();

                // Bu Ay Ceza Oranı
                var buAyBaslangic = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var buAyBitis = buAyBaslangic.AddMonths(1).AddDays(-1);
                var buAyHesaplamalar = hesaplamalar.Where(h => h.Tarih >= buAyBaslangic && h.Tarih <= buAyBitis).ToList();

                if (buAyHesaplamalar.Count > 0)
                {
                    var cezaliSayisi = buAyHesaplamalar.Count(h => h.CezaDurumu == "CEZA VAR");
                    var cezaOrani = (double)cezaliSayisi / buAyHesaplamalar.Count * 100;
                    lblKart3Deger.Text = $"%{cezaOrani:F1}";
                }
                else
                {
                    lblKart3Deger.Text = "%0";
                }

                // Toplam İş Bakiyesi
                var isler = _jsonService.ReadList<IsTakip>(ISTAKIP_FILE);
                var toplamBakiye = isler.Sum(i => i.Bakiye);
                lblKart4Deger.Text = $"₺{toplamBakiye:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kart güncelleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrafikleriOlustur()
        {
            try
            {
                var hesaplamalar = _hesaplamaService.TumHesaplamalariGetir();

                // Pasta Grafik: Cezalı vs Cezasız
                PastaGrafikOlustur(hesaplamalar);

                // Çubuk Grafik: Şirketlere göre hesaplama sayıları
                CubukGrafikOlustur(hesaplamalar);

                // Çizgi Grafik: Aylık hesaplama trendi
                CizgiGrafikOlustur(hesaplamalar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grafik oluşturma hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PastaGrafikOlustur(List<Hesaplama> hesaplamalar)
        {
            formsPlotPasta.Plot.Clear();

            if (hesaplamalar.Count == 0)
            {
                formsPlotPasta.Plot.Title("Cezalı vs Cezasız Hesaplamalar\n(Veri Yok)");
                formsPlotPasta.Refresh();
                return;
            }

            var cezaliSayisi = hesaplamalar.Count(h => h.CezaDurumu == "CEZA VAR");
            var cezasizSayisi = hesaplamalar.Count - cezaliSayisi;

            var values = new double[] { cezaliSayisi, cezasizSayisi };
            var labels = new string[] { $"Cezalı ({cezaliSayisi})", $"Cezasız ({cezasizSayisi})" };

            var pie = formsPlotPasta.Plot.Add.Pie(values);
            if (pie != null)
            {
                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    pie.Slices[i].Label = labels[i];
                }
                pie.ShowSliceLabels = true;
            }

            formsPlotPasta.Plot.Title("Cezalı vs Cezasız Hesaplamalar");
            formsPlotPasta.Refresh();
        }

        private void CubukGrafikOlustur(List<Hesaplama> hesaplamalar)
        {
            formsPlotCubuk.Plot.Clear();

            if (hesaplamalar.Count == 0)
            {
                formsPlotCubuk.Plot.Title("Şirketlere Göre Hesaplama Sayıları\n(Veri Yok)");
                formsPlotCubuk.Refresh();
                return;
            }

            // Şirketlere göre hesaplama sayılarını grupla
            var sirketHesaplamalari = hesaplamalar
                .GroupBy(h => h.SirketAdi)
                .Select(g => new { SirketAdi = g.Key, Sayi = g.Count() })
                .OrderByDescending(x => x.Sayi)
                .Take(10) // En fazla 10 şirket
                .ToList();

            if (sirketHesaplamalari.Count == 0)
            {
                formsPlotCubuk.Plot.Title("Şirketlere Göre Hesaplama Sayıları\n(Veri Yok)");
                formsPlotCubuk.Refresh();
                return;
            }

            var positions = Enumerable.Range(0, sirketHesaplamalari.Count).Select(i => (double)i).ToArray();
            var values = sirketHesaplamalari.Select(x => (double)x.Sayi).ToArray();

            var bar = formsPlotCubuk.Plot.Add.Bars(positions, values);
            bar.Color = new ScottPlot.Color(30, 144, 255);

            // X ekseni ayarları
            formsPlotCubuk.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlotCubuk.Plot.Axes.Bottom.TickLabelStyle.FontSize = 8;

            formsPlotCubuk.Plot.Title("Şirketlere Göre Hesaplama Sayıları");
            formsPlotCubuk.Plot.Axes.Left.Label.Text = "Hesaplama Sayısı";
            formsPlotCubuk.Plot.Axes.Bottom.Label.Text = "Şirketler";
            formsPlotCubuk.Refresh();
        }

        private void CizgiGrafikOlustur(List<Hesaplama> hesaplamalar)
        {
            formsPlotCizgi.Plot.Clear();

            if (hesaplamalar.Count == 0)
            {
                formsPlotCizgi.Plot.Title("Aylık Hesaplama Trendi\n(Veri Yok)");
                formsPlotCizgi.Refresh();
                return;
            }

            // Son 12 ayın verilerini al
            var son12Ay = new List<DateTime>();
            for (int i = 11; i >= 0; i--)
            {
                son12Ay.Add(DateTime.Now.AddMonths(-i));
            }

            var aylikHesaplamalar = son12Ay.Select(ay =>
            {
                var ayBaslangic = new DateTime(ay.Year, ay.Month, 1);
                var ayBitis = ayBaslangic.AddMonths(1).AddDays(-1);
                return hesaplamalar.Count(h => h.Tarih >= ayBaslangic && h.Tarih <= ayBitis);
            }).ToArray();

            var positions = Enumerable.Range(0, son12Ay.Count).Select(i => (double)i).ToArray();

            var scatter = formsPlotCizgi.Plot.Add.Scatter(positions, aylikHesaplamalar);
            scatter.Color = new ScottPlot.Color(255, 165, 0);
            scatter.LineWidth = 2;
            scatter.MarkerSize = 8;

            // X ekseni ayarları
            formsPlotCizgi.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlotCizgi.Plot.Axes.Bottom.TickLabelStyle.FontSize = 8;

            formsPlotCizgi.Plot.Title("Aylık Hesaplama Trendi");
            formsPlotCizgi.Plot.Axes.Left.Label.Text = "Hesaplama Sayısı";
            formsPlotCizgi.Plot.Axes.Bottom.Label.Text = "Aylar";
            formsPlotCizgi.Refresh();
        }

        private void SonHesaplamalariYukle()
        {
            try
            {
                var hesaplamalar = _hesaplamaService.TumHesaplamalariGetir();
                var sonHesaplamalar = hesaplamalar
                    .OrderByDescending(h => h.Tarih)
                    .Take(10)
                    .ToList();

                dgvSonHesaplamalar.DataSource = null;
                dgvSonHesaplamalar.AutoGenerateColumns = false;
                dgvSonHesaplamalar.Columns.Clear();

                // Kolonları oluştur
                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Width = 50
                });

                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SirketAdi",
                    HeaderText = "Şirket Adı",
                    DataPropertyName = "SirketAdi",
                    Width = 200
                });

                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Tarih",
                    HeaderText = "Tarih",
                    DataPropertyName = "Tarih",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
                });

                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "AktifTuketim",
                    HeaderText = "Aktif (kWh)",
                    DataPropertyName = "AktifTuketim",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });

                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "EnduktifOran",
                    HeaderText = "Endüktif (%)",
                    DataPropertyName = "EnduktifOran",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });

                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "KapasitifOran",
                    HeaderText = "Kapasitif (%)",
                    DataPropertyName = "KapasitifOran",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });

                dgvSonHesaplamalar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "CezaDurumu",
                    HeaderText = "Ceza Durumu",
                    DataPropertyName = "CezaDurumu",
                    Width = 120
                });

                dgvSonHesaplamalar.DataSource = sonHesaplamalar;

                // Ceza durumuna göre renklendirme
                foreach (DataGridViewRow row in dgvSonHesaplamalar.Rows)
                {
                    if (row.DataBoundItem is Hesaplama hesaplama)
                    {
                        if (hesaplama.CezaDurumu == "CEZA VAR")
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Son hesaplamalar yükleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VerileriYukle();
            MessageBox.Show("Dashboard yenilendi!", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            _excelService.ExportToExcel(dgvSonHesaplamalar);
        }
    }
}
