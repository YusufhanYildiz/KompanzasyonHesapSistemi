namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmAyarlar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cardBackupSettings = new MaterialSkin.Controls.MaterialCard();
            this.lblAutoBackupInfo = new MaterialSkin.Controls.MaterialLabel();
            this.swAutoBackup = new MaterialSkin.Controls.MaterialSwitch();
            this.lblBackupTitle = new MaterialSkin.Controls.MaterialLabel();
            this.cardBackupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBackupSettings
            // 
            this.cardBackupSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardBackupSettings.Controls.Add(this.lblAutoBackupInfo);
            this.cardBackupSettings.Controls.Add(this.swAutoBackup);
            this.cardBackupSettings.Controls.Add(this.lblBackupTitle);
            this.cardBackupSettings.Depth = 0;
            this.cardBackupSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardBackupSettings.Location = new System.Drawing.Point(17, 80);
            this.cardBackupSettings.Margin = new System.Windows.Forms.Padding(14);
            this.cardBackupSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardBackupSettings.Name = "cardBackupSettings";
            this.cardBackupSettings.Padding = new System.Windows.Forms.Padding(14);
            this.cardBackupSettings.Size = new System.Drawing.Size(418, 150);
            this.cardBackupSettings.TabIndex = 0;
            // 
            // lblAutoBackupInfo
            // 
            this.lblAutoBackupInfo.Depth = 0;
            this.lblAutoBackupInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAutoBackupInfo.Location = new System.Drawing.Point(17, 85);
            this.lblAutoBackupInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAutoBackupInfo.Name = "lblAutoBackupInfo";
            this.lblAutoBackupInfo.Size = new System.Drawing.Size(384, 51);
            this.lblAutoBackupInfo.TabIndex = 2;
            this.lblAutoBackupInfo.Text = "Aktif edildiğinde, uygulama kapatılırken onay sorulmadan otomatik olarak yedek al" +
    "ınır.";
            // 
            // swAutoBackup
            // 
            this.swAutoBackup.AutoSize = true;
            this.swAutoBackup.Depth = 0;
            this.swAutoBackup.Location = new System.Drawing.Point(17, 41);
            this.swAutoBackup.Margin = new System.Windows.Forms.Padding(0);
            this.swAutoBackup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swAutoBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.swAutoBackup.Name = "swAutoBackup";
            this.swAutoBackup.Ripple = true;
            this.swAutoBackup.Size = new System.Drawing.Size(223, 37);
            this.swAutoBackup.TabIndex = 1;
            this.swAutoBackup.Text = "Çıkışta Otomatik Yedekle";
            this.swAutoBackup.UseVisualStyleBackColor = true;
            this.swAutoBackup.CheckedChanged += new System.EventHandler(this.swAutoBackup_CheckedChanged);
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Depth = 0;
            this.lblBackupTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBackupTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lblBackupTitle.Location = new System.Drawing.Point(17, 14);
            this.lblBackupTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(139, 17);
            this.lblBackupTitle.TabIndex = 0;
            this.lblBackupTitle.Text = "Yedekleme Ayarları";
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 255);
            this.Controls.Add(this.cardBackupSettings);
            this.Name = "FrmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.cardBackupSettings.ResumeLayout(false);
            this.cardBackupSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardBackupSettings;
        private MaterialSkin.Controls.MaterialSwitch swAutoBackup;
        private MaterialSkin.Controls.MaterialLabel lblBackupTitle;
        private MaterialSkin.Controls.MaterialLabel lblAutoBackupInfo;
    }
}
