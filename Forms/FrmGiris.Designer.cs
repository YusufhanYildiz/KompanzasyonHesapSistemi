namespace KompanzasyonHesapSistemi
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBaslik = new Label();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            lblSifre = new Label();
            btnGirisYap = new Button();
            btnDemoGiris = new Button();
            chkSifreGoster = new CheckBox();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(100, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(306, 30);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Kompanzasyon Hesap Sistemi";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(50, 100);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(170, 97);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(200, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(170, 137);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(200, 23);
            txtSifre.TabIndex = 3;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(50, 140);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre:";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.DodgerBlue;
            btnGirisYap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(170, 190);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(110, 35);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "Admin Girişi";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnDemoGiris
            // 
            btnDemoGiris.BackColor = Color.SeaGreen;
            btnDemoGiris.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDemoGiris.ForeColor = Color.White;
            btnDemoGiris.Location = new Point(290, 190);
            btnDemoGiris.Name = "btnDemoGiris";
            btnDemoGiris.Size = new Size(110, 35);
            btnDemoGiris.TabIndex = 6;
            btnDemoGiris.Text = "Demo Girişi";
            btnDemoGiris.UseVisualStyleBackColor = false;
            btnDemoGiris.Click += btnDemoGiris_Click;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(170, 240);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(95, 19);
            chkSifreGoster.TabIndex = 7;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(chkSifreGoster);
            Controls.Add(btnDemoGiris);
            Controls.Add(btnGirisYap);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kompanzasyon Hesap Sistemi - Giriş";
            FormClosed += FrmGiris_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label lblSifre;
        private Button btnGirisYap;
        private Button btnDemoGiris;
        private CheckBox chkSifreGoster;
    }
}
