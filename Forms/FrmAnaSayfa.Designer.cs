namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmAnaSayfa
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
            components = new System.ComponentModel.Container();
            pnlUst = new Panel();
            btnCikis = new Button();
            lblTarihSaat = new Label();
            lblHosgeldiniz = new Label();
            pnlMenu = new Panel();
            btnIletisim = new Button();
            btnSifreDegistir = new Button();
            btnYedekleme = new Button();
            btnDashboard = new Button();
            btnIsTakip = new Button();
            btnHesaplamalar = new Button();
            btnSirketler = new Button();
            pnlIcerik = new Panel();
            lblMesaj = new Label();
            timerSaat = new System.Windows.Forms.Timer(components);
            pnlUst.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlIcerik.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.DodgerBlue;
            pnlUst.Controls.Add(btnCikis);
            pnlUst.Controls.Add(lblTarihSaat);
            pnlUst.Controls.Add(lblHosgeldiniz);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(1332, 80);
            pnlUst.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.BackColor = Color.Crimson;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1228, 20);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 40);
            btnCikis.TabIndex = 2;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblTarihSaat
            // 
            lblTarihSaat.AutoSize = true;
            lblTarihSaat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTarihSaat.ForeColor = Color.White;
            lblTarihSaat.Location = new Point(20, 45);
            lblTarihSaat.Name = "lblTarihSaat";
            lblTarihSaat.Size = new Size(65, 17);
            lblTarihSaat.TabIndex = 1;
            lblTarihSaat.Text = "Tarih Saat";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHosgeldiniz.Location = new Point(20, 15);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(137, 30);
            lblHosgeldiniz.TabIndex = 0;
            lblHosgeldiniz.Text = "Hoş Geldiniz";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.WhiteSmoke;
            pnlMenu.Controls.Add(btnIletisim);
            pnlMenu.Controls.Add(btnSifreDegistir);
            pnlMenu.Controls.Add(btnYedekleme);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnIsTakip);
            pnlMenu.Controls.Add(btnHesaplamalar);
            pnlMenu.Controls.Add(btnSirketler);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 80);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 610);
            pnlMenu.TabIndex = 1;
            // 
            // btnIletisim
            // 
            btnIletisim.BackColor = Color.MediumSlateBlue;
            btnIletisim.ForeColor = Color.White;
            btnIletisim.Location = new Point(10, 364);
            btnIletisim.Name = "btnIletisim";
            btnIletisim.Size = new Size(180, 50);
            btnIletisim.TabIndex = 6;
            btnIletisim.Text = "İletişim";
            btnIletisim.UseVisualStyleBackColor = false;
            btnIletisim.Click += btnIletisim_Click;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.Teal;
            btnSifreDegistir.ForeColor = Color.White;
            btnSifreDegistir.Location = new Point(10, 308);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(180, 50);
            btnSifreDegistir.TabIndex = 5;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // btnYedekleme
            // 
            btnYedekleme.BackColor = Color.Crimson;
            btnYedekleme.ForeColor = Color.White;
            btnYedekleme.Location = new Point(10, 252);
            btnYedekleme.Name = "btnYedekleme";
            btnYedekleme.Size = new Size(180, 50);
            btnYedekleme.TabIndex = 4;
            btnYedekleme.Text = "Yedekleme ve Geri Yükleme";
            btnYedekleme.UseVisualStyleBackColor = false;
            btnYedekleme.Click += btnYedekleme_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkGoldenrod;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 196);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 50);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Grafik Arayüzü";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnIsTakip
            // 
            btnIsTakip.BackColor = Color.Orange;
            btnIsTakip.ForeColor = Color.White;
            btnIsTakip.Location = new Point(10, 140);
            btnIsTakip.Name = "btnIsTakip";
            btnIsTakip.Size = new Size(180, 50);
            btnIsTakip.TabIndex = 2;
            btnIsTakip.Text = "İş Takip";
            btnIsTakip.UseVisualStyleBackColor = false;
            btnIsTakip.Click += btnIsTakip_Click;
            // 
            // btnHesaplamalar
            // 
            btnHesaplamalar.BackColor = Color.DodgerBlue;
            btnHesaplamalar.ForeColor = Color.White;
            btnHesaplamalar.Location = new Point(10, 80);
            btnHesaplamalar.Name = "btnHesaplamalar";
            btnHesaplamalar.Size = new Size(180, 50);
            btnHesaplamalar.TabIndex = 1;
            btnHesaplamalar.Text = "Hesaplamalar";
            btnHesaplamalar.UseVisualStyleBackColor = false;
            btnHesaplamalar.Click += btnHesaplamalar_Click;
            // 
            // btnSirketler
            // 
            btnSirketler.BackColor = Color.SeaGreen;
            btnSirketler.ForeColor = Color.White;
            btnSirketler.Location = new Point(10, 20);
            btnSirketler.Name = "btnSirketler";
            btnSirketler.Size = new Size(180, 50);
            btnSirketler.TabIndex = 0;
            btnSirketler.Text = "Şirket İşlemleri";
            btnSirketler.UseVisualStyleBackColor = false;
            btnSirketler.Click += btnSirketler_Click;
            // 
            // pnlIcerik
            // 
            pnlIcerik.BackColor = Color.White;
            pnlIcerik.Controls.Add(lblMesaj);
            pnlIcerik.Dock = DockStyle.Fill;
            pnlIcerik.Location = new Point(200, 80);
            pnlIcerik.Name = "pnlIcerik";
            pnlIcerik.Size = new Size(1132, 610);
            pnlIcerik.TabIndex = 2;
            // 
            // lblMesaj
            // 
            lblMesaj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMesaj.AutoSize = true;
            lblMesaj.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMesaj.Location = new Point(620, 389);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(323, 25);
            lblMesaj.TabIndex = 0;
            lblMesaj.Text = "Lütfen Sol Menüden Bir İşlem Seçiniz";
            lblMesaj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerSaat
            // 
            timerSaat.Enabled = true;
            timerSaat.Interval = 1000;
            timerSaat.Tick += timerSaat_Tick;
            // 
            // FrmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 690);
            Controls.Add(pnlIcerik);
            Controls.Add(pnlMenu);
            Controls.Add(pnlUst);
            Name = "FrmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kompanzasyon Hesap Sistemi - Ana Sayfa";
            WindowState = FormWindowState.Maximized;
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlIcerik.ResumeLayout(false);
            pnlIcerik.PerformLayout();
            ResumeLayout(false);
        } // InitializeComponent() metodunun kapanış parantezi

        #endregion

        private Panel pnlUst;
        private Label lblTarihSaat;
        private Label lblHosgeldiniz;
        private Button btnCikis;
        private Panel pnlMenu;
        private Button btnHesaplamalar;
        private Button btnSirketler;
        private Button btnIsTakip;
        private Panel pnlIcerik;
        private Label lblMesaj;
        private System.Windows.Forms.Timer timerSaat;
        private Button btnDashboard;
        private Button btnYedekleme;
        private Button btnSifreDegistir;
        private Button btnIletisim;
    }
}