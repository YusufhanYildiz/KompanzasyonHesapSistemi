namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmInputDialog
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
            lblSoru = new Label();
            txtCevap = new TextBox();
            btnTamam = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(20, 20);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(65, 15);
            lblSoru.TabIndex = 0;
            lblSoru.Text = "Soru Metni";
            // 
            // txtCevap
            // 
            txtCevap.Location = new Point(20, 50);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new Size(100, 23);
            txtCevap.TabIndex = 1;
            txtCevap.Text = "Cevap";
            txtCevap.KeyPress += txtCevap_KeyPress;
            // 
            // btnTamam
            // 
            btnTamam.DialogResult = DialogResult.OK;
            btnTamam.Location = new Point(180, 90);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(75, 23);
            btnTamam.TabIndex = 2;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.DialogResult = DialogResult.Cancel;
            btnIptal.Location = new Point(280, 90);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // FrmInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 141);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Controls.Add(txtCevap);
            Controls.Add(lblSoru);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgi Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoru;
        private TextBox txtCevap;
        private Button btnTamam;
        private Button btnIptal;
    }
}