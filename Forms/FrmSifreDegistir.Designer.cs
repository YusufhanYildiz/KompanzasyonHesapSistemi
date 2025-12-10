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
            lblEskiSifre = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            lblYeniSifre = new Label();
            txtYeniSifreTekrar = new TextBox();
            lblYeniSifreTekrar = new Label();
            btnKaydet = new Button();
            btnIptal = new Button();
            grpSifreIslemleri = new GroupBox();
            grpSifreIslemleri.SuspendLayout();
            SuspendLayout();
            // 
            // lblEskiSifre
            // 
            lblEskiSifre.AutoSize = true;
            lblEskiSifre.Location = new Point(8, 35);
            lblEskiSifre.Name = "lblEskiSifre";
            lblEskiSifre.Size = new Size(56, 15);
            lblEskiSifre.TabIndex = 0;
            lblEskiSifre.Text = "Eski Şifre:";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(130, 32);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.Size = new Size(180, 23);
            txtEskiSifre.TabIndex = 1;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(130, 72);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.Size = new Size(180, 23);
            txtYeniSifre.TabIndex = 3;
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.Location = new Point(6, 75);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(58, 15);
            lblYeniSifre.TabIndex = 2;
            lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(130, 112);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.PasswordChar = '*';
            txtYeniSifreTekrar.Size = new Size(180, 23);
            txtYeniSifreTekrar.TabIndex = 5;
            // 
            // lblYeniSifreTekrar
            // 
            lblYeniSifreTekrar.AutoSize = true;
            lblYeniSifreTekrar.Location = new Point(6, 115);
            lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            lblYeniSifreTekrar.Size = new Size(100, 15);
            lblYeniSifreTekrar.TabIndex = 4;
            lblYeniSifreTekrar.Text = "Yeni Şifre (Tekrar):";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.ForestGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(130, 155);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(85, 30);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Firebrick;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(225, 155);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(85, 30);
            btnIptal.TabIndex = 7;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // grpSifreIslemleri
            // 
            grpSifreIslemleri.Controls.Add(lblEskiSifre);
            grpSifreIslemleri.Controls.Add(btnIptal);
            grpSifreIslemleri.Controls.Add(txtEskiSifre);
            grpSifreIslemleri.Controls.Add(btnKaydet);
            grpSifreIslemleri.Controls.Add(lblYeniSifre);
            grpSifreIslemleri.Controls.Add(txtYeniSifreTekrar);
            grpSifreIslemleri.Controls.Add(txtYeniSifre);
            grpSifreIslemleri.Controls.Add(lblYeniSifreTekrar);
            grpSifreIslemleri.Location = new Point(12, 12);
            grpSifreIslemleri.Name = "grpSifreIslemleri";
            grpSifreIslemleri.Size = new Size(340, 210);
            grpSifreIslemleri.TabIndex = 8;
            grpSifreIslemleri.TabStop = false;
            grpSifreIslemleri.Text = "Şifre Değiştirme";
            // 
            // FrmSifreDegistir
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnIptal;
            ClientSize = new Size(364, 236);
            Controls.Add(grpSifreIslemleri);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSifreDegistir";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Şifre Değiştir";
            grpSifreIslemleri.ResumeLayout(false);
            grpSifreIslemleri.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEskiSifre;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.GroupBox grpSifreIslemleri;
    }
}
