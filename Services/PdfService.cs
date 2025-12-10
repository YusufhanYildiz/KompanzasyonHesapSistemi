using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KompanzasyonHesapSistemi.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Diagnostics;
using System.IO;

namespace KompanzasyonHesapSistemi.Services
{
    public class PdfService
    {
        private readonly string _raporKlasor;

        public PdfService()
        {
            // Production için AppData/Local klasörünü kullan
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _raporKlasor = Path.Combine(appDataFolder, "KompanzasyonHesapSistemi", "Reports");

            // Reports klasörü yoksa oluştur
            if (!Directory.Exists(_raporKlasor))
            {
                Directory.CreateDirectory(_raporKlasor);
            }

            // QuestPDF lisans ayarı (Community License)
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
        }

        /// <summary>
        /// Hesaplama raporu oluştur
        /// </summary>
        public string HesaplamaRaporuOlustur(List<Hesaplama> hesaplamalar, string? sirketAdi = null)
        {
            try
            {
                // Dosya adı oluştur
                string dosyaAdi = $"Kompanzasyon_Raporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string dosyaYolu = Path.Combine(_raporKlasor, dosyaAdi);

                // PDF oluştur
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                        // Başlık
                        page.Header().Element(container =>
                        {
                            container.Column(column =>
                            {
                                column.Item().AlignCenter().Text("KOMPANZASYON HESAPLAMA RAPORU")
                                    .FontSize(18).Bold().FontColor(Colors.Blue.Darken2);

                                column.Item().PaddingTop(5).AlignCenter().Text($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}")
                                    .FontSize(10).Italic();

                                if (!string.IsNullOrEmpty(sirketAdi))
                                {
                                    column.Item().PaddingTop(5).AlignCenter().Text($"Şirket: {sirketAdi}")
                                        .FontSize(12).Bold();
                                }

                                column.Item().PaddingTop(10).BorderBottom(2).BorderColor(Colors.Blue.Darken2);
                            });
                        });

                        // İçerik
                        page.Content().PaddingTop(20).Column(column =>
                        {
                            // Özet bilgiler
                            column.Item().Element(container =>
                            {
                                container.Background(Colors.Grey.Lighten3).Padding(10).Column(col =>
                                {
                                    col.Item().Text("ÖZET BİLGİLER").FontSize(12).Bold();
                                    col.Item().PaddingTop(5).Text($"Toplam Kayıt: {hesaplamalar.Count}");
                                    col.Item().Text($"Cezalı Kayıt: {hesaplamalar.Count(h => h.CezaDurumu == "CEZA VAR")}");
                                    col.Item().Text($"Cezasız Kayıt: {hesaplamalar.Count(h => h.CezaDurumu == "CEZA YOK")}");
                                });
                            });

                            // Boşluk
                            column.Item().PaddingTop(15);

                            // Tablo
                            column.Item().Table(table =>
                            {
                                // Sütun tanımları
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(40);  // ID
                                    columns.ConstantColumn(70);  // Tarih
                                    columns.RelativeColumn(2);   // Şirket
                                    columns.RelativeColumn(1);   // Aktif
                                    columns.RelativeColumn(1);   // Endüktif
                                    columns.RelativeColumn(1);   // Kapasitif
                                    columns.RelativeColumn(1);   // End. Oran
                                    columns.RelativeColumn(1);   // Kap. Oran
                                    columns.RelativeColumn(1);   // Ceza
                                });

                                // Başlık satırı
                                table.Header(header =>
                                {
                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("ID").FontColor(Colors.White).Bold().FontSize(9);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("Tarih").FontColor(Colors.White).Bold().FontSize(9);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("Şirket").FontColor(Colors.White).Bold().FontSize(9);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("Aktif (kWh)").FontColor(Colors.White).Bold().FontSize(8);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("End. (kVArh)").FontColor(Colors.White).Bold().FontSize(8);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("Kap. (kVArh)").FontColor(Colors.White).Bold().FontSize(8);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("End. (%)").FontColor(Colors.White).Bold().FontSize(8);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("Kap. (%)").FontColor(Colors.White).Bold().FontSize(8);

                                    header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                                        .Text("Ceza").FontColor(Colors.White).Bold().FontSize(9);
                                });

                                // Veri satırları
                                foreach (var hesaplama in hesaplamalar)
                                {
                                    var bgColor = hesaplama.CezaDurumu == "CEZA VAR"
                                        ? Colors.Red.Lighten4
                                        : Colors.Green.Lighten5;

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(hesaplama.Id.ToString()).FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(hesaplama.Tarih.ToString("dd.MM.yyyy")).FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(hesaplama.SirketAdi).FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text(hesaplama.AktifTuketim.ToString("N2")).FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text(hesaplama.EnduktifTuketim.ToString("N2")).FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text(hesaplama.KapasitifTuketim.ToString("N2")).FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text($"%{hesaplama.EnduktifOran:F2}").FontSize(9);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text($"%{hesaplama.KapasitifOran:F2}").FontSize(9);

                                    var cezaColor = hesaplama.CezaDurumu == "CEZA VAR"
                                        ? Colors.Red.Darken2
                                        : Colors.Green.Darken2;

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(hesaplama.CezaDurumu).FontColor(cezaColor).Bold().FontSize(9);
                                }
                            });
                        });

