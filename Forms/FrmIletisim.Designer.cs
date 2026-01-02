namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmIletisim
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
            this.cardIletisim = new MaterialSkin.Controls.MaterialCard();
            this.lblTelefon = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.cardBizeYazin = new MaterialSkin.Controls.MaterialCard();
            this.btnGonder = new MaterialSkin.Controls.MaterialButton();
            this.txtMesaj = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cmbKonu = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAdSoyad = new MaterialSkin.Controls.MaterialTextBox2();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardIletisim.SuspendLayout();
            this.cardBizeYazin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.cardIletisim, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cardBizeYazin, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(810, 472);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // cardIletisim
            // 
            this.cardIletisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardIletisim.Controls.Add(this.lblTelefon);
            this.cardIletisim.Controls.Add(this.lblEmail);
            this.cardIletisim.Controls.Add(this.label2);
            this.cardIletisim.Controls.Add(this.label1);
            this.cardIletisim.Depth = 0;
            this.cardIletisim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardIletisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardIletisim.Location = new System.Drawing.Point(14, 14);
            this.cardIletisim.Margin = new System.Windows.Forms.Padding(14);
            this.cardIletisim.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardIletisim.Name = "cardIletisim";
            this.cardIletisim.Padding = new System.Windows.Forms.Padding(14);
            this.cardIletisim.Size = new System.Drawing.Size(272, 444);
            this.cardIletisim.TabIndex = 0;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTelefon.Depth = 0;
            this.lblTelefon.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefon.Location = new System.Drawing.Point(17, 140);
            this.lblTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(130, 19);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "+90 552 574 5761";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(17, 60);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(212, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "yusufhanyildiz10@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Posta:";
            // 
            // cardBizeYazin
            // 
            this.cardBizeYazin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardBizeYazin.Controls.Add(this.btnGonder);
            this.cardBizeYazin.Controls.Add(this.txtMesaj);
            this.cardBizeYazin.Controls.Add(this.cmbKonu);
            this.cardBizeYazin.Controls.Add(this.txtEmail);
            this.cardBizeYazin.Controls.Add(this.txtAdSoyad);
            this.cardBizeYazin.Depth = 0;
            this.cardBizeYazin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBizeYazin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardBizeYazin.Location = new System.Drawing.Point(314, 14);
            this.cardBizeYazin.Margin = new System.Windows.Forms.Padding(14);
            this.cardBizeYazin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardBizeYazin.Name = "cardBizeYazin";
            this.cardBizeYazin.Padding = new System.Windows.Forms.Padding(14);
            this.cardBizeYazin.Size = new System.Drawing.Size(482, 444);
            this.cardBizeYazin.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.AutoSize = false;
            this.btnGonder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnGonder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGonder.Depth = 0;
            this.btnGonder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGonder.HighEmphasis = true;
            this.btnGonder.Icon = null;
            this.btnGonder.Location = new System.Drawing.Point(14, 394);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGonder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGonder.Size = new System.Drawing.Size(454, 36);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGonder.UseAccentColor = false;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.AnimateReadOnly = false;
            this.txtMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMesaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMesaj.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMesaj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMesaj.Depth = 0;
            this.txtMesaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMesaj.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMesaj.HideSelection = true;
            this.txtMesaj.Hint = "Mesaj / Detay";
            this.txtMesaj.Location = new System.Drawing.Point(14, 159);
            this.txtMesaj.MaxLength = 32767;
            this.txtMesaj.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.PasswordChar = '\0';
            this.txtMesaj.ReadOnly = false;
            this.txtMesaj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMesaj.SelectedText = "";
            this.txtMesaj.SelectionLength = 0;
            this.txtMesaj.SelectionStart = 0;
            this.txtMesaj.ShortcutsEnabled = true;
            this.txtMesaj.Size = new System.Drawing.Size(454, 120);
            this.txtMesaj.TabIndex = 3;
            this.txtMesaj.TabStop = false;
            this.txtMesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMesaj.UseAccent = false;
            this.txtMesaj.UseSystemPasswordChar = false;
            // 
            // cmbKonu
            // 
            this.cmbKonu.AutoResize = false;
            this.cmbKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbKonu.Depth = 0;
            this.cmbKonu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbKonu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbKonu.DropDownHeight = 174;
            this.cmbKonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonu.DropDownWidth = 121;
            this.cmbKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbKonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Hint = "Konu";
            this.cmbKonu.IntegralHeight = false;
            this.cmbKonu.ItemHeight = 43;
            this.cmbKonu.Items.AddRange(new object[] {
            "Satın Alma Talebi",
            "Özellik İsteği / Öneri",
            "Hata Bildirimi",
            "Diğer"});
            this.cmbKonu.Location = new System.Drawing.Point(14, 110);
            this.cmbKonu.MaxDropDownItems = 4;
            this.cmbKonu.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(454, 49);
            this.cmbKonu.StartIndex = 0;
            this.cmbKonu.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "E-Posta";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(14, 62);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(454, 48);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AnimateReadOnly = false;
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAdSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAdSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdSoyad.Depth = 0;
            this.txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdSoyad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdSoyad.HideSelection = true;
            this.txtAdSoyad.Hint = "Ad Soyad";
            this.txtAdSoyad.LeadingIcon = null;
            this.txtAdSoyad.Location = new System.Drawing.Point(14, 14);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.PrefixSuffixText = null;
            this.txtAdSoyad.ReadOnly = false;
            this.txtAdSoyad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.SelectionLength = 0;
            this.txtAdSoyad.SelectionStart = 0;
            this.txtAdSoyad.ShortcutsEnabled = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(454, 48);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.TabStop = false;
            this.txtAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdSoyad.TrailingIcon = null;
            this.txtAdSoyad.UseAccent = false;
            this.txtAdSoyad.UseSystemPasswordChar = false;
            // 
            // FrmIletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 539);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIletisim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İletişim ve Destek";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardIletisim.ResumeLayout(false);
            this.cardIletisim.PerformLayout();
            this.cardBizeYazin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardIletisim;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel lblTelefon;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialCard cardBizeYazin;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdSoyad;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtMesaj;
        private MaterialSkin.Controls.MaterialComboBox cmbKonu;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialButton btnGonder;
    }
}
