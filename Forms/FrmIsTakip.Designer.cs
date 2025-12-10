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
            gbIsBilgileri.SuspendLayout();
            gbOzetBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIsler).BeginInit();
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
            gbIsBilgileri.Location = new Point(20, 20);
            gbIsBilgileri.Name = "gbIsBilgileri";
            gbIsBilgileri.Size = new Size(400, 280);
            gbIsBilgileri.TabIndex = 0;
            gbIsBilgileri.TabStop = false;
            gbIsBilgileri.Text = "İş Bilgileri";
            // 
            // btnTemizle
            // 
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
            txtAlinanTutar.Location = new Point(120, 167);
            txtAlinanTutar.Name = "txtAlinanTutar";
            txtAlinanTutar.Size = new Size(250, 23);
            txtAlinanTutar.TabIndex = 7;
            // 
            // txtIsUcreti
            // 
            txtIsUcreti.Location = new Point(120, 132);
            txtIsUcreti.Name = "txtIsUcreti";
            txtIsUcreti.Size = new Size(250, 23);
            txtIsUcreti.TabIndex = 6;
            // 
            // lblAlinanTutar
            // 
            lblAlinanTutar.AutoSize = true;
            lblAlinanTutar.Location = new Point(20, 170);
            lblAlinanTutar.Name = "lblAlinanTutar";
            lblAlinanTutar.Size = new Size(88, 15);
            lblAlinanTutar.TabIndex = 5;
            lblAlinanTutar.Text = "Alınan Tutar(₺):";
            // 
            // lblIsUcreti
            // 
            lblIsUcreti.AutoSize = true;
            lblIsUcreti.Location = new Point(20, 135);
            lblIsUcreti.Name = "lblIsUcreti";
            lblIsUcreti.Size = new Size(66, 15);
            lblIsUcreti.TabIndex = 4;
            lblIsUcreti.Text = "İş Ücreti(₺):";
            // 
            // lblBakiyeGoster
            // 
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
            lblIsAciklamasi.AutoSize = true;
            lblIsAciklamasi.Location = new Point(20, 65);
            lblIsAciklamasi.Name = "lblIsAciklamasi";
            lblIsAciklamasi.Size = new Size(78, 15);
            lblIsAciklamasi.TabIndex = 3;
            lblIsAciklamasi.Text = "İş Açıklaması:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(120, 27);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 23);
            dtpTarih.TabIndex = 2;
            // 
            // txtIsAciklamasi
            // 
            txtIsAciklamasi.Location = new Point(120, 62);
            txtIsAciklamasi.Multiline = true;
            txtIsAciklamasi.Name = "txtIsAciklamasi";
            txtIsAciklamasi.Size = new Size(250, 60);
            txtIsAciklamasi.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(20, 30);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(35, 15);
            lblTarih.TabIndex = 0;
            lblTarih.Text = "Tarih:";
            // 
            // gbOzetBilgiler
            // 
            gbOzetBilgiler.Controls.Add(btnOzetRapor);
            gbOzetBilgiler.Controls.Add(lblToplamBakiye);
            gbOzetBilgiler.Controls.Add(lblToplamAlinan);
            gbOzetBilgiler.Controls.Add(lblToplamIsUcreti);
            gbOzetBilgiler.Controls.Add(lblToplamIsSayisi);
            gbOzetBilgiler.Location = new Point(440, 20);
            gbOzetBilgiler.Name = "gbOzetBilgiler";
            gbOzetBilgiler.Size = new Size(420, 280);
            gbOzetBilgiler.TabIndex = 1;
            gbOzetBilgiler.TabStop = false;
            gbOzetBilgiler.Text = "Özet Bilgiler";
            // 
            // btnOzetRapor
            // 
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
            dgvIsler.Size = new Size(880, 280);
            dgvIsler.TabIndex = 2;
            dgvIsler.CellClick += dgvIsler_CellClick;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(909, 320);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Seçili İşi Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.DodgerBlue;
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(909, 412);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(140, 40);
            btnYenile.TabIndex = 4;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.SlateGray;
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(909, 549);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(140, 40);
            btnKapat.TabIndex = 5;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnExcelAktar
            // 
            btnExcelAktar.BackColor = Color.DarkGreen;
            btnExcelAktar.ForeColor = Color.White;
            btnExcelAktar.Location = new Point(909, 366);
            btnExcelAktar.Name = "btnExcelAktar";
            btnExcelAktar.Size = new Size(140, 40);
            btnExcelAktar.TabIndex = 6;
            btnExcelAktar.Text = "Excel'e Aktar";
            btnExcelAktar.UseVisualStyleBackColor = false;
            btnExcelAktar.Click += btnExcelAktar_Click;
            // 
            // FrmIsTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(btnExcelAktar);
            Controls.Add(btnKapat);
            Controls.Add(btnYenile);
            Controls.Add(btnSil);
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
    }
}