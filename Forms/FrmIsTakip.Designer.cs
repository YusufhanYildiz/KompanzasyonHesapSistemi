namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmIsTakip
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
            gbIsBilgileri = new GroupBox();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            txtAlinanTutar = new TextBox();
            txtIsUcreti = new TextBox();
            lblAlinanTutar = new Label();
            lblIsUcreti = new Label();
            lblBakiyeGoster = new Label();
            lblIsAciklamasi = new Label();
            dtpTarih = new DateTimePicker();
            txtIsAciklamasi = new TextBox();
            lblTarih = new Label();
            cmbSirket = new ComboBox();
            lblSirketSecim = new Label();
            gbOzetBilgiler = new GroupBox();
            btnOzetRapor = new Button();
            lblToplamBakiye = new Label();
            lblToplamAlinan = new Label();
            lblToplamIsUcreti = new Label();
            lblToplamIsSayisi = new Label();
            dgvIsler = new DataGridView();
            btnSil = new Button();
            btnYenile = new Button();
            btnKapat = new Button();
            btnExcelAktar = new Button();
            groupBox1 = new GroupBox();
            lblSirket = new Label();
            cmbSirketFiltrele = new ComboBox();
            btnFiltreyiTemizle = new Button();
            btnFiltrele = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            groupBox2 = new GroupBox();
            gbIsBilgileri.SuspendLayout();
            gbOzetBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIsler).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gbIsBilgileri
            // 
            gbIsBilgileri.Controls.Add(btnTemizle);
            gbIsBilgileri.Controls.Add(btnGuncelle);
            gbIsBilgileri.Controls.Add(btnKaydet);
            gbIsBilgileri.Controls.Add(txtAlinanTutar);
            gbIsBilgileri.Controls.Add(txtIsUcreti);
            gbIsBilgileri.Controls.Add(lblAlinanTutar);
            gbIsBilgileri.Controls.Add(lblIsUcreti);
            gbIsBilgileri.Controls.Add(lblBakiyeGoster);
            gbIsBilgileri.Controls.Add(lblIsAciklamasi);
            gbIsBilgileri.Controls.Add(dtpTarih);
            gbIsBilgileri.Controls.Add(txtIsAciklamasi);
            gbIsBilgileri.Controls.Add(lblTarih);
            gbIsBilgileri.Controls.Add(cmbSirket);
            gbIsBilgileri.Controls.Add(lblSirketSecim);
            gbIsBilgileri.Location = new Point(20, 20);
            gbIsBilgileri.Name = "gbIsBilgileri";
            gbIsBilgileri.Size = new Size(400, 280);
            gbIsBilgileri.TabIndex = 0;
            gbIsBilgileri.TabStop = false;
            gbIsBilgileri.Text = "İş Bilgileri";
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.None;
            btnTemizle.BackColor = Color.Gray;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(260, 240);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(110, 35);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.None;
            btnGuncelle.BackColor = Color.DodgerBlue;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(140, 240);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 35);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.None;
            btnKaydet.BackColor = Color.SeaGreen;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(20, 240);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(110, 35);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAlinanTutar
            // 
            txtAlinanTutar.Anchor = AnchorStyles.None;
            txtAlinanTutar.Location = new Point(120, 115);
            txtAlinanTutar.Name = "txtAlinanTutar";
            txtAlinanTutar.Size = new Size(250, 23);
            txtAlinanTutar.TabIndex = 7;
            // 
            // txtIsUcreti
            // 
            txtIsUcreti.Anchor = AnchorStyles.None;
            txtIsUcreti.Location = new Point(120, 86);
            txtIsUcreti.Name = "txtIsUcreti";
            txtIsUcreti.Size = new Size(250, 23);
            txtIsUcreti.TabIndex = 6;
            // 
            // lblAlinanTutar
            // 
            lblAlinanTutar.Anchor = AnchorStyles.None;
            lblAlinanTutar.AutoSize = true;
            lblAlinanTutar.Location = new Point(20, 123);
            lblAlinanTutar.Name = "lblAlinanTutar";
            lblAlinanTutar.Size = new Size(88, 15);
            lblAlinanTutar.TabIndex = 5;
            lblAlinanTutar.Text = "Alınan Tutar(₺):";
            // 
            // lblIsUcreti
            // 
            lblIsUcreti.Anchor = AnchorStyles.None;
            lblIsUcreti.AutoSize = true;
            lblIsUcreti.Location = new Point(20, 94);
            lblIsUcreti.Name = "lblIsUcreti";
            lblIsUcreti.Size = new Size(66, 15);
            lblIsUcreti.TabIndex = 4;
            lblIsUcreti.Text = "İş Ücreti(₺):";
            // 
            // lblBakiyeGoster
            // 
            lblBakiyeGoster.Anchor = AnchorStyles.None;
            lblBakiyeGoster.AutoSize = true;
            lblBakiyeGoster.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBakiyeGoster.ForeColor = Color.Navy;
            lblBakiyeGoster.Location = new Point(20, 210);
            lblBakiyeGoster.Name = "lblBakiyeGoster";
            lblBakiyeGoster.Size = new Size(109, 21);
            lblBakiyeGoster.TabIndex = 4;
            lblBakiyeGoster.Text = "Bakiye: ₺0,00";
            // 
            // lblIsAciklamasi
            // 
            lblIsAciklamasi.Anchor = AnchorStyles.None;
            lblIsAciklamasi.AutoSize = true;
            lblIsAciklamasi.Location = new Point(20, 152);
            lblIsAciklamasi.Name = "lblIsAciklamasi";
            lblIsAciklamasi.Size = new Size(78, 15);
            lblIsAciklamasi.TabIndex = 3;
            lblIsAciklamasi.Text = "İş Açıklaması:";
            // 
            // dtpTarih
            // 
            dtpTarih.Anchor = AnchorStyles.None;
            dtpTarih.Location = new Point(120, 22);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 23);
            dtpTarih.TabIndex = 2;
            // 
            // txtIsAciklamasi
            // 
            txtIsAciklamasi.Anchor = AnchorStyles.None;
            txtIsAciklamasi.Location = new Point(120, 144);
            txtIsAciklamasi.Multiline = true;
            txtIsAciklamasi.Name = "txtIsAciklamasi";
            txtIsAciklamasi.Size = new Size(250, 57);
            txtIsAciklamasi.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.Anchor = AnchorStyles.None;
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(20, 28);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(35, 15);
            lblTarih.TabIndex = 0;
            lblTarih.Text = "Tarih:";
            // 
            // cmbSirket
            // 
            cmbSirket.Anchor = AnchorStyles.None;
            cmbSirket.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSirket.FormattingEnabled = true;
            cmbSirket.Location = new Point(120, 57);
            cmbSirket.Name = "cmbSirket";
            cmbSirket.Size = new Size(250, 23);
            cmbSirket.TabIndex = 2;
            // 
            // lblSirketSecim
            // 
            lblSirketSecim.Anchor = AnchorStyles.None;
            lblSirketSecim.AutoSize = true;
            lblSirketSecim.Location = new Point(20, 60);
            lblSirketSecim.Name = "lblSirketSecim";
            lblSirketSecim.Size = new Size(39, 15);
            lblSirketSecim.TabIndex = 0;
            lblSirketSecim.Text = "Şirket:";
            // 
            // gbOzetBilgiler
            // 
            gbOzetBilgiler.Controls.Add(btnOzetRapor);
            gbOzetBilgiler.Controls.Add(lblToplamBakiye);
            gbOzetBilgiler.Controls.Add(lblToplamAlinan);
            gbOzetBilgiler.Controls.Add(lblToplamIsUcreti);
            gbOzetBilgiler.Controls.Add(lblToplamIsSayisi);
            gbOzetBilgiler.Location = new Point(440, 27);
            gbOzetBilgiler.Name = "gbOzetBilgiler";
            gbOzetBilgiler.Size = new Size(420, 280);
            gbOzetBilgiler.TabIndex = 1;
            gbOzetBilgiler.TabStop = false;
            gbOzetBilgiler.Text = "Özet Bilgiler";
            // 
            // btnOzetRapor
            // 
            btnOzetRapor.Anchor = AnchorStyles.None;
            btnOzetRapor.BackColor = Color.DarkOrange;
            btnOzetRapor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOzetRapor.ForeColor = Color.White;
            btnOzetRapor.Location = new Point(20, 200);
            btnOzetRapor.Name = "btnOzetRapor";
            btnOzetRapor.Size = new Size(380, 50);
            btnOzetRapor.TabIndex = 4;
            btnOzetRapor.Text = "Özet Rapor Al";
            btnOzetRapor.UseVisualStyleBackColor = false;
            btnOzetRapor.Click += btnOzetRapor_Click;
            // 
            // lblToplamBakiye
            // 
            lblToplamBakiye.Anchor = AnchorStyles.None;
            lblToplamBakiye.AutoSize = true;
            lblToplamBakiye.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamBakiye.ForeColor = Color.Crimson;
            lblToplamBakiye.Location = new Point(20, 140);
            lblToplamBakiye.Name = "lblToplamBakiye";
            lblToplamBakiye.Size = new Size(244, 30);
            lblToplamBakiye.TabIndex = 3;
            lblToplamBakiye.Text = "TOPLAM BAKİYE: ₺0,00";
            // 
            // lblToplamAlinan
            // 
            lblToplamAlinan.Anchor = AnchorStyles.None;
            lblToplamAlinan.AutoSize = true;
            lblToplamAlinan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamAlinan.Location = new Point(20, 90);
            lblToplamAlinan.Name = "lblToplamAlinan";
            lblToplamAlinan.Size = new Size(147, 20);
            lblToplamAlinan.TabIndex = 2;
            lblToplamAlinan.Text = "Toplam Alınan: ₺0,00";
            // 
            // lblToplamIsUcreti
            // 
            lblToplamIsUcreti.Anchor = AnchorStyles.None;
            lblToplamIsUcreti.AutoSize = true;
            lblToplamIsUcreti.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamIsUcreti.Location = new Point(20, 60);
            lblToplamIsUcreti.Name = "lblToplamIsUcreti";
            lblToplamIsUcreti.Size = new Size(158, 20);
            lblToplamIsUcreti.TabIndex = 1;
            lblToplamIsUcreti.Text = "Toplam İş Ücreti: ₺0,00";
            // 
            // lblToplamIsSayisi
            // 
            lblToplamIsSayisi.Anchor = AnchorStyles.None;
            lblToplamIsSayisi.AutoSize = true;
            lblToplamIsSayisi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamIsSayisi.Location = new Point(20, 30);
            lblToplamIsSayisi.Name = "lblToplamIsSayisi";
            lblToplamIsSayisi.Size = new Size(88, 20);
            lblToplamIsSayisi.TabIndex = 0;
            lblToplamIsSayisi.Text = "Toplam İş: 0";
            // 
            // dgvIsler
            // 
            dgvIsler.AllowUserToAddRows = false;
            dgvIsler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIsler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIsler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIsler.Location = new Point(12, 320);
            dgvIsler.MultiSelect = false;
            dgvIsler.Name = "dgvIsler";
            dgvIsler.ReadOnly = true;
            dgvIsler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIsler.Size = new Size(944, 280);
            dgvIsler.TabIndex = 2;
            dgvIsler.CellClick += dgvIsler_CellClick;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.None;
            btnSil.BackColor = Color.Crimson;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(8, 22);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Seçili İşi Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.Anchor = AnchorStyles.None;
            btnYenile.BackColor = Color.DodgerBlue;
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(8, 114);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(140, 40);
            btnYenile.TabIndex = 4;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.None;
            btnKapat.BackColor = Color.SlateGray;
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(8, 234);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(140, 40);
            btnKapat.TabIndex = 5;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnExcelAktar
            // 
            btnExcelAktar.Anchor = AnchorStyles.None;
            btnExcelAktar.BackColor = Color.DarkGreen;
            btnExcelAktar.ForeColor = Color.White;
            btnExcelAktar.Location = new Point(8, 68);
            btnExcelAktar.Name = "btnExcelAktar";
            btnExcelAktar.Size = new Size(140, 40);
            btnExcelAktar.TabIndex = 6;
            btnExcelAktar.Text = "Excel'e Aktar";
            btnExcelAktar.UseVisualStyleBackColor = false;
            btnExcelAktar.Click += btnExcelAktar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSirket);
            groupBox1.Controls.Add(cmbSirketFiltrele);
            groupBox1.Controls.Add(btnFiltreyiTemizle);
            groupBox1.Controls.Add(btnFiltrele);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Location = new Point(866, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 194);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreleme";
            // 
            // lblSirket
            // 
            lblSirket.Anchor = AnchorStyles.None;
            lblSirket.AutoSize = true;
            lblSirket.Location = new Point(19, 28);
            lblSirket.Name = "lblSirket";
            lblSirket.Size = new Size(60, 15);
            lblSirket.TabIndex = 7;
            lblSirket.Text = "Şirket Adı:";
            // 
            // cmbSirketFiltrele
            // 
            cmbSirketFiltrele.Anchor = AnchorStyles.None;
            cmbSirketFiltrele.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSirketFiltrele.FormattingEnabled = true;
            cmbSirketFiltrele.Location = new Point(97, 24);
            cmbSirketFiltrele.Name = "cmbSirketFiltrele";
            cmbSirketFiltrele.Size = new Size(168, 23);
            cmbSirketFiltrele.TabIndex = 6;
            // 
            // btnFiltreyiTemizle
            // 
            btnFiltreyiTemizle.Anchor = AnchorStyles.None;
            btnFiltreyiTemizle.BackColor = Color.Red;
            btnFiltreyiTemizle.ForeColor = Color.White;
            btnFiltreyiTemizle.Location = new Point(148, 125);
            btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            btnFiltreyiTemizle.Size = new Size(100, 55);
            btnFiltreyiTemizle.TabIndex = 5;
            btnFiltreyiTemizle.Text = "Filtreyi Temizle";
            btnFiltreyiTemizle.UseVisualStyleBackColor = false;
            btnFiltreyiTemizle.Click += btnFiltreyiTemizle_Click;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Anchor = AnchorStyles.None;
            btnFiltrele.BackColor = Color.DarkGreen;
            btnFiltrele.ForeColor = Color.White;
            btnFiltrele.Location = new Point(19, 125);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(100, 55);
            btnFiltrele.TabIndex = 4;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(19, 90);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Bitiş Tarihi:";
            // 
            // dtpBitis
            // 
            dtpBitis.Anchor = AnchorStyles.None;
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(148, 84);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(117, 23);
            dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Anchor = AnchorStyles.None;
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(148, 55);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(117, 23);
            dtpBaslangic.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnExcelAktar);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnYenile);
            groupBox2.Controls.Add(btnKapat);
            groupBox2.Location = new Point(968, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 280);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // FrmIsTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvIsler);
            Controls.Add(gbOzetBilgiler);
            Controls.Add(gbIsBilgileri);
            Name = "FrmIsTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İş Takip Sistemi";
            gbIsBilgileri.ResumeLayout(false);
            gbIsBilgileri.PerformLayout();
            gbOzetBilgiler.ResumeLayout(false);
            gbOzetBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIsler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbIsBilgileri;
        private Label lblAlinanTutar;
        private Label lblIsUcreti;
        private Label lblBakiyeGoster;
        private Label lblIsAciklamasi;
        private DateTimePicker dtpTarih;
        private TextBox txtIsAciklamasi;
        private Label lblTarih;
        private TextBox txtIsUcreti;
        private TextBox txtAlinanTutar;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnKaydet;
        private GroupBox gbOzetBilgiler;
        private Button btnOzetRapor;
        private Label lblToplamBakiye;
        private Label lblToplamAlinan;
        private Label lblToplamIsUcreti;
        private Label lblToplamIsSayisi;
        private DataGridView dgvIsler;
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
        private GroupBox groupBox2;
        private ComboBox cmbSirketFiltrele;
        private Label lblSirket;
        private ComboBox cmbSirket;
        private Label lblSirketSecim;
    }
}