                        // Alt bilgi
                        page.Footer().AlignCenter().Text(text =>
                        {
                            text.Span("Sayfa ");
                            text.CurrentPageNumber().FontSize(8).Italic();
                            text.Span(" / ");
                            text.TotalPages().FontSize(8).Italic();
                            text.Span(" - Kompanzasyon Hesap Sistemi © 2025").FontSize(8).Italic();
                        });
                    });
                }).GeneratePdf(dosyaYolu);

                return dosyaYolu;
            }
            catch (Exception ex)
            {
                throw new Exception($"PDF oluşturma hatası: {ex.Message}");
            }
        }

        /// <summary>
        /// İş Takip raporu oluştur
        /// </summary>
        public string IsTakipRaporuOlustur(List<IsTakip> isler)
        {
            try
            {
                string dosyaAdi = $"IsTakip_Raporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string dosyaYolu = Path.Combine(_raporKlasor, dosyaAdi);

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                        // Başlık
                        page.Header().Element(container =>
                        {
                            container.Column(column =>
                            {
                                column.Item().AlignCenter().Text("İŞ TAKİP RAPORU")
                                    .FontSize(18).Bold().FontColor(Colors.Orange.Darken2);

                                column.Item().PaddingTop(5).AlignCenter().Text($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}")
                                    .FontSize(10).Italic();

                                column.Item().PaddingTop(10).BorderBottom(2).BorderColor(Colors.Orange.Darken2);
                            });
                        });

                        // İçerik
                        page.Content().PaddingTop(20).Column(column =>
                        {
                            // Özet bilgiler
                            decimal toplamIsUcreti = isler.Sum(i => i.IsUcreti);
                            decimal toplamAlinan = isler.Sum(i => i.AlinanTutar);
                            decimal toplamBakiye = isler.Sum(i => i.Bakiye);

                            column.Item().Element(container =>
                            {
                                container.Background(Colors.Orange.Lighten4).Padding(15).Column(col =>
                                {
                                    col.Item().Text("ÖZET BİLGİLER").FontSize(14).Bold();
                                    col.Item().PaddingTop(10).Text($"Toplam İş Sayısı: {isler.Count}").FontSize(12);
                                    col.Item().Text($"Toplam İş Ücreti: ₺{toplamIsUcreti:N2}").FontSize(12);
                                    col.Item().Text($"Toplam Alınan: ₺{toplamAlinan:N2}").FontSize(12);

                                    var bakiyeColor = toplamBakiye >= 0 ? Colors.Green.Darken2 : Colors.Red.Darken2;
                                    col.Item().PaddingTop(5).Text($"TOPLAM BAKİYE: ₺{toplamBakiye:N2}")
                                        .FontSize(14).Bold().FontColor(bakiyeColor);
                                });
                            });

                            column.Item().PaddingTop(20);

                            // Tablo
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(40);  // ID
                                    columns.ConstantColumn(70);  // Tarih
                                    columns.RelativeColumn(3);   // Açıklama
                                    columns.RelativeColumn(1);   // İş Ücreti
                                    columns.RelativeColumn(1);   // Alınan
                                    columns.RelativeColumn(1);   // Bakiye
                                });

                                // Başlık
                                table.Header(header =>
                                {
                                    header.Cell().Background(Colors.Orange.Darken2).Padding(5)
                                        .Text("ID").FontColor(Colors.White).Bold();

                                    header.Cell().Background(Colors.Orange.Darken2).Padding(5)
                                        .Text("Tarih").FontColor(Colors.White).Bold();

                                    header.Cell().Background(Colors.Orange.Darken2).Padding(5)
                                        .Text("İş Açıklaması").FontColor(Colors.White).Bold();

                                    header.Cell().Background(Colors.Orange.Darken2).Padding(5)
                                        .Text("İş Ücreti (₺)").FontColor(Colors.White).Bold();

                                    header.Cell().Background(Colors.Orange.Darken2).Padding(5)
                                        .Text("Alınan (₺)").FontColor(Colors.White).Bold();

                                    header.Cell().Background(Colors.Orange.Darken2).Padding(5)
                                        .Text("Bakiye (₺)").FontColor(Colors.White).Bold();
                                });

                                // Veri satırları
                                foreach (var is_ in isler)
                                {
                                    var bgColor = is_.Bakiye == 0
                                        ? Colors.Green.Lighten5
                                        : Colors.Yellow.Lighten4;

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(is_.Id.ToString());

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(is_.Tarih.ToString("dd.MM.yyyy"));

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).Text(is_.IsAciklamasi);

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text($"₺{is_.IsUcreti:N2}");

                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text($"₺{is_.AlinanTutar:N2}");

                                    var bakiyeColor = is_.Bakiye >= 0 ? Colors.Green.Darken2 : Colors.Red.Darken2;
                                    table.Cell().Background(bgColor).BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                        .Padding(5).AlignRight().Text($"₺{is_.Bakiye:N2}").FontColor(bakiyeColor).Bold();
                                }
                            });
                        });

                        // Alt bilgi
                        page.Footer().AlignCenter().Text(text =>
                        {
                            text.Span("Sayfa ");
                            text.CurrentPageNumber().FontSize(8).Italic();
                            text.Span(" / ");
                            text.TotalPages().FontSize(8).Italic();
                            text.Span(" - Kompanzasyon Hesap Sistemi © 2025").FontSize(8).Italic();
                        });
                    });
                }).GeneratePdf(dosyaYolu);

                return dosyaYolu;
            }
            catch (Exception ex)
            {
                throw new Exception($"PDF oluşturma hatası: {ex.Message}");
            }
        }

        /// <summary>
        /// PDF dosyasını aç
        /// </summary>
        public void PdfAc(string dosyaYolu)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = dosyaYolu,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"PDF açma hatası: {ex.Message}");
            }
        }
    }
}