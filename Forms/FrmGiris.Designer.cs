using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Drawing;

namespace KompanzasyonHesapSistemi
{
    partial class FrmGiris
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblBaslik = new MaterialSkin.Controls.MaterialLabel();
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGirisYap = new MaterialSkin.Controls.MaterialButton();
            this.btnDemoGiris = new MaterialSkin.Controls.MaterialButton();
            this.chkSifreGoster = new MaterialSkin.Controls.MaterialCheckbox();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 533);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblBaslik);
            this.materialCard1.Controls.Add(this.txtKullaniciAdi);
            this.materialCard1.Controls.Add(this.txtSifre);
            this.materialCard1.Controls.Add(this.btnGirisYap);
            this.materialCard1.Controls.Add(this.btnDemoGiris);
            this.materialCard1.Controls.Add(this.chkSifreGoster);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(211, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(372, 372);
            this.materialCard1.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBaslik.Depth = 0;
            this.lblBaslik.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBaslik.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBaslik.Location = new System.Drawing.Point(17, 30);
            this.lblBaslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(325, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kompanzasyon Hesap Sistemi";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AnimateReadOnly = false;
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKullaniciAdi.Depth = 0;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.HelperText = "Kullanýcý adýnýzý giriniz";
            this.txtKullaniciAdi.HideSelection = true;
            this.txtKullaniciAdi.Hint = "Kullanýcý Adý";
            this.txtKullaniciAdi.LeadingIcon = null;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(17, 90);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PrefixSuffixText = null;
            this.txtKullaniciAdi.ReadOnly = false;
            this.txtKullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(335, 48);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.TrailingIcon = null;
            this.txtKullaniciAdi.UseAccent = false;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.HelperText = "Þifrenizi giriniz";
            this.txtSifre.HideSelection = true;
            this.txtSifre.Hint = "Þifre";
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(17, 160);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.PrefixSuffixText = null;
            this.txtSifre.ReadOnly = false;
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(335, 48);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.TabStop = false;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseAccent = false;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.AutoSize = false;
            this.btnGirisYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnGirisYap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGirisYap.Depth = 0;
            this.btnGirisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGirisYap.HighEmphasis = true;
            this.btnGirisYap.Icon = null;
            this.btnGirisYap.Location = new System.Drawing.Point(17, 260);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGirisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGirisYap.Size = new System.Drawing.Size(160, 36);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Admin Giriþi";
            this.btnGirisYap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGirisYap.UseAccentColor = false;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnDemoGiris
            // 
            this.btnDemoGiris.AutoSize = false;
            this.btnDemoGiris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDemoGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDemoGiris.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDemoGiris.Depth = 0;
            this.btnDemoGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDemoGiris.HighEmphasis = true;
            this.btnDemoGiris.Icon = null;
            this.btnDemoGiris.Location = new System.Drawing.Point(192, 260);
            this.btnDemoGiris.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDemoGiris.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDemoGiris.Name = "btnDemoGiris";
            this.btnDemoGiris.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDemoGiris.Size = new System.Drawing.Size(160, 36);
            this.btnDemoGiris.TabIndex = 6;
            this.btnDemoGiris.Text = "Demo Giriþi";
            this.btnDemoGiris.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDemoGiris.UseAccentColor = false;
            this.btnDemoGiris.UseVisualStyleBackColor = false;
            this.btnDemoGiris.Click += new System.EventHandler(this.btnDemoGiris_Click);
            // 
            // chkSifreGoster
            // 
            this.chkSifreGoster.AutoSize = true;
            this.chkSifreGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkSifreGoster.Depth = 0;
            this.chkSifreGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkSifreGoster.Location = new System.Drawing.Point(17, 215);
            this.chkSifreGoster.Margin = new System.Windows.Forms.Padding(0);
            this.chkSifreGoster.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSifreGoster.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSifreGoster.Name = "chkSifreGoster";
            this.chkSifreGoster.ReadOnly = false;
            this.chkSifreGoster.Ripple = true;
            this.chkSifreGoster.Size = new System.Drawing.Size(130, 37);
            this.chkSifreGoster.TabIndex = 7;
            this.chkSifreGoster.Text = "Þifreyi Göster";
            this.chkSifreGoster.UseVisualStyleBackColor = false;
            this.chkSifreGoster.Click += new System.EventHandler(this.chkSifreGoster_CheckedChanged);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriþ Yap";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialCard materialCard1;
        private MaterialLabel lblBaslik;
        private MaterialTextBox2 txtKullaniciAdi;
        private MaterialTextBox2 txtSifre;
        private MaterialButton btnGirisYap;
        private MaterialButton btnDemoGiris;
        private MaterialCheckbox chkSifreGoster;
    }
}
