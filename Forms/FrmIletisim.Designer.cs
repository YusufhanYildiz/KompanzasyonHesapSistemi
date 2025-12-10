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
            grpIletisimBilgileri = new GroupBox();
            lblTelefon = new Label();
            lblEmail = new Label();
            label2 = new Label();
            label1 = new Label();
            grpBizeYazin = new GroupBox();
            btnGonder = new Button();
            txtMesaj = new TextBox();
            label7 = new Label();
            cmbKonu = new ComboBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtAdSoyad = new TextBox();
            label4 = new Label();
            grpIletisimBilgileri.SuspendLayout();
            grpBizeYazin.SuspendLayout();
            SuspendLayout();
            // 
            // grpIletisimBilgileri
            // 
            grpIletisimBilgileri.Controls.Add(lblTelefon);
            grpIletisimBilgileri.Controls.Add(lblEmail);
            grpIletisimBilgileri.Controls.Add(label2);
            grpIletisimBilgileri.Controls.Add(label1);
            grpIletisimBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpIletisimBilgileri.Location = new Point(12, 12);
            grpIletisimBilgileri.Name = "grpIletisimBilgileri";
            grpIletisimBilgileri.Size = new Size(300, 426);
            grpIletisimBilgileri.TabIndex = 0;
            grpIletisimBilgileri.TabStop = false;
            grpIletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTelefon.Location = new Point(15, 140);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(127, 20);
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "+90 552 574 5761";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEmail.Location = new Point(15, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(202, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "yusufhanyildiz10@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(15, 110);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "E-Posta:";
            // 
            // grpBizeYazin
            // 
            grpBizeYazin.Controls.Add(btnGonder);
            grpBizeYazin.Controls.Add(txtMesaj);
            grpBizeYazin.Controls.Add(label7);
            grpBizeYazin.Controls.Add(cmbKonu);
            grpBizeYazin.Controls.Add(label6);
            grpBizeYazin.Controls.Add(txtEmail);
            grpBizeYazin.Controls.Add(label5);
            grpBizeYazin.Controls.Add(txtAdSoyad);
            grpBizeYazin.Controls.Add(label4);
            grpBizeYazin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpBizeYazin.Location = new Point(330, 12);
            grpBizeYazin.Name = "grpBizeYazin";
            grpBizeYazin.Size = new Size(458, 426);
            grpBizeYazin.TabIndex = 1;
            grpBizeYazin.TabStop = false;
            grpBizeYazin.Text = "Bize Yazın / Talep Oluşturun";
            // 
            // btnGonder
            // 
            btnGonder.BackColor = Color.MediumSlateBlue;
            btnGonder.FlatStyle = FlatStyle.Flat;
            btnGonder.ForeColor = Color.White;
            btnGonder.Location = new Point(20, 370);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(418, 40);
            btnGonder.TabIndex = 8;
            btnGonder.Text = "GÖNDER";
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // txtMesaj
            // 
            txtMesaj.Font = new Font("Segoe UI", 11.25F);
            txtMesaj.Location = new Point(20, 230);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(418, 120);
            txtMesaj.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(20, 210);
            label7.Name = "label7";
            label7.Size = new Size(96, 17);
            label7.TabIndex = 6;
            label7.Text = "Mesaj / Detay :";
            // 
            // cmbKonu
            // 
            cmbKonu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKonu.Font = new Font("Segoe UI", 11.25F);
            cmbKonu.FormattingEnabled = true;
            cmbKonu.Items.AddRange(new object[] { "Satın Alma Talebi", "Özellik İsteği / Öneri", "Hata Bildirimi", "Diğer" });
            cmbKonu.Location = new Point(20, 170);
            cmbKonu.Name = "cmbKonu";
            cmbKonu.Size = new Size(418, 28);
            cmbKonu.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(20, 150);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 4;
            label6.Text = "Konu :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(20, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(418, 27);
            txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(20, 90);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 2;
            label5.Text = "E-Posta :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 11.25F);
            txtAdSoyad.Location = new Point(20, 50);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(418, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 0;
            label4.Text = "Ad Soyad :";
            // 
            // FrmIletisim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBizeYazin);
            Controls.Add(grpIletisimBilgileri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmIletisim";
            StartPosition = FormStartPosition.CenterParent;
            Text = "İletişim ve Destek";
            grpIletisimBilgileri.ResumeLayout(false);
            grpIletisimBilgileri.PerformLayout();
            grpBizeYazin.ResumeLayout(false);
            grpBizeYazin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpIletisimBilgileri;
        private Label label1;
        private Label label2;
        private Label lblTelefon;
        private Label lblEmail;
        private GroupBox grpBizeYazin;
        private Label label4;
        private TextBox txtAdSoyad;
        private TextBox txtMesaj;
        private Label label7;
        private ComboBox cmbKonu;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private Button btnGonder;
    }
}
