namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmSifreDegistir
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
            this.cardMain = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.txtEskiSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtYeniSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtYeniSifreTekrar = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnIptal = new MaterialSkin.Controls.MaterialButton();
            this.btnKaydet = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.cardMain, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // cardMain
            // 
            this.cardMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardMain.Controls.Add(this.tableLayoutPanelContent);
            this.cardMain.Depth = 0;
            this.cardMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardMain.Location = new System.Drawing.Point(211, 30);
            this.cardMain.Margin = new System.Windows.Forms.Padding(14);
            this.cardMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardMain.Name = "cardMain";
            this.cardMain.Padding = new System.Windows.Forms.Padding(14);
            this.cardMain.Size = new System.Drawing.Size(372, 322);
            this.cardMain.TabIndex = 0;
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelContent.ColumnCount = 1;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.txtEskiSifre, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.txtYeniSifre, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.txtYeniSifreTekrar, 0, 2);
            this.tableLayoutPanelContent.Controls.Add(this.pnlButtons, 0, 3);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 4;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(344, 294);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.AnimateReadOnly = false;
            this.txtEskiSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEskiSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEskiSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEskiSifre.Depth = 0;
            this.txtEskiSifre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEskiSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEskiSifre.HideSelection = true;
            this.txtEskiSifre.Hint = "Eski Şifre";
            this.txtEskiSifre.LeadingIcon = null;
            this.txtEskiSifre.Location = new System.Drawing.Point(3, 3);
            this.txtEskiSifre.MaxLength = 32767;
            this.txtEskiSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.PasswordChar = '●';
            this.txtEskiSifre.PrefixSuffixText = null;
            this.txtEskiSifre.ReadOnly = false;
            this.txtEskiSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEskiSifre.SelectedText = "";
            this.txtEskiSifre.SelectionLength = 0;
            this.txtEskiSifre.SelectionStart = 0;
            this.txtEskiSifre.ShortcutsEnabled = true;
            this.txtEskiSifre.Size = new System.Drawing.Size(338, 48);
            this.txtEskiSifre.TabIndex = 0;
            this.txtEskiSifre.TabStop = false;
            this.txtEskiSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEskiSifre.TrailingIcon = null;
            this.txtEskiSifre.UseAccent = false;
            this.txtEskiSifre.UseSystemPasswordChar = true;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.AnimateReadOnly = false;
            this.txtYeniSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtYeniSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtYeniSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtYeniSifre.Depth = 0;
            this.txtYeniSifre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeniSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYeniSifre.HideSelection = true;
            this.txtYeniSifre.Hint = "Yeni Şifre";
            this.txtYeniSifre.LeadingIcon = null;
            this.txtYeniSifre.Location = new System.Drawing.Point(3, 73);
            this.txtYeniSifre.MaxLength = 32767;
            this.txtYeniSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '●';
            this.txtYeniSifre.PrefixSuffixText = null;
            this.txtYeniSifre.ReadOnly = false;
            this.txtYeniSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYeniSifre.SelectedText = "";
            this.txtYeniSifre.SelectionLength = 0;
            this.txtYeniSifre.SelectionStart = 0;
            this.txtYeniSifre.ShortcutsEnabled = true;
            this.txtYeniSifre.Size = new System.Drawing.Size(338, 48);
            this.txtYeniSifre.TabIndex = 1;
            this.txtYeniSifre.TabStop = false;
            this.txtYeniSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYeniSifre.TrailingIcon = null;
            this.txtYeniSifre.UseAccent = false;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.AnimateReadOnly = false;
            this.txtYeniSifreTekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtYeniSifreTekrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtYeniSifreTekrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtYeniSifreTekrar.Depth = 0;
            this.txtYeniSifreTekrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYeniSifreTekrar.HideSelection = true;
            this.txtYeniSifreTekrar.Hint = "Yeni Şifre (Tekrar)";
            this.txtYeniSifreTekrar.LeadingIcon = null;
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(3, 143);
            this.txtYeniSifreTekrar.MaxLength = 32767;
            this.txtYeniSifreTekrar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.PasswordChar = '●';
            this.txtYeniSifreTekrar.PrefixSuffixText = null;
            this.txtYeniSifreTekrar.ReadOnly = false;
            this.txtYeniSifreTekrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYeniSifreTekrar.SelectedText = "";
            this.txtYeniSifreTekrar.SelectionLength = 0;
            this.txtYeniSifreTekrar.SelectionStart = 0;
            this.txtYeniSifreTekrar.ShortcutsEnabled = true;
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(338, 48);
            this.txtYeniSifreTekrar.TabIndex = 2;
            this.txtYeniSifreTekrar.TabStop = false;
            this.txtYeniSifreTekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYeniSifreTekrar.TrailingIcon = null;
            this.txtYeniSifreTekrar.UseAccent = false;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlButtons.Controls.Add(this.btnIptal);
            this.pnlButtons.Controls.Add(this.btnKaydet);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlButtons.Location = new System.Drawing.Point(3, 213);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(338, 78);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnIptal
            // 
            this.btnIptal.AutoSize = false;
            this.btnIptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIptal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIptal.Depth = 0;
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIptal.HighEmphasis = true;
            this.btnIptal.Icon = null;
            this.btnIptal.Location = new System.Drawing.Point(4, 20);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIptal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIptal.Size = new System.Drawing.Size(157, 36);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnIptal.UseAccentColor = false;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
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
            this.btnKaydet.Location = new System.Drawing.Point(177, 20);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKaydet.Size = new System.Drawing.Size(157, 36);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKaydet.UseAccentColor = false;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FrmSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenlik - Şifre Değiştirme";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private MaterialSkin.Controls.MaterialTextBox2 txtEskiSifre;
        private MaterialSkin.Controls.MaterialTextBox2 txtYeniSifre;
        private MaterialSkin.Controls.MaterialTextBox2 txtYeniSifreTekrar;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnKaydet;
        private MaterialSkin.Controls.MaterialButton btnIptal;
    }
}
