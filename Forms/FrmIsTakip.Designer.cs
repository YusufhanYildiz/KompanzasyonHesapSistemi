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
            this.txtIsUcreti = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAlinanTutar = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIsAciklamasi = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblBakiyeGoster = new System.Windows.Forms.Label();
            this.btnKaydet = new MaterialSkin.Controls.MaterialButton();
            this.btnGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnTemizle = new MaterialSkin.Controls.MaterialButton();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvIsler = new System.Windows.Forms.DataGridView();
            this.cardSummary = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanelSummary = new System.Windows.Forms.TableLayoutPanel();
            this.lblToplamIsSayisi = new MaterialSkin.Controls.MaterialLabel();
            this.lblToplamIsUcreti = new MaterialSkin.Controls.MaterialLabel();
            this.lblToplamAlinan = new MaterialSkin.Controls.MaterialLabel();
            this.lblToplamBakiye = new System.Windows.Forms.Label();
            this.btnOzetRapor = new MaterialSkin.Controls.MaterialButton();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnExcelAl = new MaterialSkin.Controls.MaterialButton();
            this.btnExcelAktar = new MaterialSkin.Controls.MaterialButton();
            this.btnYenile = new MaterialSkin.Controls.MaterialButton();
            this.btnSil = new MaterialSkin.Controls.MaterialButton();
            this.btnKapat = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardFilter.SuspendLayout();
            this.tableLayoutPanelFilter.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardInputs.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsler)).BeginInit();
            this.cardSummary.SuspendLayout();
            this.tableLayoutPanelSummary.SuspendLayout();
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1178, 647);
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
            this.cardFilter.Size = new System.Drawing.Size(1150, 72);
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
            this.tableLayoutPanelFilter.Size = new System.Drawing.Size(1122, 44);
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
            this.cmbSirketFiltrele.Size = new System.Drawing.Size(224, 49);
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
            this.dtpBaslangic.Location = new System.Drawing.Point(333, 10);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(178, 24);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpBitis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBitis.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpBitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(617, 10);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(178, 24);
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
            this.btnFiltrele.Location = new System.Drawing.Point(802, 6);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFiltrele.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFiltrele.Size = new System.Drawing.Size(153, 32);
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
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(963, 6);
            this.btnFiltreyiTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFiltreyiTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            this.btnFiltreyiTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFiltreyiTemizle.Size = new System.Drawing.Size(155, 32);
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
            this.lblBaslangic.Location = new System.Drawing.Point(233, 0);
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
            this.lblBitis.Location = new System.Drawing.Point(517, 0);
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
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.cardInputs, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.cardGrid, 1, 0);
            this.tableLayoutPanelContent.Controls.Add(this.cardSummary, 1, 1);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 2;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(1172, 481);
            this.tableLayoutPanelContent.TabIndex = 1;
            // 
            // cardInputs
            // 
            this.cardInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardInputs.Controls.Add(this.dtpTarih);
            this.cardInputs.Controls.Add(this.cmbSirket);
            this.cardInputs.Controls.Add(this.txtIsUcreti);
            this.cardInputs.Controls.Add(this.txtAlinanTutar);
            this.cardInputs.Controls.Add(this.txtIsAciklamasi);
            this.cardInputs.Controls.Add(this.lblBakiyeGoster);
            this.cardInputs.Controls.Add(this.btnKaydet);
            this.cardInputs.Controls.Add(this.btnGuncelle);
            this.cardInputs.Controls.Add(this.btnTemizle);
            this.cardInputs.Depth = 0;
            this.cardInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInputs.Location = new System.Drawing.Point(14, 14);
            this.cardInputs.Margin = new System.Windows.Forms.Padding(14);
            this.cardInputs.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardInputs.Name = "cardInputs";
            this.cardInputs.Padding = new System.Windows.Forms.Padding(14);
            this.tableLayoutPanelContent.SetRowSpan(this.cardInputs, 2);
            this.cardInputs.Size = new System.Drawing.Size(372, 453);
            this.cardInputs.TabIndex = 0;
            // 
            // dtpTarih
            // 
            this.dtpTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpTarih.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpTarih.Location = new System.Drawing.Point(17, 17);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(338, 24);
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
            this.cmbSirket.Location = new System.Drawing.Point(17, 43);
            this.cmbSirket.MaxDropDownItems = 4;
            this.cmbSirket.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSirket.Name = "cmbSirket";
            this.cmbSirket.Size = new System.Drawing.Size(338, 49);
            this.cmbSirket.StartIndex = 0;
            this.cmbSirket.TabIndex = 1;
            this.cmbSirket.UseAccent = false;
            // 
            // txtIsUcreti
            // 
            this.txtIsUcreti.AnimateReadOnly = false;
            this.txtIsUcreti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIsUcreti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIsUcreti.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIsUcreti.Depth = 0;
            this.txtIsUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIsUcreti.HideSelection = true;
            this.txtIsUcreti.Hint = "Ýþ Ücreti";
            this.txtIsUcreti.LeadingIcon = null;
            this.txtIsUcreti.Location = new System.Drawing.Point(17, 98);
            this.txtIsUcreti.MaxLength = 32767;
            this.txtIsUcreti.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIsUcreti.Name = "txtIsUcreti";
            this.txtIsUcreti.PasswordChar = '\0';
            this.txtIsUcreti.PrefixSuffixText = null;
            this.txtIsUcreti.ReadOnly = false;
            this.txtIsUcreti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIsUcreti.SelectedText = "";
            this.txtIsUcreti.SelectionLength = 0;
            this.txtIsUcreti.SelectionStart = 0;
            this.txtIsUcreti.ShortcutsEnabled = true;
            this.txtIsUcreti.Size = new System.Drawing.Size(338, 48);
            this.txtIsUcreti.TabIndex = 2;
            this.txtIsUcreti.TabStop = false;
            this.txtIsUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIsUcreti.TrailingIcon = null;
            this.txtIsUcreti.UseAccent = false;
            this.txtIsUcreti.UseSystemPasswordChar = false;
            // 
            // txtAlinanTutar
            // 
            this.txtAlinanTutar.AnimateReadOnly = false;
            this.txtAlinanTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAlinanTutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAlinanTutar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAlinanTutar.Depth = 0;
            this.txtAlinanTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlinanTutar.HideSelection = true;
            this.txtAlinanTutar.Hint = "Alýnan Tutar";
            this.txtAlinanTutar.LeadingIcon = null;
            this.txtAlinanTutar.Location = new System.Drawing.Point(17, 152);
            this.txtAlinanTutar.MaxLength = 32767;
            this.txtAlinanTutar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlinanTutar.Name = "txtAlinanTutar";
            this.txtAlinanTutar.PasswordChar = '\0';
            this.txtAlinanTutar.PrefixSuffixText = null;
            this.txtAlinanTutar.ReadOnly = false;
            this.txtAlinanTutar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlinanTutar.SelectedText = "";
            this.txtAlinanTutar.SelectionLength = 0;
            this.txtAlinanTutar.SelectionStart = 0;
            this.txtAlinanTutar.ShortcutsEnabled = true;
            this.txtAlinanTutar.Size = new System.Drawing.Size(338, 48);
            this.txtAlinanTutar.TabIndex = 3;
            this.txtAlinanTutar.TabStop = false;
            this.txtAlinanTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAlinanTutar.TrailingIcon = null;
            this.txtAlinanTutar.UseAccent = false;
            this.txtAlinanTutar.UseSystemPasswordChar = false;
            // 
            // txtIsAciklamasi
            // 
            this.txtIsAciklamasi.AnimateReadOnly = false;
            this.txtIsAciklamasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIsAciklamasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIsAciklamasi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIsAciklamasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsAciklamasi.Depth = 0;
            this.txtIsAciklamasi.HideSelection = true;
            this.txtIsAciklamasi.Hint = "Ýþ Açýklamasý";
            this.txtIsAciklamasi.Location = new System.Drawing.Point(17, 206);
            this.txtIsAciklamasi.MaxLength = 32767;
            this.txtIsAciklamasi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIsAciklamasi.Name = "txtIsAciklamasi";
            this.txtIsAciklamasi.PasswordChar = '\0';
            this.txtIsAciklamasi.ReadOnly = false;
            this.txtIsAciklamasi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIsAciklamasi.SelectedText = "";
            this.txtIsAciklamasi.SelectionLength = 0;
            this.txtIsAciklamasi.SelectionStart = 0;
            this.txtIsAciklamasi.ShortcutsEnabled = true;
            this.txtIsAciklamasi.Size = new System.Drawing.Size(338, 100);
            this.txtIsAciklamasi.TabIndex = 4;
            this.txtIsAciklamasi.TabStop = false;
            this.txtIsAciklamasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIsAciklamasi.UseAccent = false;
            this.txtIsAciklamasi.UseSystemPasswordChar = false;
            // 
            // lblBakiyeGoster
            // 
            this.lblBakiyeGoster.AutoSize = true;
            this.lblBakiyeGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBakiyeGoster.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBakiyeGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBakiyeGoster.Location = new System.Drawing.Point(17, 315);
            this.lblBakiyeGoster.Name = "lblBakiyeGoster";
            this.lblBakiyeGoster.Size = new System.Drawing.Size(82, 17);
            this.lblBakiyeGoster.TabIndex = 5;
            this.lblBakiyeGoster.Text = "Bakiye: 0,00";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = false;
            this.btnKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnKaydet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKaydet.Depth = 0;
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKaydet.HighEmphasis = true;
            this.btnKaydet.Icon = null;
            this.btnKaydet.Location = new System.Drawing.Point(17, 355);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKaydet.Size = new System.Drawing.Size(338, 36);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKaydet.UseAccentColor = false;
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = false;
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuncelle.Depth = 0;
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuncelle.HighEmphasis = true;
            this.btnGuncelle.Icon = null;
            this.btnGuncelle.Location = new System.Drawing.Point(17, 400);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuncelle.Size = new System.Drawing.Size(165, 36);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuncelle.UseAccentColor = false;
            this.btnGuncelle.UseVisualStyleBackColor = false;
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
            this.btnTemizle.Location = new System.Drawing.Point(190, 400);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTemizle.Size = new System.Drawing.Size(165, 36);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTemizle.UseAccentColor = false;
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.dgvIsler);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(414, 14);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.cardGrid.Size = new System.Drawing.Size(744, 303);
            this.cardGrid.TabIndex = 1;
            // 
            // dgvIsler
            // 
            this.dgvIsler.AllowUserToAddRows = false;
            this.dgvIsler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsler.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvIsler.Location = new System.Drawing.Point(14, 14);
            this.dgvIsler.MultiSelect = false;
            this.dgvIsler.Name = "dgvIsler";
            this.dgvIsler.ReadOnly = true;
            this.dgvIsler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsler.Size = new System.Drawing.Size(716, 275);
            this.dgvIsler.TabIndex = 0;
            // 
            // cardSummary
            // 
            this.cardSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSummary.Controls.Add(this.tableLayoutPanelSummary);
            this.cardSummary.Depth = 0;
            this.cardSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSummary.Location = new System.Drawing.Point(414, 345);
            this.cardSummary.Margin = new System.Windows.Forms.Padding(14);
            this.cardSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSummary.Name = "cardSummary";
            this.cardSummary.Padding = new System.Windows.Forms.Padding(14);
            this.cardSummary.Size = new System.Drawing.Size(744, 122);
            this.cardSummary.TabIndex = 2;
            // 
            // tableLayoutPanelSummary
            // 
            this.tableLayoutPanelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelSummary.ColumnCount = 3;
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelSummary.Controls.Add(this.lblToplamIsSayisi, 0, 0);
            this.tableLayoutPanelSummary.Controls.Add(this.lblToplamIsUcreti, 1, 0);
            this.tableLayoutPanelSummary.Controls.Add(this.lblToplamAlinan, 2, 0);
            this.tableLayoutPanelSummary.Controls.Add(this.lblToplamBakiye, 0, 1);
            this.tableLayoutPanelSummary.Controls.Add(this.btnOzetRapor, 2, 1);
            this.tableLayoutPanelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSummary.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelSummary.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            this.tableLayoutPanelSummary.RowCount = 2;
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSummary.Size = new System.Drawing.Size(716, 94);
            this.tableLayoutPanelSummary.TabIndex = 0;
            // 
            // lblToplamIsSayisi
            // 
            this.lblToplamIsSayisi.AutoSize = true;
            this.lblToplamIsSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblToplamIsSayisi.Depth = 0;
            this.lblToplamIsSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamIsSayisi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToplamIsSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamIsSayisi.Location = new System.Drawing.Point(3, 0);
            this.lblToplamIsSayisi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToplamIsSayisi.Name = "lblToplamIsSayisi";
            this.lblToplamIsSayisi.Size = new System.Drawing.Size(232, 47);
            this.lblToplamIsSayisi.TabIndex = 0;
            this.lblToplamIsSayisi.Text = "Toplam Ýþ: 0";
            this.lblToplamIsSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToplamIsUcreti
            // 
            this.lblToplamIsUcreti.AutoSize = true;
            this.lblToplamIsUcreti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblToplamIsUcreti.Depth = 0;
            this.lblToplamIsUcreti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamIsUcreti.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToplamIsUcreti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamIsUcreti.Location = new System.Drawing.Point(241, 0);
            this.lblToplamIsUcreti.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToplamIsUcreti.Name = "lblToplamIsUcreti";
            this.lblToplamIsUcreti.Size = new System.Drawing.Size(232, 47);
            this.lblToplamIsUcreti.TabIndex = 1;
            this.lblToplamIsUcreti.Text = "Toplam Ýþ Ücreti: 0,00";
            this.lblToplamIsUcreti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToplamAlinan
            // 
            this.lblToplamAlinan.AutoSize = true;
            this.lblToplamAlinan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblToplamAlinan.Depth = 0;
            this.lblToplamAlinan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamAlinan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToplamAlinan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamAlinan.Location = new System.Drawing.Point(479, 0);
            this.lblToplamAlinan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToplamAlinan.Name = "lblToplamAlinan";
            this.lblToplamAlinan.Size = new System.Drawing.Size(234, 47);
            this.lblToplamAlinan.TabIndex = 2;
            this.lblToplamAlinan.Text = "Toplam Alýnan: 0,00";
            this.lblToplamAlinan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToplamBakiye
            // 
            this.lblToplamBakiye.AutoSize = true;
            this.lblToplamBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelSummary.SetColumnSpan(this.lblToplamBakiye, 2);
            this.lblToplamBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplamBakiye.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToplamBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamBakiye.Location = new System.Drawing.Point(3, 47);
            this.lblToplamBakiye.Name = "lblToplamBakiye";
            this.lblToplamBakiye.Size = new System.Drawing.Size(470, 47);
            this.lblToplamBakiye.TabIndex = 3;
            this.lblToplamBakiye.Text = "TOPLAM BAKÝYE: 0,00";
            this.lblToplamBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOzetRapor
            // 
            this.btnOzetRapor.AutoSize = false;
            this.btnOzetRapor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOzetRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnOzetRapor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOzetRapor.Depth = 0;
            this.btnOzetRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOzetRapor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOzetRapor.HighEmphasis = true;
            this.btnOzetRapor.Icon = null;
            this.btnOzetRapor.Location = new System.Drawing.Point(480, 53);
            this.btnOzetRapor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOzetRapor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOzetRapor.Name = "btnOzetRapor";
            this.btnOzetRapor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOzetRapor.Size = new System.Drawing.Size(232, 35);
            this.btnOzetRapor.TabIndex = 4;
            this.btnOzetRapor.Text = "Özet Rapor Al";
            this.btnOzetRapor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOzetRapor.UseAccentColor = false;
            this.btnOzetRapor.UseVisualStyleBackColor = false;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlActions.Controls.Add(this.btnExcelAl);
            this.pnlActions.Controls.Add(this.btnExcelAktar);
            this.pnlActions.Controls.Add(this.btnYenile);
            this.pnlActions.Controls.Add(this.btnSil);
            this.pnlActions.Controls.Add(this.btnKapat);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlActions.Location = new System.Drawing.Point(3, 590);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1172, 54);
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
            this.btnYenile.Location = new System.Drawing.Point(330, 10);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYenile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYenile.Size = new System.Drawing.Size(120, 36);
            this.btnYenile.TabIndex = 2;
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
            this.btnSil.Location = new System.Drawing.Point(460, 10);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSil.Size = new System.Drawing.Size(120, 36);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Seçili Sil";
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
            this.btnKapat.Location = new System.Drawing.Point(1042, 10);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKapat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKapat.Size = new System.Drawing.Size(120, 36);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKapat.UseAccentColor = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // FrmIsTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 714);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FrmIsTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ýþ Takip Sistemi";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.PerformLayout();
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardInputs.ResumeLayout(false);
            this.cardInputs.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsler)).EndInit();
            this.cardSummary.ResumeLayout(false);
            this.tableLayoutPanelSummary.ResumeLayout(false);
            this.tableLayoutPanelSummary.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox2 txtIsUcreti;
        private MaterialSkin.Controls.MaterialTextBox2 txtAlinanTutar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtIsAciklamasi;
        private System.Windows.Forms.Label lblBakiyeGoster;
        private MaterialSkin.Controls.MaterialButton btnKaydet;
        private MaterialSkin.Controls.MaterialButton btnGuncelle;
        private MaterialSkin.Controls.MaterialButton btnTemizle;
        private MaterialSkin.Controls.MaterialCard cardGrid;
        private System.Windows.Forms.DataGridView dgvIsler;
        private MaterialSkin.Controls.MaterialCard cardSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummary;
        private MaterialSkin.Controls.MaterialLabel lblToplamIsSayisi;
        private MaterialSkin.Controls.MaterialLabel lblToplamIsUcreti;
        private MaterialSkin.Controls.MaterialLabel lblToplamAlinan;
        private System.Windows.Forms.Label lblToplamBakiye;
        private MaterialSkin.Controls.MaterialButton btnOzetRapor;
        private System.Windows.Forms.Panel pnlActions;
        private MaterialSkin.Controls.MaterialButton btnExcelAl;
        private MaterialSkin.Controls.MaterialButton btnExcelAktar;
        private MaterialSkin.Controls.MaterialButton btnYenile;
        private MaterialSkin.Controls.MaterialButton btnSil;
        private MaterialSkin.Controls.MaterialButton btnKapat;
    }
}
