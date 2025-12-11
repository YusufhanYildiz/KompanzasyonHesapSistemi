namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmHesaplamalar
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
            gbVeriGirisi = new GroupBox();
            txtOncekiKpstfTuketim = new TextBox();
            txtOncekiEnduktif = new TextBox();
            lblOncekiKpstfTuketim = new Label();
            lblOncekiEnduktif = new Label();
            txtOncekiAktif = new TextBox();
            lblOncekiAktif = new Label();
            btnTemizle = new Button();
            dtpTarih = new DateTimePicker();
            lblTarih = new Label();
            btnHesapla = new Button();
            cmbSirket = new ComboBox();
            lblSirket = new Label();
            txtKapasitif = new TextBox();
            lblAktif = new Label();
            lblEnduktif = new Label();
            txtEnduktif = new TextBox();
            lblKapasitif = new Label();
            txtAktif = new TextBox();
            gbOranSonuclari = new GroupBox();
            lblKapasitifLimit = new Label();
            lblEnduktifLimit = new Label();
            lblKapasitifOran = new Label();
            lblEnduktifOran = new Label();
            gbCezaDurumu = new GroupBox();
            lblCezaDurumuSonuc = new Label();
            dgvHesaplamalar = new DataGridView();
            btnPdfRapor = new Button();
            btnSil = new Button();
            btnYenile = new Button();
            btnKapat = new Button();
            btnExcelAktar = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cmbSirketFiltrele = new ComboBox();
            btnFiltreyiTemizle = new Button();
            btnFiltrele = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            label3 = new Label();
            gbVeriGirisi.SuspendLayout();
            gbOranSonuclari.SuspendLayout();
            gbCezaDurumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHesaplamalar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbVeriGirisi
            // 
            gbVeriGirisi.Controls.Add(txtOncekiKpstfTuketim);
            gbVeriGirisi.Controls.Add(txtOncekiEnduktif);
            gbVeriGirisi.Controls.Add(lblOncekiKpstfTuketim);
            gbVeriGirisi.Controls.Add(lblOncekiEnduktif);
            gbVeriGirisi.Controls.Add(txtOncekiAktif);
            gbVeriGirisi.Controls.Add(lblOncekiAktif);
            gbVeriGirisi.Controls.Add(btnTemizle);
            gbVeriGirisi.Controls.Add(dtpTarih);
            gbVeriGirisi.Controls.Add(lblTarih);
            gbVeriGirisi.Controls.Add(btnHesapla);
            gbVeriGirisi.Controls.Add(cmbSirket);
            gbVeriGirisi.Controls.Add(lblSirket);
            gbVeriGirisi.Controls.Add(txtKapasitif);
            gbVeriGirisi.Controls.Add(lblAktif);
            gbVeriGirisi.Controls.Add(lblEnduktif);
            gbVeriGirisi.Controls.Add(txtEnduktif);
            gbVeriGirisi.Controls.Add(lblKapasitif);
            gbVeriGirisi.Controls.Add(txtAktif);
            gbVeriGirisi.Location = new Point(6, 20);
            gbVeriGirisi.Name = "gbVeriGirisi";
            gbVeriGirisi.Size = new Size(822, 218);
            gbVeriGirisi.TabIndex = 0;
            gbVeriGirisi.TabStop = false;
            gbVeriGirisi.Text = "Veri Girişi";
            // 
            // txtOncekiKpstfTuketim
            // 
            txtOncekiKpstfTuketim.Location = new Point(208, 177);
            txtOncekiKpstfTuketim.Name = "txtOncekiKpstfTuketim";
            txtOncekiKpstfTuketim.Size = new Size(200, 23);
            txtOncekiKpstfTuketim.TabIndex = 17;
            // 
            // txtOncekiEnduktif
            // 
            txtOncekiEnduktif.Location = new Point(208, 142);
            txtOncekiEnduktif.Name = "txtOncekiEnduktif";
            txtOncekiEnduktif.Size = new Size(200, 23);
            txtOncekiEnduktif.TabIndex = 16;
            // 
            // lblOncekiKpstfTuketim
            // 
            lblOncekiKpstfTuketim.AutoSize = true;
            lblOncekiKpstfTuketim.Location = new Point(6, 180);
            lblOncekiKpstfTuketim.Name = "lblOncekiKpstfTuketim";
            lblOncekiKpstfTuketim.Size = new Size(171, 15);
            lblOncekiKpstfTuketim.TabIndex = 15;
            lblOncekiKpstfTuketim.Text = "Önceki Yazan Kapasitif Tüketim";
            // 
            // lblOncekiEnduktif
            // 
            lblOncekiEnduktif.AutoSize = true;
            lblOncekiEnduktif.Location = new Point(6, 145);
            lblOncekiEnduktif.Name = "lblOncekiEnduktif";
            lblOncekiEnduktif.Size = new Size(170, 15);
            lblOncekiEnduktif.TabIndex = 14;
            lblOncekiEnduktif.Text = "Önceki Yazan Enduktif Tüketim";
            // 
            // txtOncekiAktif
            // 
            txtOncekiAktif.Location = new Point(208, 107);
            txtOncekiAktif.Name = "txtOncekiAktif";
            txtOncekiAktif.Size = new Size(200, 23);
            txtOncekiAktif.TabIndex = 13;
            // 
            // lblOncekiAktif
            // 
            lblOncekiAktif.AutoSize = true;
            lblOncekiAktif.Location = new Point(6, 110);
            lblOncekiAktif.Name = "lblOncekiAktif";
            lblOncekiAktif.Size = new Size(151, 15);
            lblOncekiAktif.TabIndex = 12;
            lblOncekiAktif.Text = "Önceki Yazan Aktif Tüketim";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Gray;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(442, 174);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(374, 35);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(168, 62);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(240, 23);
            dtpTarih.TabIndex = 3;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(20, 65);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(35, 15);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih:";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.SeaGreen;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(442, 128);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(374, 40);
            btnHesapla.TabIndex = 10;
            btnHesapla.Text = "Hesapla ve Kaydet";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // cmbSirket
            // 
            cmbSirket.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSirket.FormattingEnabled = true;
            cmbSirket.Location = new Point(168, 27);
            cmbSirket.Name = "cmbSirket";
            cmbSirket.Size = new Size(240, 23);
            cmbSirket.TabIndex = 1;
            // 
            // lblSirket
            // 
            lblSirket.AutoSize = true;
            lblSirket.Location = new Point(20, 30);
            lblSirket.Name = "lblSirket";
            lblSirket.Size = new Size(39, 15);
            lblSirket.TabIndex = 0;
            lblSirket.Text = "Şirket:";
            // 
            // txtKapasitif
            // 
            txtKapasitif.Location = new Point(616, 97);
            txtKapasitif.Name = "txtKapasitif";
            txtKapasitif.Size = new Size(200, 23);
            txtKapasitif.TabIndex = 9;
            // 
            // lblAktif
            // 
            lblAktif.AutoSize = true;
            lblAktif.Location = new Point(442, 29);
            lblAktif.Name = "lblAktif";
            lblAktif.Size = new Size(121, 15);
            lblAktif.TabIndex = 4;
            lblAktif.Text = "Mevcut Aktif Tüketim";
            // 
            // lblEnduktif
            // 
            lblEnduktif.AutoSize = true;
            lblEnduktif.Location = new Point(442, 64);
            lblEnduktif.Name = "lblEnduktif";
            lblEnduktif.Size = new Size(140, 15);
            lblEnduktif.TabIndex = 6;
            lblEnduktif.Text = "Mevcut Enduktif Tüketim";
            // 
            // txtEnduktif
            // 
            txtEnduktif.Location = new Point(616, 62);
            txtEnduktif.Name = "txtEnduktif";
            txtEnduktif.Size = new Size(200, 23);
            txtEnduktif.TabIndex = 8;
            // 
            // lblKapasitif
            // 
            lblKapasitif.AutoSize = true;
            lblKapasitif.Location = new Point(442, 99);
            lblKapasitif.Name = "lblKapasitif";
            lblKapasitif.Size = new Size(141, 15);
            lblKapasitif.TabIndex = 7;
            lblKapasitif.Text = "Mevcut Kapasitif Tüketim";
            // 
            // txtAktif
            // 
            txtAktif.Location = new Point(616, 27);
            txtAktif.Name = "txtAktif";
            txtAktif.Size = new Size(200, 23);
            txtAktif.TabIndex = 5;
            // 
            // gbOranSonuclari
            // 
            gbOranSonuclari.Controls.Add(lblKapasitifLimit);
            gbOranSonuclari.Controls.Add(lblEnduktifLimit);
            gbOranSonuclari.Controls.Add(lblKapasitifOran);
            gbOranSonuclari.Controls.Add(lblEnduktifOran);
            gbOranSonuclari.Location = new Point(527, 244);
            gbOranSonuclari.Name = "gbOranSonuclari";
            gbOranSonuclari.Size = new Size(301, 104);
            gbOranSonuclari.TabIndex = 1;
            gbOranSonuclari.TabStop = false;
            gbOranSonuclari.Text = "Oran Sonuçları";
            // 
            // lblKapasitifLimit
            // 
            lblKapasitifLimit.AutoSize = true;
            lblKapasitifLimit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKapasitifLimit.ForeColor = Color.DarkGray;
            lblKapasitifLimit.Location = new Point(196, 70);
            lblKapasitifLimit.Name = "lblKapasitifLimit";
            lblKapasitifLimit.Size = new Size(70, 15);
            lblKapasitifLimit.TabIndex = 3;
            lblKapasitifLimit.Text = "(Limit: %15)";
            // 
            // lblEnduktifLimit
            // 
            lblEnduktifLimit.AutoSize = true;
            lblEnduktifLimit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEnduktifLimit.ForeColor = Color.DarkGray;
            lblEnduktifLimit.Location = new Point(196, 30);
            lblEnduktifLimit.Name = "lblEnduktifLimit";
            lblEnduktifLimit.Size = new Size(70, 15);
            lblEnduktifLimit.TabIndex = 2;
            lblEnduktifLimit.Text = "(Limit: %20)";
            // 
            // lblKapasitifOran
            // 
            lblKapasitifOran.AutoSize = true;
            lblKapasitifOran.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKapasitifOran.ForeColor = Color.Navy;
            lblKapasitifOran.Location = new Point(19, 65);
            lblKapasitifOran.Name = "lblKapasitifOran";
            lblKapasitifOran.Size = new Size(171, 21);
            lblKapasitifOran.TabIndex = 1;
            lblKapasitifOran.Text = "Kapasitif Oran: %0,00";
            // 
            // lblEnduktifOran
            // 
            lblEnduktifOran.AutoSize = true;
            lblEnduktifOran.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEnduktifOran.ForeColor = Color.Navy;
            lblEnduktifOran.Location = new Point(19, 25);
            lblEnduktifOran.Name = "lblEnduktifOran";
            lblEnduktifOran.Size = new Size(169, 21);
            lblEnduktifOran.TabIndex = 0;
            lblEnduktifOran.Text = "Endüktif Oran: %0,00";
            // 
            // gbCezaDurumu
            // 
            gbCezaDurumu.Controls.Add(lblCezaDurumuSonuc);
            gbCezaDurumu.Location = new Point(834, 31);
            gbCezaDurumu.Name = "gbCezaDurumu";
            gbCezaDurumu.Size = new Size(280, 134);
            gbCezaDurumu.TabIndex = 2;
            gbCezaDurumu.TabStop = false;
            gbCezaDurumu.Text = "Ceza Durumu";
            // 
            // lblCezaDurumuSonuc
            // 
            lblCezaDurumuSonuc.AutoSize = true;
            lblCezaDurumuSonuc.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCezaDurumuSonuc.ForeColor = Color.Green;
            lblCezaDurumuSonuc.Location = new Point(87, 56);
            lblCezaDurumuSonuc.Name = "lblCezaDurumuSonuc";
            lblCezaDurumuSonuc.Size = new Size(113, 30);
            lblCezaDurumuSonuc.TabIndex = 0;
            lblCezaDurumuSonuc.Text = "CEZA YOK";
            // 
            // dgvHesaplamalar
            // 
            dgvHesaplamalar.AllowUserToAddRows = false;
            dgvHesaplamalar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHesaplamalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHesaplamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHesaplamalar.Location = new Point(0, 366);
            dgvHesaplamalar.MultiSelect = false;
            dgvHesaplamalar.Name = "dgvHesaplamalar";
            dgvHesaplamalar.ReadOnly = true;
            dgvHesaplamalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHesaplamalar.Size = new Size(1350, 363);
            dgvHesaplamalar.TabIndex = 3;
            // 
            // btnPdfRapor
            // 
            btnPdfRapor.BackColor = Color.Crimson;
            btnPdfRapor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfRapor.ForeColor = Color.White;
            btnPdfRapor.Location = new Point(1120, 31);
            btnPdfRapor.Name = "btnPdfRapor";
            btnPdfRapor.Size = new Size(230, 50);
            btnPdfRapor.TabIndex = 4;
            btnPdfRapor.Text = "Pdf Rapor Oluştur";
            btnPdfRapor.UseVisualStyleBackColor = false;
            btnPdfRapor.Click += btnPdfRapor_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkRed;
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(1120, 143);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(230, 50);
            btnSil.TabIndex = 5;
            btnSil.Text = "Seçili Kaydı Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.DodgerBlue;
            btnYenile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(1120, 199);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(230, 50);
            btnYenile.TabIndex = 7;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.SlateGray;
            btnKapat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(1120, 251);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(230, 50);
            btnKapat.TabIndex = 8;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnExcelAktar
            // 
            btnExcelAktar.BackColor = Color.Coral;
            btnExcelAktar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExcelAktar.ForeColor = Color.White;
            btnExcelAktar.Location = new Point(1120, 87);
            btnExcelAktar.Name = "btnExcelAktar";
            btnExcelAktar.Size = new Size(230, 50);
            btnExcelAktar.TabIndex = 9;
            btnExcelAktar.Text = "Excel'e Aktar";
            btnExcelAktar.UseVisualStyleBackColor = false;
            btnExcelAktar.Click += btnExcelAktar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbSirketFiltrele);
            groupBox1.Controls.Add(btnFiltreyiTemizle);
            groupBox1.Controls.Add(btnFiltrele);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Location = new Point(834, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 183);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreleme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 36);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Şirket Adı:";
            // 
            // cmbSirketFiltrele
            // 
            cmbSirketFiltrele.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSirketFiltrele.FormattingEnabled = true;
            cmbSirketFiltrele.Location = new Point(97, 32);
            cmbSirketFiltrele.Name = "cmbSirketFiltrele";
            cmbSirketFiltrele.Size = new Size(168, 23);
            cmbSirketFiltrele.TabIndex = 8;
            // 
            // btnFiltreyiTemizle
            // 
            btnFiltreyiTemizle.BackColor = Color.Red;
            btnFiltreyiTemizle.ForeColor = Color.White;
            btnFiltreyiTemizle.Location = new Point(148, 119);
            btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            btnFiltreyiTemizle.Size = new Size(100, 51);
            btnFiltreyiTemizle.TabIndex = 5;
            btnFiltreyiTemizle.Text = "Filtreyi Temizle";
            btnFiltreyiTemizle.UseVisualStyleBackColor = false;
            btnFiltreyiTemizle.Click += btnFiltreyiTemizle_Click;
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackColor = Color.DarkGreen;
            btnFiltrele.ForeColor = Color.White;
            btnFiltrele.Location = new Point(19, 119);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(100, 51);
            btnFiltrele.TabIndex = 4;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 96);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Bitiş Tarihi:";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(148, 90);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(117, 23);
            dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(148, 61);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(117, 23);
            dtpBaslangic.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 256);
            label3.Name = "label3";
            label3.Size = new Size(501, 74);
            label3.TabIndex = 11;
            label3.Text = "Önceki yazan aktif tüketime tablodaki\r\nen son satıra çift tıklayarak ulaşabilirsiniz.";
            // 
            // FrmHesaplamalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(btnExcelAktar);
            Controls.Add(btnKapat);
            Controls.Add(btnYenile);
            Controls.Add(btnSil);
            Controls.Add(btnPdfRapor);
            Controls.Add(dgvHesaplamalar);
            Controls.Add(gbCezaDurumu);
            Controls.Add(gbOranSonuclari);
            Controls.Add(gbVeriGirisi);
            Name = "FrmHesaplamalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kompanzasyon Hesaplamaları";
            WindowState = FormWindowState.Maximized;
            gbVeriGirisi.ResumeLayout(false);
            gbVeriGirisi.PerformLayout();
            gbOranSonuclari.ResumeLayout(false);
            gbOranSonuclari.PerformLayout();
            gbCezaDurumu.ResumeLayout(false);
            gbCezaDurumu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHesaplamalar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbVeriGirisi;
        private DateTimePicker dtpTarih;
        private Label lblTarih;
        private ComboBox cmbSirket;
        private Label lblSirket;
        private Button btnTemizle;
        private Button btnHesapla;
        private TextBox txtKapasitif;
        private TextBox txtEnduktif;
        private Label lblKapasitif;
        private Label lblEnduktif;
        private TextBox txtAktif;
        private Label lblAktif;
        private GroupBox gbOranSonuclari;
        private Label lblKapasitifOran;
        private Label lblEnduktifOran;
        private Label lblKapasitifLimit;
        private Label lblEnduktifLimit;
        private GroupBox gbCezaDurumu;
        private Label lblCezaDurumuSonuc;
        private DataGridView dgvHesaplamalar;
        private Button btnPdfRapor;
        private Button btnSil;
        private Button btnYenile;
        private Button btnKapat;
        private Button btnExcelAktar;
        private GroupBox groupBox1;
        private Button btnFiltreyiTemizle;
        private Button btnFiltrele;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private TextBox txtOncekiKpstfTuketim;
        private TextBox txtOncekiEnduktif;
        private Label lblOncekiKpstfTuketim;
        private Label lblOncekiEnduktif;
        private TextBox txtOncekiAktif;
        private Label lblOncekiAktif;
        private Label label3;
        private Label label4;
        private ComboBox cmbSirketFiltrele;
    }
}