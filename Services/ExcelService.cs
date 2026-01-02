using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using ExcelDataReader;
using System.IO;

namespace KompanzasyonHesapSistemi.Services
{
    public class ExcelService
    {
        public Action<string, int>? NotifyMessage { get; set; }

        public void ExportToExcel(DataGridView dgv)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Veriler");

                            // Başlıkları (Header) ekle
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                            }

                            // Verileri ekle
                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv.Columns.Count; j++)
                                {
                                    var cellValue = dgv.Rows[i].Cells[j].Value;
                                    
                                    // ULTRATHINK OPTIMIZATION: Native Type Preservation
                                    if (cellValue != null)
                                    {
                                        if (double.TryParse(cellValue.ToString(), out double dVal))
                                            worksheet.Cell(i + 2, j + 1).Value = dVal;
                                        else if (DateTime.TryParse(cellValue.ToString(), out DateTime dtVal))
                                            worksheet.Cell(i + 2, j + 1).Value = dtVal;
                                        else
                                            worksheet.Cell(i + 2, j + 1).Value = cellValue.ToString();
                                    }
                                }
                            }

                            // Stil Uygula (isteğe bağlı)
                            var headerRange = worksheet.Range(1, 1, 1, dgv.Columns.Count);
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                        }
                        NotifyMessage?.Invoke("Veriler başarıyla Excel'e aktarıldı.", 3000);
                    }
                }
            }
            catch (Exception ex)
            {
                NotifyMessage?.Invoke($"Excel'e aktarma sırasında bir hata oluştu: {ex.Message}", 5000);
            }
        }
        public DataTable ImportFromExcel()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Dosyaları|*.xlsx;*.xls;*.xlsb;*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            IExcelDataReader reader;
                            if (ofd.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                            {
                                reader = ExcelReaderFactory.CreateCsvReader(stream);
                            }
                            else
                            {
                                reader = ExcelReaderFactory.CreateReader(stream);
                            }

                            using (reader)
                            {
                                var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                    {
                                        UseHeaderRow = true
                                    }
                                });

                                if (result.Tables.Count > 0)
                                {
                                    dt = result.Tables[0];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                NotifyMessage?.Invoke($"Excel'den okuma sırasında bir hata oluştu: {ex.Message}", 5000);
            }
            return dt;
        }
    }
}
