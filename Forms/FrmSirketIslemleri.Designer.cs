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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.gbSirketBilgileri = new MaterialSkin.Controls.MaterialCard();
            this.txtAdres = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtTelefon = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtVergiNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSirketAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnYeniSirket = new MaterialSkin.Controls.MaterialButton();
            this.btnGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnSil = new MaterialSkin.Controls.MaterialButton();
            this.btnTemizle = new MaterialSkin.Controls.MaterialButton();
            this.btnKapat = new MaterialSkin.Controls.MaterialButton();
            this.dgvSirketler = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelMain.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            this.gbSirketBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirketler)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.pnlInputs, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dgvSirketler, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1178, 494);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // pnlInputs
            // 
            this.pnlInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlInputs.Controls.Add(this.gbSirketBilgileri);
            this.pnlInputs.Controls.Add(this.btnYeniSirket);
            this.pnlInputs.Controls.Add(this.btnGuncelle);
            this.pnlInputs.Controls.Add(this.btnSil);
            this.pnlInputs.Controls.Add(this.btnTemizle);
            this.pnlInputs.Controls.Add(this.btnKapat);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputs.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlInputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlInputs.Location = new System.Drawing.Point(3, 3);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInputs.Size = new System.Drawing.Size(394, 488);
            this.pnlInputs.TabIndex = 0;
            // 
            // gbSirketBilgileri
            // 
            this.gbSirketBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbSirketBilgileri.Controls.Add(this.txtAdres);
            this.gbSirketBilgileri.Controls.Add(this.txtTelefon);
            this.gbSirketBilgileri.Controls.Add(this.txtVergiNo);
            this.gbSirketBilgileri.Controls.Add(this.txtSirketAdi);
            this.gbSirketBilgileri.Depth = 0;
            this.gbSirketBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbSirketBilgileri.Location = new System.Drawing.Point(10, 10);
            this.gbSirketBilgileri.Margin = new System.Windows.Forms.Padding(14);
            this.gbSirketBilgileri.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbSirketBilgileri.Name = "gbSirketBilgileri";
            this.gbSirketBilgileri.Padding = new System.Windows.Forms.Padding(14);
            this.gbSirketBilgileri.Size = new System.Drawing.Size(370, 300);
            this.gbSirketBilgileri.TabIndex = 0;
            // 
            // txtAdres
            // 
            this.txtAdres.AnimateReadOnly = false;
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAdres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAdres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdres.Depth = 0;
            this.txtAdres.HideSelection = true;
            this.txtAdres.Hint = "Adres";
            this.txtAdres.Location = new System.Drawing.Point(17, 180);
            this.txtAdres.MaxLength = 32767;
            this.txtAdres.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.ReadOnly = false;
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdres.SelectedText = "";
            this.txtAdres.SelectionLength = 0;
            this.txtAdres.SelectionStart = 0;
            this.txtAdres.ShortcutsEnabled = true;
            this.txtAdres.Size = new System.Drawing.Size(336, 100);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.TabStop = false;
            this.txtAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdres.UseAccent = false;
            this.txtAdres.UseSystemPasswordChar = false;
            // 
            // txtTelefon
            // 
            this.txtTelefon.AnimateReadOnly = false;
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.HideSelection = true;
            this.txtTelefon.Hint = "Telefon";
            this.txtTelefon.LeadingIcon = null;
            this.txtTelefon.Location = new System.Drawing.Point(17, 126);
            this.txtTelefon.MaxLength = 32767;
            this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.PrefixSuffixText = null;
            this.txtTelefon.ReadOnly = false;
            this.txtTelefon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.SelectionLength = 0;
            this.txtTelefon.SelectionStart = 0;
            this.txtTelefon.ShortcutsEnabled = true;
            this.txtTelefon.Size = new System.Drawing.Size(336, 48);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.TabStop = false;
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefon.TrailingIcon = null;
            this.txtTelefon.UseAccent = false;
            this.txtTelefon.UseSystemPasswordChar = false;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.AnimateReadOnly = false;
            this.txtVergiNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtVergiNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVergiNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVergiNo.Depth = 0;
            this.txtVergiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVergiNo.HideSelection = true;
            this.txtVergiNo.Hint = "Vergi No";
            this.txtVergiNo.LeadingIcon = null;
            this.txtVergiNo.Location = new System.Drawing.Point(17, 72);
            this.txtVergiNo.MaxLength = 32767;
            this.txtVergiNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.PasswordChar = '\0';
            this.txtVergiNo.PrefixSuffixText = null;
            this.txtVergiNo.ReadOnly = false;
            this.txtVergiNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVergiNo.SelectedText = "";
            this.txtVergiNo.SelectionLength = 0;
            this.txtVergiNo.SelectionStart = 0;
            this.txtVergiNo.ShortcutsEnabled = true;
            this.txtVergiNo.Size = new System.Drawing.Size(336, 48);
            this.txtVergiNo.TabIndex = 1;
            this.txtVergiNo.TabStop = false;
            this.txtVergiNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVergiNo.TrailingIcon = null;
            this.txtVergiNo.UseAccent = false;
            this.txtVergiNo.UseSystemPasswordChar = false;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.AnimateReadOnly = false;
            this.txtSirketAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSirketAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSirketAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSirketAdi.Depth = 0;
            this.txtSirketAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSirketAdi.HideSelection = true;
            this.txtSirketAdi.Hint = "Şirket Adı";
            this.txtSirketAdi.LeadingIcon = null;
            this.txtSirketAdi.Location = new System.Drawing.Point(17, 18);
            this.txtSirketAdi.MaxLength = 32767;
            this.txtSirketAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.PasswordChar = '\0';
            this.txtSirketAdi.PrefixSuffixText = null;
            this.txtSirketAdi.ReadOnly = false;
            this.txtSirketAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSirketAdi.SelectedText = "";
            this.txtSirketAdi.SelectionLength = 0;
            this.txtSirketAdi.SelectionStart = 0;
            this.txtSirketAdi.ShortcutsEnabled = true;
            this.txtSirketAdi.Size = new System.Drawing.Size(336, 48);
            this.txtSirketAdi.TabIndex = 0;
            this.txtSirketAdi.TabStop = false;
            this.txtSirketAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSirketAdi.TrailingIcon = null;
            this.txtSirketAdi.UseAccent = false;
            this.txtSirketAdi.UseSystemPasswordChar = false;
            // 
            // btnYeniSirket
            // 
            this.btnYeniSirket.AutoSize = false;
            this.btnYeniSirket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYeniSirket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnYeniSirket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYeniSirket.Depth = 0;
            this.btnYeniSirket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYeniSirket.HighEmphasis = true;
            this.btnYeniSirket.Icon = null;
            this.btnYeniSirket.Location = new System.Drawing.Point(10, 320);
            this.btnYeniSirket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYeniSirket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYeniSirket.Name = "btnYeniSirket";
            this.btnYeniSirket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYeniSirket.Size = new System.Drawing.Size(180, 40);
            this.btnYeniSirket.TabIndex = 1;
            this.btnYeniSirket.Text = "Yeni Şirket Ekle";
            this.btnYeniSirket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnYeniSirket.UseAccentColor = false;
            this.btnYeniSirket.UseVisualStyleBackColor = false;
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
            this.btnGuncelle.Location = new System.Drawing.Point(200, 320);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuncelle.Size = new System.Drawing.Size(180, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuncelle.UseAccentColor = false;
            this.btnGuncelle.UseVisualStyleBackColor = false;
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
            this.btnSil.Location = new System.Drawing.Point(10, 370);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSil.Size = new System.Drawing.Size(180, 40);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSil.UseAccentColor = false;
            this.btnSil.UseVisualStyleBackColor = false;
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
            this.btnTemizle.Location = new System.Drawing.Point(200, 370);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTemizle.Size = new System.Drawing.Size(180, 40);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTemizle.UseAccentColor = false;
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = false;
            this.btnKapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnKapat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKapat.Depth = 0;
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.HighEmphasis = true;
            this.btnKapat.Icon = null;
            this.btnKapat.Location = new System.Drawing.Point(10, 430);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKapat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKapat.Size = new System.Drawing.Size(370, 40);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKapat.UseAccentColor = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // dgvSirketler
            // 
            this.dgvSirketler.AllowUserToAddRows = false;
            this.dgvSirketler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSirketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSirketler.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSirketler.Location = new System.Drawing.Point(403, 3);
            this.dgvSirketler.MultiSelect = false;
            this.dgvSirketler.Name = "dgvSirketler";
            this.dgvSirketler.ReadOnly = true;
            this.dgvSirketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSirketler.Size = new System.Drawing.Size(772, 488);
            this.dgvSirketler.TabIndex = 5;
            // 
            // FrmSirketIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FrmSirketIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirket İşlemleri";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.pnlInputs.ResumeLayout(false);
            this.gbSirketBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel pnlInputs;
        private MaterialSkin.Controls.MaterialCard gbSirketBilgileri;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAdres;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefon;
        private MaterialSkin.Controls.MaterialTextBox2 txtVergiNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtSirketAdi;
        private MaterialSkin.Controls.MaterialButton btnYeniSirket;
        private MaterialSkin.Controls.MaterialButton btnGuncelle;
        private MaterialSkin.Controls.MaterialButton btnSil;
        private MaterialSkin.Controls.MaterialButton btnTemizle;
        private System.Windows.Forms.DataGridView dgvSirketler;
        private MaterialSkin.Controls.MaterialButton btnKapat;
    }
}
