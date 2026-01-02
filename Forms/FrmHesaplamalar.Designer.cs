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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardFilter = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanelFilter = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSirketFiltrele = new MaterialSkin.Controls.MaterialComboBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrele = new MaterialSkin.Controls.MaterialButton();
            this.btnFiltreyiTemizle = new MaterialSkin.Controls.MaterialButton();
            this.lblBaslangic = new MaterialSkin.Controls.MaterialLabel();
            this.lblBitis = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardInputs = new MaterialSkin.Controls.MaterialCard();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSirket = new MaterialSkin.Controls.MaterialComboBox();
            this.txtOncekiAktif = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtOncekiEnduktif = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtOncekiKpstfTuketim = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAktif = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEnduktif = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtKapasitif = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnHesapla = new MaterialSkin.Controls.MaterialButton();
            this.btnTemizle = new MaterialSkin.Controls.MaterialButton();
            this.cardResults = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
            this.lblEnduktifOran = new System.Windows.Forms.Label();
            this.lblKapasitifOran = new System.Windows.Forms.Label();
            this.lblEnduktifLimit = new MaterialSkin.Controls.MaterialLabel();
            this.lblKapasitifLimit = new MaterialSkin.Controls.MaterialLabel();
            this.gbCezaDurumu = new MaterialSkin.Controls.MaterialCard();
            this.lblCezaDurumuSonuc = new System.Windows.Forms.Label();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvHesaplamalar = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnExcelAl = new MaterialSkin.Controls.MaterialButton();
            this.btnExcelAktar = new MaterialSkin.Controls.MaterialButton();
            this.btnPdfRapor = new MaterialSkin.Controls.MaterialButton();
            this.btnYenile = new MaterialSkin.Controls.MaterialButton();
            this.btnSil = new MaterialSkin.Controls.MaterialButton();
            this.btnKapat = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardFilter.SuspendLayout();
            this.tableLayoutPanelFilter.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardInputs.SuspendLayout();
            this.cardResults.SuspendLayout();
            this.tableLayoutPanelResults.SuspendLayout();
            this.gbCezaDurumu.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesaplamalar)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.cardFilter, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelContent, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pnlActions, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1344, 662);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // cardFilter
            // 
            this.cardFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFilter.Controls.Add(this.tableLayoutPanelFilter);
            this.cardFilter.Depth = 0;
            this.cardFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFilter.Location = new System.Drawing.Point(14, 14);
            this.cardFilter.Margin = new System.Windows.Forms.Padding(14);
            this.cardFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFilter.Name = "cardFilter";
            this.cardFilter.Padding = new System.Windows.Forms.Padding(14);
            this.cardFilter.Size = new System.Drawing.Size(1316, 72);
            this.cardFilter.TabIndex = 0;
            // 
            // tableLayoutPanelFilter
            // 
            this.tableLayoutPanelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelFilter.ColumnCount = 7;
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanelFilter.Controls.Add(this.cmbSirketFiltrele, 0, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.dtpBaslangic, 2, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.dtpBitis, 4, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.btnFiltrele, 5, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.btnFiltreyiTemizle, 6, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.lblBaslangic, 1, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.lblBitis, 3, 0);
            this.tableLayoutPanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelFilter.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanelFilter.Name = "tableLayoutPanelFilter";
            this.tableLayoutPanelFilter.RowCount = 1;
            this.tableLayoutPanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilter.Size = new System.Drawing.Size(1288, 44);
            this.tableLayoutPanelFilter.TabIndex = 0;
            // 
            // cmbSirketFiltrele
            // 
            this.cmbSirketFiltrele.AutoResize = false;
            this.cmbSirketFiltrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbSirketFiltrele.Depth = 0;
            this.cmbSirketFiltrele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSirketFiltrele.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSirketFiltrele.DropDownHeight = 174;
            this.cmbSirketFiltrele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirketFiltrele.DropDownWidth = 121;
            this.cmbSirketFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSirketFiltrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSirketFiltrele.FormattingEnabled = true;
            this.cmbSirketFiltrele.Hint = "Þirket Filtrele";
            this.cmbSirketFiltrele.IntegralHeight = false;
            this.cmbSirketFiltrele.ItemHeight = 43;
            this.cmbSirketFiltrele.Location = new System.Drawing.Point(3, 3);
            this.cmbSirketFiltrele.MaxDropDownItems = 4;
            this.cmbSirketFiltrele.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSirketFiltrele.Name = "cmbSirketFiltrele";
            this.cmbSirketFiltrele.Size = new System.Drawing.Size(266, 49);
            this.cmbSirketFiltrele.StartIndex = 0;
            this.cmbSirketFiltrele.TabIndex = 0;
            this.cmbSirketFiltrele.UseAccent = false;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpBaslangic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBaslangic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpBaslangic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(375, 10);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(211, 24);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpBitis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBitis.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpBitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(692, 10);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(211, 24);
            this.dtpBitis.TabIndex = 2;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.AutoSize = false;
            this.btnFiltrele.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFiltrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFiltrele.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFiltrele.Depth = 0;
            this.btnFiltrele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiltrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFiltrele.HighEmphasis = true;
            this.btnFiltrele.Icon = null;
            this.btnFiltrele.Location = new System.Drawing.Point(910, 6);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFiltrele.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFiltrele.Size = new System.Drawing.Size(182, 32);
            this.btnFiltrele.TabIndex = 3;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFiltrele.UseAccentColor = false;
            this.btnFiltrele.UseVisualStyleBackColor = false;
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.AutoSize = false;
            this.btnFiltreyiTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFiltreyiTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFiltreyiTemizle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFiltreyiTemizle.Depth = 0;
            this.btnFiltreyiTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiltreyiTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFiltreyiTemizle.HighEmphasis = true;
            this.btnFiltreyiTemizle.Icon = null;
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(1100, 6);
            this.btnFiltreyiTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFiltreyiTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            this.btnFiltreyiTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFiltreyiTemizle.Size = new System.Drawing.Size(184, 32);
            this.btnFiltreyiTemizle.TabIndex = 4;
            this.btnFiltreyiTemizle.Text = "Temizle";
            this.btnFiltreyiTemizle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnFiltreyiTemizle.UseAccentColor = false;
            this.btnFiltreyiTemizle.UseVisualStyleBackColor = false;
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBaslangic.Depth = 0;
            this.lblBaslangic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaslangic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBaslangic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBaslangic.Location = new System.Drawing.Point(275, 0);
            this.lblBaslangic.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(94, 44);
            this.lblBaslangic.TabIndex = 5;
            this.lblBaslangic.Text = "Baþlangýç:";
            this.lblBaslangic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBitis.Depth = 0;
            this.lblBitis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBitis.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBitis.Location = new System.Drawing.Point(592, 0);
            this.lblBitis.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(94, 44);
            this.lblBitis.TabIndex = 6;
            this.lblBitis.Text = "Bitiþ:";
            this.lblBitis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelContent.ColumnCount = 2;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.cardInputs, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.cardResults, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.cardGrid, 1, 0);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 2;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(1338, 496);
            this.tableLayoutPanelContent.TabIndex = 1;
            // 
            // cardInputs
            // 
            this.cardInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardInputs.Controls.Add(this.dtpTarih);
            this.cardInputs.Controls.Add(this.cmbSirket);
            this.cardInputs.Controls.Add(this.txtOncekiAktif);
            this.cardInputs.Controls.Add(this.txtOncekiEnduktif);
            this.cardInputs.Controls.Add(this.txtOncekiKpstfTuketim);
            this.cardInputs.Controls.Add(this.txtAktif);
            this.cardInputs.Controls.Add(this.txtEnduktif);
            this.cardInputs.Controls.Add(this.txtKapasitif);
            this.cardInputs.Controls.Add(this.btnHesapla);
            this.cardInputs.Controls.Add(this.btnTemizle);
            this.cardInputs.Depth = 0;
            this.cardInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInputs.Location = new System.Drawing.Point(14, 14);
            this.cardInputs.Margin = new System.Windows.Forms.Padding(14);
            this.cardInputs.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardInputs.Name = "cardInputs";
            this.cardInputs.Padding = new System.Windows.Forms.Padding(14);
            this.cardInputs.Size = new System.Drawing.Size(422, 288);
            this.cardInputs.TabIndex = 0;
            // 
            // dtpTarih
            // 
            this.dtpTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpTarih.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpTarih.Location = new System.Drawing.Point(17, 17);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(185, 24);
            this.dtpTarih.TabIndex = 0;
            // 
            // cmbSirket
            // 
            this.cmbSirket.AutoResize = false;
            this.cmbSirket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbSirket.Depth = 0;
            this.cmbSirket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSirket.DropDownHeight = 174;
            this.cmbSirket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirket.DropDownWidth = 121;
            this.cmbSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSirket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSirket.FormattingEnabled = true;
            this.cmbSirket.Hint = "Þirket Seçin";
            this.cmbSirket.IntegralHeight = false;
            this.cmbSirket.ItemHeight = 43;
            this.cmbSirket.Location = new System.Drawing.Point(210, 10);
            this.cmbSirket.MaxDropDownItems = 4;
            this.cmbSirket.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSirket.Name = "cmbSirket";
            this.cmbSirket.Size = new System.Drawing.Size(195, 49);
            this.cmbSirket.StartIndex = 0;
            this.cmbSirket.TabIndex = 1;
            this.cmbSirket.UseAccent = false;
            // 
            // txtOncekiAktif
            // 
            this.txtOncekiAktif.AnimateReadOnly = false;
            this.txtOncekiAktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOncekiAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOncekiAktif.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOncekiAktif.Depth = 0;
            this.txtOncekiAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOncekiAktif.HideSelection = true;
            this.txtOncekiAktif.Hint = "Önceki Aktif";
            this.txtOncekiAktif.LeadingIcon = null;
            this.txtOncekiAktif.Location = new System.Drawing.Point(17, 65);
            this.txtOncekiAktif.MaxLength = 32767;
            this.txtOncekiAktif.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOncekiAktif.Name = "txtOncekiAktif";
            this.txtOncekiAktif.PasswordChar = '\0';
            this.txtOncekiAktif.PrefixSuffixText = null;
            this.txtOncekiAktif.ReadOnly = false;
            this.txtOncekiAktif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOncekiAktif.SelectedText = "";
            this.txtOncekiAktif.SelectionLength = 0;
            this.txtOncekiAktif.SelectionStart = 0;
            this.txtOncekiAktif.ShortcutsEnabled = true;
            this.txtOncekiAktif.Size = new System.Drawing.Size(185, 48);
            this.txtOncekiAktif.TabIndex = 2;
            this.txtOncekiAktif.TabStop = false;
            this.txtOncekiAktif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOncekiAktif.TrailingIcon = null;
            this.txtOncekiAktif.UseAccent = false;
            this.txtOncekiAktif.UseSystemPasswordChar = false;
            // 
            // txtOncekiEnduktif
            // 
            this.txtOncekiEnduktif.AnimateReadOnly = false;
            this.txtOncekiEnduktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOncekiEnduktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOncekiEnduktif.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOncekiEnduktif.Depth = 0;
            this.txtOncekiEnduktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOncekiEnduktif.HideSelection = true;
            this.txtOncekiEnduktif.Hint = "Önceki Endüktif";
            this.txtOncekiEnduktif.LeadingIcon = null;
            this.txtOncekiEnduktif.Location = new System.Drawing.Point(17, 119);
            this.txtOncekiEnduktif.MaxLength = 32767;
            this.txtOncekiEnduktif.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOncekiEnduktif.Name = "txtOncekiEnduktif";
            this.txtOncekiEnduktif.PasswordChar = '\0';
            this.txtOncekiEnduktif.PrefixSuffixText = null;
            this.txtOncekiEnduktif.ReadOnly = false;
            this.txtOncekiEnduktif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOncekiEnduktif.SelectedText = "";
            this.txtOncekiEnduktif.SelectionLength = 0;
            this.txtOncekiEnduktif.SelectionStart = 0;
            this.txtOncekiEnduktif.ShortcutsEnabled = true;
            this.txtOncekiEnduktif.Size = new System.Drawing.Size(185, 48);
            this.txtOncekiEnduktif.TabIndex = 3;
            this.txtOncekiEnduktif.TabStop = false;
            this.txtOncekiEnduktif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOncekiEnduktif.TrailingIcon = null;
            this.txtOncekiEnduktif.UseAccent = false;
            this.txtOncekiEnduktif.UseSystemPasswordChar = false;
            // 
            // txtOncekiKpstfTuketim
            // 
            this.txtOncekiKpstfTuketim.AnimateReadOnly = false;
            this.txtOncekiKpstfTuketim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOncekiKpstfTuketim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOncekiKpstfTuketim.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOncekiKpstfTuketim.Depth = 0;
            this.txtOncekiKpstfTuketim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOncekiKpstfTuketim.HideSelection = true;
            this.txtOncekiKpstfTuketim.Hint = "Önceki Kapasitif";
            this.txtOncekiKpstfTuketim.LeadingIcon = null;
            this.txtOncekiKpstfTuketim.Location = new System.Drawing.Point(17, 173);
            this.txtOncekiKpstfTuketim.MaxLength = 32767;
            this.txtOncekiKpstfTuketim.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOncekiKpstfTuketim.Name = "txtOncekiKpstfTuketim";
            this.txtOncekiKpstfTuketim.PasswordChar = '\0';
            this.txtOncekiKpstfTuketim.PrefixSuffixText = null;
            this.txtOncekiKpstfTuketim.ReadOnly = false;
            this.txtOncekiKpstfTuketim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOncekiKpstfTuketim.SelectedText = "";
            this.txtOncekiKpstfTuketim.SelectionLength = 0;
            this.txtOncekiKpstfTuketim.SelectionStart = 0;
            this.txtOncekiKpstfTuketim.ShortcutsEnabled = true;
            this.txtOncekiKpstfTuketim.Size = new System.Drawing.Size(185, 48);
            this.txtOncekiKpstfTuketim.TabIndex = 4;
            this.txtOncekiKpstfTuketim.TabStop = false;
            this.txtOncekiKpstfTuketim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOncekiKpstfTuketim.TrailingIcon = null;
            this.txtOncekiKpstfTuketim.UseAccent = false;
            this.txtOncekiKpstfTuketim.UseSystemPasswordChar = false;
            // 
            // txtAktif
            // 
            this.txtAktif.AnimateReadOnly = false;
            this.txtAktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAktif.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAktif.Depth = 0;
            this.txtAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAktif.HideSelection = true;
            this.txtAktif.Hint = "Mevcut Aktif";
            this.txtAktif.LeadingIcon = null;
            this.txtAktif.Location = new System.Drawing.Point(210, 65);
            this.txtAktif.MaxLength = 32767;
            this.txtAktif.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAktif.Name = "txtAktif";
            this.txtAktif.PasswordChar = '\0';
            this.txtAktif.PrefixSuffixText = null;
            this.txtAktif.ReadOnly = false;
            this.txtAktif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAktif.SelectedText = "";
            this.txtAktif.SelectionLength = 0;
            this.txtAktif.SelectionStart = 0;
            this.txtAktif.ShortcutsEnabled = true;
            this.txtAktif.Size = new System.Drawing.Size(195, 48);
            this.txtAktif.TabIndex = 5;
            this.txtAktif.TabStop = false;
            this.txtAktif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAktif.TrailingIcon = null;
            this.txtAktif.UseAccent = false;
            this.txtAktif.UseSystemPasswordChar = false;
            // 
            // txtEnduktif
            // 
            this.txtEnduktif.AnimateReadOnly = false;
            this.txtEnduktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEnduktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEnduktif.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEnduktif.Depth = 0;
            this.txtEnduktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnduktif.HideSelection = true;
            this.txtEnduktif.Hint = "Mevcut Endüktif";
            this.txtEnduktif.LeadingIcon = null;
            this.txtEnduktif.Location = new System.Drawing.Point(210, 119);
            this.txtEnduktif.MaxLength = 32767;
            this.txtEnduktif.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEnduktif.Name = "txtEnduktif";
            this.txtEnduktif.PasswordChar = '\0';
            this.txtEnduktif.PrefixSuffixText = null;
            this.txtEnduktif.ReadOnly = false;
            this.txtEnduktif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnduktif.SelectedText = "";
            this.txtEnduktif.SelectionLength = 0;
            this.txtEnduktif.SelectionStart = 0;
            this.txtEnduktif.ShortcutsEnabled = true;
            this.txtEnduktif.Size = new System.Drawing.Size(195, 48);
            this.txtEnduktif.TabIndex = 6;
            this.txtEnduktif.TabStop = false;
            this.txtEnduktif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEnduktif.TrailingIcon = null;
            this.txtEnduktif.UseAccent = false;
            this.txtEnduktif.UseSystemPasswordChar = false;
            // 
            // txtKapasitif
            // 
            this.txtKapasitif.AnimateReadOnly = false;
            this.txtKapasitif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtKapasitif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKapasitif.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKapasitif.Depth = 0;
            this.txtKapasitif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKapasitif.HideSelection = true;
            this.txtKapasitif.Hint = "Mevcut Kapasitif";
            this.txtKapasitif.LeadingIcon = null;
            this.txtKapasitif.Location = new System.Drawing.Point(210, 173);
            this.txtKapasitif.MaxLength = 32767;
            this.txtKapasitif.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKapasitif.Name = "txtKapasitif";
            this.txtKapasitif.PasswordChar = '\0';
            this.txtKapasitif.PrefixSuffixText = null;
            this.txtKapasitif.ReadOnly = false;
            this.txtKapasitif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKapasitif.SelectedText = "";
            this.txtKapasitif.SelectionLength = 0;
            this.txtKapasitif.SelectionStart = 0;
            this.txtKapasitif.ShortcutsEnabled = true;
            this.txtKapasitif.Size = new System.Drawing.Size(195, 48);
            this.txtKapasitif.TabIndex = 7;
            this.txtKapasitif.TabStop = false;
            this.txtKapasitif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKapasitif.TrailingIcon = null;
            this.txtKapasitif.UseAccent = false;
            this.txtKapasitif.UseSystemPasswordChar = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.AutoSize = false;
            this.btnHesapla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHesapla.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapla.Depth = 0;
            this.btnHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHesapla.HighEmphasis = true;
            this.btnHesapla.Icon = null;
            this.btnHesapla.Location = new System.Drawing.Point(17, 230);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapla.Size = new System.Drawing.Size(240, 36);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla ve Kaydet";
            this.btnHesapla.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapla.UseAccentColor = false;
            this.btnHesapla.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSize = false;
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTemizle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTemizle.Depth = 0;
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTemizle.HighEmphasis = true;
            this.btnTemizle.Icon = null;
            this.btnTemizle.Location = new System.Drawing.Point(265, 230);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTemizle.Size = new System.Drawing.Size(140, 36);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTemizle.UseAccentColor = false;
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // cardResults
            // 
            this.cardResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardResults.Controls.Add(this.tableLayoutPanelResults);
            this.cardResults.Depth = 0;
            this.cardResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardResults.Location = new System.Drawing.Point(14, 330);
            this.cardResults.Margin = new System.Windows.Forms.Padding(14);
            this.cardResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardResults.Name = "cardResults";
            this.cardResults.Padding = new System.Windows.Forms.Padding(14);
            this.cardResults.Size = new System.Drawing.Size(422, 152);
            this.cardResults.TabIndex = 1;
            // 
            // tableLayoutPanelResults
            // 
            this.tableLayoutPanelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelResults.ColumnCount = 2;
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelResults.Controls.Add(this.lblEnduktifOran, 0, 0);
            this.tableLayoutPanelResults.Controls.Add(this.lblKapasitifOran, 0, 1);
            this.tableLayoutPanelResults.Controls.Add(this.lblEnduktifLimit, 1, 0);
            this.tableLayoutPanelResults.Controls.Add(this.lblKapasitifLimit, 1, 1);
            this.tableLayoutPanelResults.Controls.Add(this.gbCezaDurumu, 0, 2);
            this.tableLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResults.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelResults.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
            this.tableLayoutPanelResults.RowCount = 3;
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanelResults.Size = new System.Drawing.Size(394, 124);
            this.tableLayoutPanelResults.TabIndex = 0;
            // 
            // lblEnduktifOran
            // 
            this.lblEnduktifOran.AutoSize = true;
            this.lblEnduktifOran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEnduktifOran.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnduktifOran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEnduktifOran.Location = new System.Drawing.Point(3, 0);
            this.lblEnduktifOran.Name = "lblEnduktifOran";
            this.lblEnduktifOran.Size = new System.Drawing.Size(137, 17);
            this.lblEnduktifOran.TabIndex = 0;
            this.lblEnduktifOran.Text = "Endüktif Oran: %0,00";
            // 
            // lblKapasitifOran
            // 
            this.lblKapasitifOran.AutoSize = true;
            this.lblKapasitifOran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKapasitifOran.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKapasitifOran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKapasitifOran.Location = new System.Drawing.Point(3, 30);
            this.lblKapasitifOran.Name = "lblKapasitifOran";
            this.lblKapasitifOran.Size = new System.Drawing.Size(141, 17);
            this.lblKapasitifOran.TabIndex = 1;
            this.lblKapasitifOran.Text = "Kapasitif Oran: %0,00";
            // 
            // lblEnduktifLimit
            // 
            this.lblEnduktifLimit.AutoSize = true;
            this.lblEnduktifLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEnduktifLimit.Depth = 0;
            this.lblEnduktifLimit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnduktifLimit.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblEnduktifLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEnduktifLimit.Location = new System.Drawing.Point(239, 0);
            this.lblEnduktifLimit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnduktifLimit.Name = "lblEnduktifLimit";
            this.lblEnduktifLimit.Size = new System.Drawing.Size(65, 14);
            this.lblEnduktifLimit.TabIndex = 2;
            this.lblEnduktifLimit.Text = "(Limit: %20)";
            // 
            // lblKapasitifLimit
            // 
            this.lblKapasitifLimit.AutoSize = true;
            this.lblKapasitifLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblKapasitifLimit.Depth = 0;
            this.lblKapasitifLimit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKapasitifLimit.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblKapasitifLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKapasitifLimit.Location = new System.Drawing.Point(239, 30);
            this.lblKapasitifLimit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKapasitifLimit.Name = "lblKapasitifLimit";
            this.lblKapasitifLimit.Size = new System.Drawing.Size(65, 14);
            this.lblKapasitifLimit.TabIndex = 3;
            this.lblKapasitifLimit.Text = "(Limit: %15)";
            // 
            // gbCezaDurumu
            // 
            this.gbCezaDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelResults.SetColumnSpan(this.gbCezaDurumu, 2);
            this.gbCezaDurumu.Controls.Add(this.lblCezaDurumuSonuc);
            this.gbCezaDurumu.Depth = 0;
            this.gbCezaDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCezaDurumu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbCezaDurumu.Location = new System.Drawing.Point(5, 63);
            this.gbCezaDurumu.Margin = new System.Windows.Forms.Padding(5);
            this.gbCezaDurumu.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbCezaDurumu.Name = "gbCezaDurumu";
            this.gbCezaDurumu.Padding = new System.Windows.Forms.Padding(5);
            this.gbCezaDurumu.Size = new System.Drawing.Size(384, 56);
            this.gbCezaDurumu.TabIndex = 4;
            // 
            // lblCezaDurumuSonuc
            // 
            this.lblCezaDurumuSonuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCezaDurumuSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCezaDurumuSonuc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCezaDurumuSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCezaDurumuSonuc.Location = new System.Drawing.Point(5, 5);
            this.lblCezaDurumuSonuc.Name = "lblCezaDurumuSonuc";
            this.lblCezaDurumuSonuc.Size = new System.Drawing.Size(374, 46);
            this.lblCezaDurumuSonuc.TabIndex = 0;
            this.lblCezaDurumuSonuc.Text = "CEZA YOK";
            this.lblCezaDurumuSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.dgvHesaplamalar);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(464, 14);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.tableLayoutPanelContent.SetRowSpan(this.cardGrid, 2);
            this.cardGrid.Size = new System.Drawing.Size(860, 468);
            this.cardGrid.TabIndex = 2;
            // 
            // dgvHesaplamalar
            // 
            this.dgvHesaplamalar.AllowUserToAddRows = false;
            this.dgvHesaplamalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHesaplamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHesaplamalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHesaplamalar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvHesaplamalar.Location = new System.Drawing.Point(14, 14);
            this.dgvHesaplamalar.MultiSelect = false;
            this.dgvHesaplamalar.Name = "dgvHesaplamalar";
            this.dgvHesaplamalar.ReadOnly = true;
            this.dgvHesaplamalar.RowHeadersWidth = 51;
            this.dgvHesaplamalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHesaplamalar.Size = new System.Drawing.Size(832, 440);
            this.dgvHesaplamalar.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlActions.Controls.Add(this.btnExcelAl);
            this.pnlActions.Controls.Add(this.btnExcelAktar);
            this.pnlActions.Controls.Add(this.btnPdfRapor);
            this.pnlActions.Controls.Add(this.btnYenile);
            this.pnlActions.Controls.Add(this.btnSil);
            this.pnlActions.Controls.Add(this.btnKapat);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlActions.Location = new System.Drawing.Point(3, 605);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1338, 54);
            this.pnlActions.TabIndex = 2;
            // 
            // btnExcelAl
            // 
            this.btnExcelAl.AutoSize = false;
            this.btnExcelAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcelAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExcelAl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcelAl.Depth = 0;
            this.btnExcelAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcelAl.HighEmphasis = true;
            this.btnExcelAl.Icon = null;
            this.btnExcelAl.Location = new System.Drawing.Point(10, 10);
            this.btnExcelAl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcelAl.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcelAl.Name = "btnExcelAl";
            this.btnExcelAl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcelAl.Size = new System.Drawing.Size(150, 36);
            this.btnExcelAl.TabIndex = 0;
            this.btnExcelAl.Text = "Excel\'den Al";
            this.btnExcelAl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcelAl.UseAccentColor = false;
            this.btnExcelAl.UseVisualStyleBackColor = false;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.AutoSize = false;
            this.btnExcelAktar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcelAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExcelAktar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcelAktar.Depth = 0;
            this.btnExcelAktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcelAktar.HighEmphasis = true;
            this.btnExcelAktar.Icon = null;
            this.btnExcelAktar.Location = new System.Drawing.Point(170, 10);
            this.btnExcelAktar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcelAktar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcelAktar.Size = new System.Drawing.Size(150, 36);
            this.btnExcelAktar.TabIndex = 1;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcelAktar.UseAccentColor = false;
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            // 
            // btnPdfRapor
            // 
            this.btnPdfRapor.AutoSize = false;
            this.btnPdfRapor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdfRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPdfRapor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPdfRapor.Depth = 0;
            this.btnPdfRapor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPdfRapor.HighEmphasis = true;
            this.btnPdfRapor.Icon = null;
            this.btnPdfRapor.Location = new System.Drawing.Point(330, 10);
            this.btnPdfRapor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPdfRapor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdfRapor.Name = "btnPdfRapor";
            this.btnPdfRapor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPdfRapor.Size = new System.Drawing.Size(180, 36);
            this.btnPdfRapor.TabIndex = 2;
            this.btnPdfRapor.Text = "PDF Rapor Oluþtur";
            this.btnPdfRapor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPdfRapor.UseAccentColor = false;
            this.btnPdfRapor.UseVisualStyleBackColor = false;
            // 
            // btnYenile
            // 
            this.btnYenile.AutoSize = false;
            this.btnYenile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnYenile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYenile.Depth = 0;
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYenile.HighEmphasis = true;
            this.btnYenile.Icon = null;
            this.btnYenile.Location = new System.Drawing.Point(520, 10);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYenile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYenile.Size = new System.Drawing.Size(120, 36);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnYenile.UseAccentColor = false;
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = false;
            this.btnSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSil.Depth = 0;
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.HighEmphasis = true;
            this.btnSil.Icon = null;
            this.btnSil.Location = new System.Drawing.Point(650, 10);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSil.Size = new System.Drawing.Size(150, 36);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Seçili Kaydý Sil";
            this.btnSil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSil.UseAccentColor = false;
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.AutoSize = false;
            this.btnKapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnKapat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKapat.Depth = 0;
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.HighEmphasis = true;
            this.btnKapat.Icon = null;
            this.btnKapat.Location = new System.Drawing.Point(1208, 10);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKapat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKapat.Size = new System.Drawing.Size(120, 36);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKapat.UseAccentColor = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // FrmHesaplamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FrmHesaplamalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kompanzasyon Hesaplamalarý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.PerformLayout();
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardInputs.ResumeLayout(false);
            this.cardResults.ResumeLayout(false);
            this.tableLayoutPanelResults.ResumeLayout(false);
            this.tableLayoutPanelResults.PerformLayout();
            this.gbCezaDurumu.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesaplamalar)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilter;
        private MaterialSkin.Controls.MaterialComboBox cmbSirketFiltrele;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private MaterialSkin.Controls.MaterialButton btnFiltrele;
        private MaterialSkin.Controls.MaterialButton btnFiltreyiTemizle;
        private MaterialSkin.Controls.MaterialLabel lblBaslangic;
        private MaterialSkin.Controls.MaterialLabel lblBitis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private MaterialSkin.Controls.MaterialCard cardInputs;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private MaterialSkin.Controls.MaterialComboBox cmbSirket;
        private MaterialSkin.Controls.MaterialTextBox2 txtOncekiAktif;
        private MaterialSkin.Controls.MaterialTextBox2 txtOncekiEnduktif;
        private MaterialSkin.Controls.MaterialTextBox2 txtOncekiKpstfTuketim;
        private MaterialSkin.Controls.MaterialTextBox2 txtAktif;
        private MaterialSkin.Controls.MaterialTextBox2 txtEnduktif;
        private MaterialSkin.Controls.MaterialTextBox2 txtKapasitif;
        private MaterialSkin.Controls.MaterialButton btnHesapla;
        private MaterialSkin.Controls.MaterialButton btnTemizle;
        private MaterialSkin.Controls.MaterialCard cardResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResults;
        private System.Windows.Forms.Label lblEnduktifOran;
        private System.Windows.Forms.Label lblKapasitifOran;
        private MaterialSkin.Controls.MaterialLabel lblEnduktifLimit;
        private MaterialSkin.Controls.MaterialLabel lblKapasitifLimit;
        private MaterialSkin.Controls.MaterialCard gbCezaDurumu;
        private System.Windows.Forms.Label lblCezaDurumuSonuc;
        private MaterialSkin.Controls.MaterialCard cardGrid;
        private System.Windows.Forms.DataGridView dgvHesaplamalar;
        private System.Windows.Forms.Panel pnlActions;
        private MaterialSkin.Controls.MaterialButton btnExcelAl;
        private MaterialSkin.Controls.MaterialButton btnExcelAktar;
        private MaterialSkin.Controls.MaterialButton btnPdfRapor;
        private MaterialSkin.Controls.MaterialButton btnYenile;
        private MaterialSkin.Controls.MaterialButton btnSil;
        private MaterialSkin.Controls.MaterialButton btnKapat;
    }
}
