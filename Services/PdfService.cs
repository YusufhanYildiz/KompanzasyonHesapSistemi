using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using KompanzasyonHesapSistemi.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Borders;
using iText.IO.Font;

namespace KompanzasyonHesapSistemi.Services
{
    public class PdfService
    {
        private static readonly DeviceRgb DarkSlate = new DeviceRgb(31, 41, 55);
        private static readonly DeviceRgb SuccessGreen = new DeviceRgb(16, 185, 129);
        private static readonly DeviceRgb DangerRed = new DeviceRgb(239, 68, 68);
        private static readonly DeviceRgb BorderGray = new DeviceRgb(229, 231, 235);
        private static readonly DeviceRgb HeaderBg = new DeviceRgb(243, 244, 246);

        private static PdfFont? _font;
        private static PdfFont? _boldFont;

        public void HesaplamaRaporuOlustur(string dosyaYolu, IEnumerable<Hesaplama> hesaplamalar, string? sirketAdi = null)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(dosyaYolu))
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf, PageSize.A4);
                    document.SetMargins(30, 30, 30, 30);

                    PdfFont font = GetMainFont();
                    PdfFont boldFont = GetBoldFont();
                    document.SetFont(font);

                    // 1. Teknik Başlık Alanı
                    Table headerTable = new Table(UnitValue.CreatePercentArray(new float[] { 70, 30 })).SetWidth(UnitValue.CreatePercentValue(100));
                    
                    Cell titleCell = new Cell().Add(new Paragraph("KOMPANZASYON TEKNİK ANALİZ")
                        .SetFont(boldFont).SetFontSize(20).SetFontColor(DarkSlate))
                        .SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                    headerTable.AddCell(titleCell);

                    Cell dateCell = new Cell().Add(new Paragraph($"TARİH: {DateTime.Now:dd.MM.yyyy}\nSAAT: {DateTime.Now:HH:mm}")
                        .SetFontSize(9).SetFontColor(ColorConstants.GRAY).SetTextAlignment(TextAlignment.RIGHT))
                        .SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                    headerTable.AddCell(dateCell);
                    document.Add(headerTable);

                    document.Add(new LineSeparator(new iText.Kernel.Pdf.Canvas.Draw.SolidLine(1f)).SetMarginTop(5).SetMarginBottom(15));

                    // 2. Müşteri ve Tesis Özeti
                    if (!string.IsNullOrEmpty(sirketAdi))
                    {
                        document.Add(new Paragraph("TESİS BİLGİSİ").SetFont(boldFont).SetFontSize(10).SetFontColor(ColorConstants.GRAY));
                        document.Add(new Paragraph(sirketAdi!.ToUpper()).SetFont(boldFont).SetFontSize(14).SetMarginBottom(10));
                    }

                    // 3. Durum Bannerı (Usta için Kritik Alan)
                    bool cezaVarMi = hesaplamalar.Any(h => h.CezaDurumu == "CEZA VAR");
                    DeviceRgb statusColor = cezaVarMi ? DangerRed : SuccessGreen;
                    string statusText = cezaVarMi ? "DİKKAT: CEZA SINIRI AŞILMIŞTIR" : "SİSTEM DURUMU: CEZA YOK / GÜVENLİ";

                    Table statusTable = new Table(1).SetWidth(UnitValue.CreatePercentValue(100)).SetMarginBottom(20);
                    statusTable.AddCell(new Cell().Add(new Paragraph(statusText)
                        .SetFont(boldFont).SetFontSize(12).SetFontColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER))
                        .SetBackgroundColor(statusColor).SetPadding(8).SetBorder(Border.NO_BORDER));
                    document.Add(statusTable);

                    // 4. Detaylı Veri Tablosu
                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 2, 2, 2, 2, 2, 2, 3 }))
                        .SetWidth(UnitValue.CreatePercentValue(100));

                    string[] headers = { "TARİH", "AKTİF kWh", "END. kWh", "KAP. kWh", "END. %", "KAP. %", "DURUM" };
                    foreach (var h in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(h).SetFont(boldFont).SetFontSize(9).SetFontColor(DarkSlate))
                            .SetBackgroundColor(HeaderBg)
                            .SetPadding(5).SetBorder(new SolidBorder(BorderGray, 0.5f)));
                    }

                    foreach (var h in hesaplamalar)
                    {
                        table.AddCell(CreateDataCell(h.Tarih.ToString("dd.MM.yyyy")));
                        table.AddCell(CreateDataCell(h.AktifTuketim.ToString("N1"), TextAlignment.RIGHT));
                        table.AddCell(CreateDataCell(h.EnduktifTuketim.ToString("N1"), TextAlignment.RIGHT));
                        table.AddCell(CreateDataCell(h.KapasitifTuketim.ToString("N1"), TextAlignment.RIGHT));
                        table.AddCell(CreateRatioCell(h.EnduktifOran, 20)); 
                        table.AddCell(CreateRatioCell(h.KapasitifOran, 15)); 
                        
                        Cell cezaCell = new Cell().Add(new Paragraph(h.CezaDurumu)
                            .SetFont(boldFont).SetFontSize(8))
                            .SetTextAlignment(TextAlignment.CENTER).SetPadding(5).SetBorder(new SolidBorder(BorderGray, 0.5f));
                        
                        if (h.CezaDurumu == "CEZA VAR") cezaCell.SetFontColor(DangerRed);
                        else cezaCell.SetFontColor(SuccessGreen);
                        table.AddCell(cezaCell);
                    }
                    document.Add(table);

                    // 5. Alt Not
                    document.Add(new Paragraph("\n\n* Bu rapor Kompanzasyon Hesap Sistemi tarafından teknik analiz amaçlı oluşturulmuştur.")
                        .SetFontSize(8).SetFontColor(ColorConstants.GRAY).SetItalic());

                    document.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"PDF oluşturma hatası: {ex.Message}");
            }
        }

        public void IsTakipRaporuOlustur(string dosyaYolu, IEnumerable<IsTakip> isler)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(dosyaYolu))
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf, PageSize.A4);
                    document.SetMargins(30, 30, 30, 30);

                    PdfFont font = GetMainFont();
                    PdfFont boldFont = GetBoldFont();
                    document.SetFont(font);

                    // Başlık
                    document.Add(new Paragraph("YAPILAN İŞLER LİSTESİ")
                        .SetFont(boldFont).SetFontSize(18).SetFontColor(DarkSlate).SetMarginBottom(10));

                    decimal toplamUcret = isler.Sum(i => i.IsUcreti);
                    
                    // Özet Kartı
                    Table summary = new Table(2).SetWidth(UnitValue.CreatePercentValue(40)).SetMarginBottom(20);
                    summary.AddCell(new Cell().Add(new Paragraph("TOPLAM TUTAR:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
                    summary.AddCell(new Cell().Add(new Paragraph($"₺{toplamUcret:N2}")
                        .SetFont(boldFont).SetFontSize(12))
                        .SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.RIGHT));
                    document.Add(summary);

                    // Tablo
                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 2, 3, 5, 2 }))
                        .SetWidth(UnitValue.CreatePercentValue(100));

                    string[] headers = { "TARİH", "ŞİRKET", "İŞ AÇIKLAMASI", "ÜCRET" };
                    foreach (var h in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(h).SetFont(boldFont).SetFontSize(9))
                            .SetBackgroundColor(HeaderBg).SetPadding(5).SetBorder(new SolidBorder(BorderGray, 0.5f)));
                    }

                    foreach (var is_ in isler)
                    {
                        table.AddCell(CreateDataCell(is_.Tarih.ToString("dd.MM.yy")));
                        table.AddCell(CreateDataCell(is_.SirketAdi));
                        table.AddCell(CreateDataCell(is_.IsAciklamasi));
                        table.AddCell(CreateDataCell($"₺{is_.IsUcreti:N2}", TextAlignment.RIGHT));
                    }
                    document.Add(table);
                    document.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"PDF oluşturma hatası: {ex.Message}");
            }
        }

        private Cell CreateDataCell(string text, TextAlignment alignment = TextAlignment.LEFT)
        {
            return new Cell().Add(new Paragraph(text).SetFontSize(9))
                .SetTextAlignment(alignment).SetPadding(5).SetBorder(new SolidBorder(BorderGray, 0.5f));
        }

        private Cell CreateRatioCell(double value, double limit)
        {
            Paragraph p = new Paragraph($"%{value:F2}").SetFontSize(9);
            if (value > limit) p.SetFontColor(DangerRed).SetBold();
            
            return new Cell().Add(p).SetTextAlignment(TextAlignment.RIGHT).SetPadding(5).SetBorder(new SolidBorder(BorderGray, 0.5f));
        }

        private PdfFont GetMainFont()
        {
            if (_font != null) return _font;
            string fontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            if (!File.Exists(fontPath)) _font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA, PdfEncodings.IDENTITY_H);
            else _font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
            return _font;
        }

        private PdfFont GetBoldFont()
        {
            if (_boldFont != null) return _boldFont;
            string fontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arialbd.ttf");
            if (!File.Exists(fontPath)) _boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD, PdfEncodings.IDENTITY_H);
            else _boldFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
            return _boldFont;
        }

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
