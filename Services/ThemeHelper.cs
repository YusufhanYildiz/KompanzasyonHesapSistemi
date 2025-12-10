using System;
using System.Drawing;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Services
{
    public static class ThemeHelper
    {
        // Renk Paleti (Modern Kurumsal Tema)
        public static readonly Color PrimaryColor = Color.FromArgb(44, 62, 80);    // Midnight Blue (Sidebar)
        public static readonly Color SecondaryColor = Color.FromArgb(52, 73, 94);  // Wet Asphalt (Header)
        public static readonly Color AccentColor = Color.FromArgb(26, 188, 156);   // Turquoise (Vurgu/Butonlar)
        public static readonly Color BackgroundColor = Color.FromArgb(236, 240, 241); // Clouds (Arkaplan)
        public static readonly Color TextColor = Color.FromArgb(44, 62, 80);       // Koyu Metin
        public static readonly Color LightTextColor = Color.White;                 // Açık Metin

        // Fontlar
        public static readonly Font HeaderFont = new Font("Segoe UI", 14, FontStyle.Bold);
        public static readonly Font NormalFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10, FontStyle.Bold);

        /// <summary>
        /// Form üzerindeki kontrollere modern temayı uygular
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            form.BackColor = BackgroundColor;
            form.Font = NormalFont;

            foreach (Control control in form.Controls)
            {
                ApplyStyleToControl(control);
            }
        }

        private static void ApplyStyleToControl(Control control)
        {
            // Panel Kontrolü
            if (control is Panel pnl)
            {
                // İsimlendirmeye göre özel renklendirme yapılabilir
                if (pnl.Name.Contains("Menu") || pnl.Name.Contains("Sidebar"))
                {
                    pnl.BackColor = PrimaryColor;
                }
                else if (pnl.Name.Contains("Ust") || pnl.Name.Contains("Header"))
                {
                    pnl.BackColor = SecondaryColor;
                }
                else if (pnl.Name.Contains("Icerik") || pnl.Name.Contains("Content"))
                {
                    pnl.BackColor = BackgroundColor;
                }

                // Alt kontrolleri de işle
                foreach (Control child in pnl.Controls)
                {
                    ApplyStyleToControl(child);
                }
            }
            // GroupBox Kontrolü
            else if (control is GroupBox grp)
            {
                grp.ForeColor = TextColor;
                foreach (Control child in grp.Controls)
                {
                    ApplyStyleToControl(child);
                }
            }
            // Buton Kontrolü
            else if (control is Button btn)
            {
                StyleButton(btn);
            }
            // Label Kontrolü
            else if (control is Label lbl)
            {
                // Eğer parent'ı koyu renkli bir panelse metni beyaz yap
                if (lbl.Parent != null && 
                   (lbl.Parent.BackColor == PrimaryColor || lbl.Parent.BackColor == SecondaryColor))
                {
                    lbl.ForeColor = LightTextColor;
                }
                else
                {
                    lbl.ForeColor = TextColor;
                }
            }
            // DataGridView Kontrolü
            else if (control is DataGridView dgv)
            {
                StyleDataGrid(dgv);
            }
            // TextBox ve ComboBox
            else if (control is TextBox || control is ComboBox || control is DateTimePicker)
            {
                control.BackColor = Color.White;
                control.ForeColor = TextColor;
            }
        }

        public static void StyleButton(Button btn)
        {
            // Eğer buton zaten özel bir renk değilse veya menü butonuysa
            // Menü butonları genellikle panel içinde olur
            
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = ButtonFont;

            // Menü butonları için özel stil
            if (btn.Parent != null && btn.Parent.Name.Contains("Menu"))
            {
                btn.BackColor = PrimaryColor;
                btn.ForeColor = LightTextColor;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.Padding = new Padding(10, 0, 0, 0);
                
                // Hover efekti için event ekle
                btn.MouseEnter += (s, e) => { btn.BackColor = AccentColor; };
                btn.MouseLeave += (s, e) => { btn.BackColor = PrimaryColor; };
            }
            // Çıkış butonu gibi özel butonlar
            else if (btn.Name.Contains("Cikis") || btn.Name.Contains("Sil"))
            {
                btn.BackColor = Color.Crimson;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }
            // İşlem butonları (Kaydet, Hesapla vb.)
            else
            {
                btn.BackColor = AccentColor;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        public static void StyleDataGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
            // Başlık Stili
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SecondaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = ButtonFont;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgv.ColumnHeadersHeight = 40;

            // Satır Stili
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = TextColor;
            dgv.DefaultCellStyle.SelectionBackColor = AccentColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.RowTemplate.Height = 35;

            // Alternatif Satır Rengi
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }
    }
}
