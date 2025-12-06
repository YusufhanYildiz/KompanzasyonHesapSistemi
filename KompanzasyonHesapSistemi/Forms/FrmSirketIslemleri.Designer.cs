namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmSirketIslemleri
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
            gbSirketBilgileri = new GroupBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            lblTelefon = new Label();
            lblAdres = new Label();
            lblVergiNo = new Label();
            lblSirketAdi = new Label();
            txtVergiNo = new TextBox();
            txtSirketAdi = new TextBox();
            btnYeniSirket = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgvSirketler = new DataGridView();
            btnKapat = new Button();
            gbSirketBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSirketler).BeginInit();
            SuspendLayout();
            // 
            // gbSirketBilgileri
            // 
            gbSirketBilgileri.Controls.Add(txtAdres);
            gbSirketBilgileri.Controls.Add(txtTelefon);
            gbSirketBilgileri.Controls.Add(lblTelefon);
            gbSirketBilgileri.Controls.Add(lblAdres);
            gbSirketBilgileri.Controls.Add(lblVergiNo);
            gbSirketBilgileri.Controls.Add(lblSirketAdi);
            gbSirketBilgileri.Controls.Add(txtVergiNo);
            gbSirketBilgileri.Controls.Add(txtSirketAdi);
            gbSirketBilgileri.Location = new Point(20, 20);
            gbSirketBilgileri.Name = "gbSirketBilgileri";
            gbSirketBilgileri.Size = new Size(350, 250);
            gbSirketBilgileri.TabIndex = 0;
            gbSirketBilgileri.TabStop = false;
            gbSirketBilgileri.Tag = "";
            gbSirketBilgileri.Text = "Şirket Bilgileri";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(120, 132);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(200, 70);
            txtAdres.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(120, 97);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 8;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(20, 100);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(48, 15);
            lblTelefon.TabIndex = 7;
            lblTelefon.Text = "Telefon:";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(20, 135);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 6;
            lblAdres.Text = "Adres:";
            // 
            // lblVergiNo
            // 
            lblVergiNo.AutoSize = true;
            lblVergiNo.Location = new Point(20, 65);
            lblVergiNo.Name = "lblVergiNo";
            lblVergiNo.Size = new Size(55, 15);
            lblVergiNo.TabIndex = 5;
            lblVergiNo.Text = "Vergi No:";
            // 
            // lblSirketAdi
            // 
            lblSirketAdi.AutoSize = true;
            lblSirketAdi.Location = new Point(20, 30);
            lblSirketAdi.Name = "lblSirketAdi";
            lblSirketAdi.Size = new Size(60, 15);
            lblSirketAdi.TabIndex = 4;
            lblSirketAdi.Text = "Şirket Adı:";
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(120, 62);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(200, 23);
            txtVergiNo.TabIndex = 1;
            // 
            // txtSirketAdi
            // 
            txtSirketAdi.Location = new Point(120, 27);
            txtSirketAdi.Name = "txtSirketAdi";
            txtSirketAdi.Size = new Size(200, 23);
            txtSirketAdi.TabIndex = 0;
            // 
            // btnYeniSirket
            // 
            btnYeniSirket.BackColor = Color.SeaGreen;
            btnYeniSirket.ForeColor = Color.White;
            btnYeniSirket.Location = new Point(20, 280);
            btnYeniSirket.Name = "btnYeniSirket";
            btnYeniSirket.Size = new Size(160, 40);
            btnYeniSirket.TabIndex = 1;
            btnYeniSirket.Text = "Yeni Şirket Ekle";
            btnYeniSirket.UseVisualStyleBackColor = false;
            btnYeniSirket.Click += btnYeniSirket_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DodgerBlue;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(190, 280);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 40);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(290, 280);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Gray;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(20, 330);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(350, 35);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvSirketler
            // 
            dgvSirketler.AllowUserToAddRows = false;
            dgvSirketler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSirketler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSirketler.Location = new Point(400, 20);
            dgvSirketler.MultiSelect = false;
            dgvSirketler.Name = "dgvSirketler";
            dgvSirketler.ReadOnly = true;
            dgvSirketler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSirketler.Size = new Size(370, 520);
            dgvSirketler.TabIndex = 5;
            dgvSirketler.CellClick += dgvSirketler_CellClick;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.SlateGray;
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(20, 520);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(350, 40);
            btnKapat.TabIndex = 6;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += button1_Click;
            // 
            // FrmSirketIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnKapat);
            Controls.Add(dgvSirketler);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnYeniSirket);
            Controls.Add(gbSirketBilgileri);
            Name = "FrmSirketIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şirket İşlemleri";
            gbSirketBilgileri.ResumeLayout(false);
            gbSirketBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSirketler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSirketBilgileri;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private Label lblTelefon;
        private Label lblAdres;
        private Label lblVergiNo;
        private Label lblSirketAdi;
        private TextBox txtVergiNo;
        private TextBox txtSirketAdi;
        private Button btnYeniSirket;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private DataGridView dgvSirketler;
        private Button btnKapat;
    }
}