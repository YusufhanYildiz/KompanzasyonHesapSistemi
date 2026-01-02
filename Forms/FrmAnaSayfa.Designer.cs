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
            this.components = new System.ComponentModel.Container();
            this.pnlUst = new MaterialSkin.Controls.MaterialCard();
            this.btnCikis = new MaterialSkin.Controls.MaterialButton();
            this.lblTarihSaat = new MaterialSkin.Controls.MaterialLabel();
            this.lblHosgeldiniz = new MaterialSkin.Controls.MaterialLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnIletisim = new MaterialSkin.Controls.MaterialButton();
            this.btnSifreDegistir = new MaterialSkin.Controls.MaterialButton();
            this.btnYedekleme = new MaterialSkin.Controls.MaterialButton();
            this.btnDashboard = new MaterialSkin.Controls.MaterialButton();
            this.btnIsTakip = new MaterialSkin.Controls.MaterialButton();
            this.btnHesaplamalar = new MaterialSkin.Controls.MaterialButton();
            this.btnSirketler = new MaterialSkin.Controls.MaterialButton();
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.tableLayoutPanelGuide = new System.Windows.Forms.TableLayoutPanel();
            this.cardJobGuide = new MaterialSkin.Controls.MaterialCard();
            this.lblJobColumns = new MaterialSkin.Controls.MaterialLabel();
            this.lblJobTitle = new MaterialSkin.Controls.MaterialLabel();
            this.cardCalcGuide = new MaterialSkin.Controls.MaterialCard();
            this.lblCalcColumns = new MaterialSkin.Controls.MaterialLabel();
            this.lblCalcTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblGuideNote = new MaterialSkin.Controls.MaterialLabel();
            this.lblMesaj = new MaterialSkin.Controls.MaterialLabel();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.pnlUst.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.pnlIcerik.SuspendLayout();
            this.tableLayoutPanelGuide.SuspendLayout();
            this.cardJobGuide.SuspendLayout();
            this.cardCalcGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.lblTarihSaat);
            this.pnlUst.Controls.Add(this.lblHosgeldiniz);
            this.pnlUst.Depth = 0;
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(3, 64);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(14);
            this.pnlUst.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Padding = new System.Windows.Forms.Padding(14);
            this.pnlUst.Size = new System.Drawing.Size(1326, 80);
            this.pnlUst.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCikis.Depth = 0;
            this.btnCikis.HighEmphasis = true;
            this.btnCikis.Icon = null;
            this.btnCikis.Location = new System.Drawing.Point(1217, 20);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCikis.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCikis.Size = new System.Drawing.Size(89, 36);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCikis.UseAccentColor = false;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.Depth = 0;
            this.lblTarihSaat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTarihSaat.Location = new System.Drawing.Point(20, 45);
            this.lblTarihSaat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(74, 19);
            this.lblTarihSaat.TabIndex = 1;
            this.lblTarihSaat.Text = "Tarih Saat";
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Depth = 0;
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHosgeldiniz.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(20, 10);
            this.lblHosgeldiniz.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(135, 29);
            this.lblHosgeldiniz.TabIndex = 0;
            this.lblHosgeldiniz.Text = "Hoş Geldiniz";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tableLayoutPanelMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(3, 144);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 543);
            this.pnlMenu.TabIndex = 1;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.btnGuncelle, 0, 7);
            this.tableLayoutPanelMenu.Controls.Add(this.btnIletisim, 0, 6);
            this.tableLayoutPanelMenu.Controls.Add(this.btnSifreDegistir, 0, 5);
            this.tableLayoutPanelMenu.Controls.Add(this.btnYedekleme, 0, 4);
            this.tableLayoutPanelMenu.Controls.Add(this.btnDashboard, 0, 3);
            this.tableLayoutPanelMenu.Controls.Add(this.btnIsTakip, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.btnHesaplamalar, 0, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.btnSirketler, 0, 0);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelMenu.RowCount = 9;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(250, 543);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = false;
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuncelle.Depth = 0;
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuncelle.HighEmphasis = true;
            this.btnGuncelle.Icon = null;
            this.btnGuncelle.Location = new System.Drawing.Point(14, 436);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuncelle.Size = new System.Drawing.Size(222, 48);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncellemeleri Denetle";
            this.btnGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuncelle.UseAccentColor = false;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIletisim
            // 
            this.btnIletisim.AutoSize = false;
            this.btnIletisim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIletisim.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIletisim.Depth = 0;
            this.btnIletisim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIletisim.HighEmphasis = true;
            this.btnIletisim.Icon = null;
            this.btnIletisim.Location = new System.Drawing.Point(14, 376);
            this.btnIletisim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIletisim.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIletisim.Size = new System.Drawing.Size(222, 48);
            this.btnIletisim.TabIndex = 6;
            this.btnIletisim.Text = "İletişim";
            this.btnIletisim.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIletisim.UseAccentColor = false;
            this.btnIletisim.UseVisualStyleBackColor = true;
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.AutoSize = false;
            this.btnSifreDegistir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSifreDegistir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSifreDegistir.Depth = 0;
            this.btnSifreDegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSifreDegistir.HighEmphasis = true;
            this.btnSifreDegistir.Icon = null;
            this.btnSifreDegistir.Location = new System.Drawing.Point(14, 316);
            this.btnSifreDegistir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSifreDegistir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSifreDegistir.Size = new System.Drawing.Size(222, 48);
            this.btnSifreDegistir.TabIndex = 5;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSifreDegistir.UseAccentColor = false;
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // btnYedekleme
            // 
            this.btnYedekleme.AutoSize = false;
            this.btnYedekleme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYedekleme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYedekleme.Depth = 0;
            this.btnYedekleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYedekleme.HighEmphasis = true;
            this.btnYedekleme.Icon = null;
            this.btnYedekleme.Location = new System.Drawing.Point(14, 256);
            this.btnYedekleme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYedekleme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYedekleme.Name = "btnYedekleme";
            this.btnYedekleme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYedekleme.Size = new System.Drawing.Size(222, 48);
            this.btnYedekleme.TabIndex = 4;
            this.btnYedekleme.Text = "Yedekleme";
            this.btnYedekleme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnYedekleme.UseAccentColor = false;
            this.btnYedekleme.UseVisualStyleBackColor = true;
            this.btnYedekleme.Click += new System.EventHandler(this.btnYedekleme_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSize = false;
            this.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDashboard.Depth = 0;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboard.HighEmphasis = true;
            this.btnDashboard.Icon = null;
            this.btnDashboard.Location = new System.Drawing.Point(14, 196);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDashboard.Size = new System.Drawing.Size(222, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Grafik Arayüzü";
            this.btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDashboard.UseAccentColor = false;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnIsTakip
            // 
            this.btnIsTakip.AutoSize = false;
            this.btnIsTakip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIsTakip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIsTakip.Depth = 0;
            this.btnIsTakip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIsTakip.HighEmphasis = true;
            this.btnIsTakip.Icon = null;
            this.btnIsTakip.Location = new System.Drawing.Point(14, 136);
            this.btnIsTakip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIsTakip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIsTakip.Name = "btnIsTakip";
            this.btnIsTakip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIsTakip.Size = new System.Drawing.Size(222, 48);
            this.btnIsTakip.TabIndex = 2;
            this.btnIsTakip.Text = "İş Takip";
            this.btnIsTakip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIsTakip.UseAccentColor = false;
            this.btnIsTakip.UseVisualStyleBackColor = true;
            this.btnIsTakip.Click += new System.EventHandler(this.btnIsTakip_Click);
            // 
            // btnHesaplamalar
            // 
            this.btnHesaplamalar.AutoSize = false;
            this.btnHesaplamalar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesaplamalar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesaplamalar.Depth = 0;
            this.btnHesaplamalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHesaplamalar.HighEmphasis = true;
            this.btnHesaplamalar.Icon = null;
            this.btnHesaplamalar.Location = new System.Drawing.Point(14, 76);
            this.btnHesaplamalar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesaplamalar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHesaplamalar.Name = "btnHesaplamalar";
            this.btnHesaplamalar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesaplamalar.Size = new System.Drawing.Size(222, 48);
            this.btnHesaplamalar.TabIndex = 1;
            this.btnHesaplamalar.Text = "Hesaplamalar";
            this.btnHesaplamalar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesaplamalar.UseAccentColor = false;
            this.btnHesaplamalar.UseVisualStyleBackColor = true;
            this.btnHesaplamalar.Click += new System.EventHandler(this.btnHesaplamalar_Click);
            // 
            // btnSirketler
            // 
            this.btnSirketler.AutoSize = false;
            this.btnSirketler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSirketler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSirketler.Depth = 0;
            this.btnSirketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSirketler.HighEmphasis = true;
            this.btnSirketler.Icon = null;
            this.btnSirketler.Location = new System.Drawing.Point(14, 16);
            this.btnSirketler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSirketler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSirketler.Name = "btnSirketler";
            this.btnSirketler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSirketler.Size = new System.Drawing.Size(222, 48);
            this.btnSirketler.TabIndex = 0;
            this.btnSirketler.Text = "Şirket İşlemleri";
            this.btnSirketler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSirketler.UseAccentColor = false;
            this.btnSirketler.UseVisualStyleBackColor = true;
            this.btnSirketler.Click += new System.EventHandler(this.btnSirketler_Click);
            // 
            // pnlIcerik
            // 
            this.pnlIcerik.Controls.Add(this.tableLayoutPanelGuide);
            this.pnlIcerik.Controls.Add(this.lblMesaj);
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(253, 144);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Padding = new System.Windows.Forms.Padding(20);
            this.pnlIcerik.Size = new System.Drawing.Size(1076, 543);
            this.pnlIcerik.TabIndex = 2;
            // 
            // tableLayoutPanelGuide
            // 
            this.tableLayoutPanelGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelGuide.ColumnCount = 2;
            this.tableLayoutPanelGuide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGuide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGuide.Controls.Add(this.cardJobGuide, 0, 0);
            this.tableLayoutPanelGuide.Controls.Add(this.cardCalcGuide, 1, 0);
            this.tableLayoutPanelGuide.Controls.Add(this.lblGuideNote, 0, 1);
            this.tableLayoutPanelGuide.Location = new System.Drawing.Point(20, 70);
            this.tableLayoutPanelGuide.Name = "tableLayoutPanelGuide";
            this.tableLayoutPanelGuide.RowCount = 2;
            this.tableLayoutPanelGuide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGuide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelGuide.Size = new System.Drawing.Size(1036, 453);
            this.tableLayoutPanelGuide.TabIndex = 1;
            // 
            // cardJobGuide
            // 
            this.cardJobGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardJobGuide.Controls.Add(this.lblJobColumns);
            this.cardJobGuide.Controls.Add(this.lblJobTitle);
            this.cardJobGuide.Depth = 0;
            this.cardJobGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardJobGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardJobGuide.Location = new System.Drawing.Point(14, 14);
            this.cardJobGuide.Margin = new System.Windows.Forms.Padding(14);
            this.cardJobGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardJobGuide.Name = "cardJobGuide";
            this.cardJobGuide.Padding = new System.Windows.Forms.Padding(14);
            this.cardJobGuide.Size = new System.Drawing.Size(490, 365);
            this.cardJobGuide.TabIndex = 0;
            // 
            // lblJobColumns
            // 
            this.lblJobColumns.Depth = 0;
            this.lblJobColumns.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblJobColumns.Location = new System.Drawing.Point(17, 50);
            this.lblJobColumns.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJobColumns.Name = "lblJobColumns";
            this.lblJobColumns.Size = new System.Drawing.Size(450, 300);
            this.lblJobColumns.TabIndex = 1;
            this.lblJobColumns.Text = "Sütunlar (Sırasıyla):\r\n1. Şirket Adı (Sistemle aynı olmalı)\r\n2. Tarih (GG.AA.YYYY)\r\n3. İş Açıklaması\r\n4. İş Ücreti (Sayı)\r\n5. Alınan Tutar (Sayı)\r\n\r\n* İlk satır başlık olarak kabul edilir.";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Depth = 0;
            this.lblJobTitle.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblJobTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblJobTitle.Location = new System.Drawing.Point(17, 14);
            this.lblJobTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(157, 22);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "İş Takip Excel Formatı";
            // 
            // cardCalcGuide
            // 
            this.cardCalcGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCalcGuide.Controls.Add(this.lblCalcColumns);
            this.cardCalcGuide.Controls.Add(this.lblCalcTitle);
            this.cardCalcGuide.Depth = 0;
            this.cardCalcGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCalcGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCalcGuide.Location = new System.Drawing.Point(532, 14);
            this.cardCalcGuide.Margin = new System.Windows.Forms.Padding(14);
            this.cardCalcGuide.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCalcGuide.Name = "cardCalcGuide";
            this.cardCalcGuide.Padding = new System.Windows.Forms.Padding(14);
            this.cardCalcGuide.Size = new System.Drawing.Size(490, 365);
            this.cardCalcGuide.TabIndex = 1;
            // 
            // lblCalcColumns
            // 
            this.lblCalcColumns.Depth = 0;
            this.lblCalcColumns.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCalcColumns.Location = new System.Drawing.Point(17, 50);
            this.lblCalcColumns.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalcColumns.Name = "lblCalcColumns";
            this.lblCalcColumns.Size = new System.Drawing.Size(450, 300);
            this.lblCalcColumns.TabIndex = 1;
            this.lblCalcColumns.Text = "Sütunlar (Sırasıyla):\r\n1. Şirket Adı\r\n2. Tarih\r\n3. Önceki Aktif\r\n4. Önceki Endüktif\r\n5. Önceki Kapasitif\r\n6. Mevcut Aktif\r\n7. Mevcut Endüktif\r\n8. Mevcut Kapasitif\r\n\r\n* Sayısal değerlerde nokta/virgül ayrımına dikkat ediniz.";
            // 
            // lblCalcTitle
            // 
            this.lblCalcTitle.AutoSize = true;
            this.lblCalcTitle.Depth = 0;
            this.lblCalcTitle.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCalcTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCalcTitle.Location = new System.Drawing.Point(17, 14);
            this.lblCalcTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalcTitle.Name = "lblCalcTitle";
            this.lblCalcTitle.Size = new System.Drawing.Size(193, 22);
            this.lblCalcTitle.TabIndex = 0;
            this.lblCalcTitle.Text = "Hesaplamalar Excel Formatı";
            // 
            // lblGuideNote
            // 
            this.tableLayoutPanelGuide.SetColumnSpan(this.lblGuideNote, 2);
            this.lblGuideNote.Depth = 0;
            this.lblGuideNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuideNote.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuideNote.ForeColor = System.Drawing.Color.Red;
            this.lblGuideNote.Location = new System.Drawing.Point(3, 393);
            this.lblGuideNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuideNote.Name = "lblGuideNote";
            this.lblGuideNote.Size = new System.Drawing.Size(1030, 60);
            this.lblGuideNote.TabIndex = 2;
            this.lblGuideNote.Text = "ÖNEMLİ: Excel\'deki Şirket Adı sütunu, programda kayıtlı olan isimlerle tam olarak eşleşmelidir. Eşleşmeyen satırlar atlanacaktır.";
            this.lblGuideNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Depth = 0;
            this.lblMesaj.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMesaj.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblMesaj.Location = new System.Drawing.Point(20, 20);
            this.lblMesaj.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(430, 29);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "Excel Veri Alma Kılavuzu (.xlsx, .xls, .csv)";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 690);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlUst);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kompanzasyon Hesap Sistemi - Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.pnlIcerik.ResumeLayout(false);
            this.pnlIcerik.PerformLayout();
            this.tableLayoutPanelGuide.ResumeLayout(false);
            this.tableLayoutPanelGuide.PerformLayout();
            this.cardJobGuide.ResumeLayout(false);
            this.cardJobGuide.PerformLayout();
            this.cardCalcGuide.ResumeLayout(false);
            this.cardCalcGuide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard pnlUst;
        private MaterialSkin.Controls.MaterialLabel lblTarihSaat;
        private MaterialSkin.Controls.MaterialLabel lblHosgeldiniz;
        private MaterialSkin.Controls.MaterialButton btnCikis;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private MaterialSkin.Controls.MaterialButton btnHesaplamalar;
        private MaterialSkin.Controls.MaterialButton btnSirketler;
        private MaterialSkin.Controls.MaterialButton btnIsTakip;
        private System.Windows.Forms.Panel pnlIcerik;
        private MaterialSkin.Controls.MaterialLabel lblMesaj;
        private System.Windows.Forms.Timer timerSaat;
        private MaterialSkin.Controls.MaterialButton btnDashboard;
        private MaterialSkin.Controls.MaterialButton btnYedekleme;
        private MaterialSkin.Controls.MaterialButton btnSifreDegistir;
        private MaterialSkin.Controls.MaterialButton btnIletisim;
        private MaterialSkin.Controls.MaterialButton btnGuncelle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGuide;
        private MaterialSkin.Controls.MaterialCard cardJobGuide;
        private MaterialSkin.Controls.MaterialLabel lblJobTitle;
        private MaterialSkin.Controls.MaterialLabel lblJobColumns;
        private MaterialSkin.Controls.MaterialCard cardCalcGuide;
        private MaterialSkin.Controls.MaterialLabel lblCalcTitle;
        private MaterialSkin.Controls.MaterialLabel lblCalcColumns;
        private MaterialSkin.Controls.MaterialLabel lblGuideNote;
    }
}