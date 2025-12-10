using ScottPlot;
using ScottPlot.WinForms;

namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlKartlar = new Panel();
            pnlKart4 = new Panel();
            lblKart4Deger = new System.Windows.Forms.Label();
            lblKart4Baslik = new System.Windows.Forms.Label();
            pnlKart3 = new Panel();
            lblKart3Deger = new System.Windows.Forms.Label();
            lblKart3Baslik = new System.Windows.Forms.Label();
            pnlKart2 = new Panel();
            lblKart2Deger = new System.Windows.Forms.Label();
            lblKart2Baslik = new System.Windows.Forms.Label();
            pnlKart1 = new Panel();
            lblKart1Deger = new System.Windows.Forms.Label();
            lblKart1Baslik = new System.Windows.Forms.Label();
            formsPlotPasta = new FormsPlot();
            formsPlotCubuk = new FormsPlot();
            formsPlotCizgi = new FormsPlot();
            gbSonHesaplamalar = new GroupBox();
            dgvSonHesaplamalar = new DataGridView();
            btnYenile = new Button();
            btnKapat = new Button();
            btnExcelAktar = new Button();
            pnlKartlar.SuspendLayout();
            pnlKart4.SuspendLayout();
            pnlKart3.SuspendLayout();
            pnlKart2.SuspendLayout();
            pnlKart1.SuspendLayout();
            gbSonHesaplamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonHesaplamalar).BeginInit();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.BackColor = System.Drawing.Color.WhiteSmoke;
            pnlKartlar.Controls.Add(pnlKart4);
            pnlKartlar.Controls.Add(pnlKart3);
            pnlKartlar.Controls.Add(pnlKart2);
            pnlKartlar.Controls.Add(pnlKart1);
            pnlKartlar.Dock = DockStyle.Top;
            pnlKartlar.Location = new Point(0, 0);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(1200, 117);
            pnlKartlar.TabIndex = 0;
            // 
            // pnlKart4
            // 
            pnlKart4.BackColor = System.Drawing.Color.Orange;
            pnlKart4.Controls.Add(lblKart4Deger);
            pnlKart4.Controls.Add(lblKart4Baslik);
            pnlKart4.Location = new Point(830, 10);
            pnlKart4.Name = "pnlKart4";
            pnlKart4.Size = new Size(250, 100);
            pnlKart4.TabIndex = 3;
            // 
            // lblKart4Deger
            // 
            lblKart4Deger.AutoSize = true;
            lblKart4Deger.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKart4Deger.ForeColor = System.Drawing.Color.White;
            lblKart4Deger.Location = new Point(10, 40);
            lblKart4Deger.Name = "lblKart4Deger";
            lblKart4Deger.Size = new Size(88, 37);
            lblKart4Deger.TabIndex = 1;
            lblKart4Deger.Text = "₺0,00";
            // 
            // lblKart4Baslik
            // 
            lblKart4Baslik.AutoSize = true;
            lblKart4Baslik.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKart4Baslik.ForeColor = System.Drawing.Color.White;
            lblKart4Baslik.Location = new Point(10, 10);
            lblKart4Baslik.Name = "lblKart4Baslik";
            lblKart4Baslik.Size = new Size(96, 19);
            lblKart4Baslik.TabIndex = 0;
            lblKart4Baslik.Text = "Toplam Bakiye";
            // 
            // pnlKart3
            // 
            pnlKart3.BackColor = System.Drawing.Color.Crimson;
            pnlKart3.Controls.Add(lblKart3Deger);
            pnlKart3.Controls.Add(lblKart3Baslik);
            pnlKart3.Location = new Point(560, 10);
            pnlKart3.Name = "pnlKart3";
            pnlKart3.Size = new Size(250, 100);
            pnlKart3.TabIndex = 2;
            // 
            // lblKart3Deger
            // 
            lblKart3Deger.AutoSize = true;
            lblKart3Deger.Font = new Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKart3Deger.ForeColor = System.Drawing.Color.White;
            lblKart3Deger.Location = new Point(10, 40);
            lblKart3Deger.Name = "lblKart3Deger";
            lblKart3Deger.Size = new Size(66, 45);
            lblKart3Deger.TabIndex = 1;
            lblKart3Deger.Text = "%0";
            // 
            // lblKart3Baslik
            // 
            lblKart3Baslik.AutoSize = true;
            lblKart3Baslik.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKart3Baslik.ForeColor = System.Drawing.Color.White;
            lblKart3Baslik.Location = new Point(10, 10);
            lblKart3Baslik.Name = "lblKart3Baslik";
            lblKart3Baslik.Size = new Size(76, 19);
            lblKart3Baslik.TabIndex = 0;
            lblKart3Baslik.Text = "Ceza Oranı";
            // 
            // pnlKart2
            // 
            pnlKart2.BackColor = System.Drawing.Color.SeaGreen;
            pnlKart2.Controls.Add(lblKart2Deger);
            pnlKart2.Controls.Add(lblKart2Baslik);
            pnlKart2.Location = new Point(290, 10);
            pnlKart2.Name = "pnlKart2";
            pnlKart2.Size = new Size(250, 100);
            pnlKart2.TabIndex = 1;
            // 
            // lblKart2Deger
            // 
            lblKart2Deger.AutoSize = true;
            lblKart2Deger.Font = new Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKart2Deger.ForeColor = System.Drawing.Color.White;
            lblKart2Deger.Location = new Point(10, 40);
            lblKart2Deger.Name = "lblKart2Deger";
            lblKart2Deger.Size = new Size(38, 45);
            lblKart2Deger.TabIndex = 1;
            lblKart2Deger.Text = "0";
            // 
            // lblKart2Baslik
            // 
            lblKart2Baslik.AutoSize = true;
            lblKart2Baslik.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKart2Baslik.ForeColor = System.Drawing.Color.White;
            lblKart2Baslik.Location = new Point(10, 10);
            lblKart2Baslik.Name = "lblKart2Baslik";
            lblKart2Baslik.Size = new Size(124, 19);
            lblKart2Baslik.TabIndex = 0;
            lblKart2Baslik.Text = "Toplam Hesaplama";
            // 
            // pnlKart1
            // 
            pnlKart1.BackColor = System.Drawing.Color.DodgerBlue;
            pnlKart1.Controls.Add(lblKart1Deger);
            pnlKart1.Controls.Add(lblKart1Baslik);
            pnlKart1.Location = new Point(20, 10);
            pnlKart1.Name = "pnlKart1";
            pnlKart1.Size = new Size(250, 100);
            pnlKart1.TabIndex = 0;
            // 
            // lblKart1Deger
            // 
            lblKart1Deger.AutoSize = true;
            lblKart1Deger.Font = new Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKart1Deger.ForeColor = System.Drawing.Color.White;
            lblKart1Deger.Location = new Point(10, 40);
            lblKart1Deger.Name = "lblKart1Deger";
            lblKart1Deger.Size = new Size(38, 45);
            lblKart1Deger.TabIndex = 1;
            lblKart1Deger.Text = "0";
            // 
            // lblKart1Baslik
            // 
            lblKart1Baslik.AutoSize = true;
            lblKart1Baslik.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKart1Baslik.ForeColor = System.Drawing.Color.White;
            lblKart1Baslik.Location = new Point(10, 10);
            lblKart1Baslik.Name = "lblKart1Baslik";
            lblKart1Baslik.Size = new Size(91, 19);
            lblKart1Baslik.TabIndex = 0;
            lblKart1Baslik.Text = "Toplam Şirket";
            // 
            // formsPlotPasta
            // 
            formsPlotPasta.DisplayScale = 1F;
            formsPlotPasta.Location = new Point(20, 123);
            formsPlotPasta.Name = "formsPlotPasta";
            formsPlotPasta.Size = new Size(380, 237);
            formsPlotPasta.TabIndex = 1;
            // 
            // formsPlotCubuk
            // 
            formsPlotCubuk.DisplayScale = 1F;
            formsPlotCubuk.Location = new Point(430, 123);
            formsPlotCubuk.Name = "formsPlotCubuk";
            formsPlotCubuk.Size = new Size(380, 237);
            formsPlotCubuk.TabIndex = 2;
            // 
            // formsPlotCizgi
            // 
            formsPlotCizgi.DisplayScale = 1F;
            formsPlotCizgi.Location = new Point(816, 123);
            formsPlotCizgi.Name = "formsPlotCizgi";
            formsPlotCizgi.Size = new Size(380, 237);
            formsPlotCizgi.TabIndex = 3;
            // 
            // gbSonHesaplamalar
            // 
            gbSonHesaplamalar.Controls.Add(dgvSonHesaplamalar);
            gbSonHesaplamalar.Location = new Point(20, 366);
            gbSonHesaplamalar.Name = "gbSonHesaplamalar";
            gbSonHesaplamalar.Size = new Size(1180, 250);
            gbSonHesaplamalar.TabIndex = 4;
            gbSonHesaplamalar.TabStop = false;
            gbSonHesaplamalar.Text = "Son 10 Hesaplama";
            // 
            // dgvSonHesaplamalar
            // 
            dgvSonHesaplamalar.AllowUserToAddRows = false;
            dgvSonHesaplamalar.AllowUserToDeleteRows = false;
            dgvSonHesaplamalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonHesaplamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonHesaplamalar.Location = new Point(10, 25);
            dgvSonHesaplamalar.Name = "dgvSonHesaplamalar";
            dgvSonHesaplamalar.ReadOnly = true;
            dgvSonHesaplamalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonHesaplamalar.Size = new Size(1160, 215);
            dgvSonHesaplamalar.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = System.Drawing.Color.DodgerBlue;
            btnYenile.ForeColor = System.Drawing.Color.White;
            btnYenile.Location = new Point(16, 622);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(150, 40);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "🔄 Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = System.Drawing.Color.SlateGray;
            btnKapat.ForeColor = System.Drawing.Color.White;
            btnKapat.Location = new Point(1046, 622);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(150, 40);
            btnKapat.TabIndex = 6;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnExcelAktar
            // 
            btnExcelAktar.BackColor = System.Drawing.Color.Crimson;
            btnExcelAktar.ForeColor = System.Drawing.Color.White;
            btnExcelAktar.Location = new Point(184, 622);
            btnExcelAktar.Name = "btnExcelAktar";
            btnExcelAktar.Size = new Size(150, 40);
            btnExcelAktar.TabIndex = 7;
            btnExcelAktar.Text = "Excel'e Aktar";
            btnExcelAktar.UseVisualStyleBackColor = false;
            btnExcelAktar.Click += btnExcelAktar_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 665);
            Controls.Add(btnExcelAktar);
            Controls.Add(btnKapat);
            Controls.Add(btnYenile);
            Controls.Add(gbSonHesaplamalar);
            Controls.Add(formsPlotCizgi);
            Controls.Add(formsPlotCubuk);
            Controls.Add(formsPlotPasta);
            Controls.Add(pnlKartlar);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Genel Bakış";
            Load += FrmDashboard_Load;
            pnlKartlar.ResumeLayout(false);
            pnlKart4.ResumeLayout(false);
            pnlKart4.PerformLayout();
            pnlKart3.ResumeLayout(false);
            pnlKart3.PerformLayout();
            pnlKart2.ResumeLayout(false);
            pnlKart2.PerformLayout();
            pnlKart1.ResumeLayout(false);
            pnlKart1.PerformLayout();
            gbSonHesaplamalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSonHesaplamalar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlKartlar;
        private Panel pnlKart1;
        private System.Windows.Forms.Label lblKart1Baslik;
        private System.Windows.Forms.Label lblKart1Deger;
        private Panel pnlKart2;
        private System.Windows.Forms.Label lblKart2Baslik;
        private System.Windows.Forms.Label lblKart2Deger;
        private Panel pnlKart3;
        private System.Windows.Forms.Label lblKart3Deger;
        private System.Windows.Forms.Label lblKart3Baslik;
        private Panel pnlKart4;
        private System.Windows.Forms.Label lblKart4Deger;
        private System.Windows.Forms.Label lblKart4Baslik;
        private FormsPlot formsPlotPasta;
        private FormsPlot formsPlotCubuk;
        private FormsPlot formsPlotCizgi;
        private GroupBox gbSonHesaplamalar;
        private DataGridView dgvSonHesaplamalar;
        private Button btnYenile;
        private Button btnKapat;
        private Button btnExcelAktar;
    }
}
