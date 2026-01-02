namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmYedekleme
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardInfo = new MaterialSkin.Controls.MaterialCard();
            this.lblInfo = new MaterialSkin.Controls.MaterialLabel();
            this.btnCreateBackup = new MaterialSkin.Controls.MaterialButton();
            this.cardRestore = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanelRestore = new System.Windows.Forms.TableLayoutPanel();
            this.lblAvailableBackups = new MaterialSkin.Controls.MaterialLabel();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.lstBackups = new System.Windows.Forms.ListBox();
            this.btnRestore = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardInfo.SuspendLayout();
            this.cardRestore.SuspendLayout();
            this.tableLayoutPanelRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.cardInfo, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.btnCreateBackup, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.cardRestore, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(466, 538);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // cardInfo
            // 
            this.cardInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardInfo.Controls.Add(this.lblInfo);
            this.cardInfo.Depth = 0;
            this.cardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInfo.Location = new System.Drawing.Point(14, 14);
            this.cardInfo.Margin = new System.Windows.Forms.Padding(14);
            this.cardInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.Padding = new System.Windows.Forms.Padding(20);
            this.cardInfo.Size = new System.Drawing.Size(438, 92);
            this.cardInfo.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblInfo.Depth = 0;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(398, 52);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Verilerinizi yedekleyebilir veya eski bir yedeği geri yükleyebilirsiniz.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.AutoSize = false;
            this.btnCreateBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateBackup.Depth = 0;
            this.btnCreateBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateBackup.HighEmphasis = true;
            this.btnCreateBackup.Icon = null;
            this.btnCreateBackup.Location = new System.Drawing.Point(14, 126);
            this.btnCreateBackup.Margin = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.btnCreateBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateBackup.Size = new System.Drawing.Size(438, 48);
            this.btnCreateBackup.TabIndex = 1;
            this.btnCreateBackup.Text = "Yeni Yedek Oluştur";
            this.btnCreateBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateBackup.UseAccentColor = false;
            this.btnCreateBackup.UseVisualStyleBackColor = false;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // cardRestore
            // 
            this.cardRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRestore.Controls.Add(this.tableLayoutPanelRestore);
            this.cardRestore.Depth = 0;
            this.cardRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRestore.Location = new System.Drawing.Point(14, 194);
            this.cardRestore.Margin = new System.Windows.Forms.Padding(14);
            this.cardRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRestore.Name = "cardRestore";
            this.cardRestore.Padding = new System.Windows.Forms.Padding(14);
            this.cardRestore.Size = new System.Drawing.Size(438, 330);
            this.cardRestore.TabIndex = 2;
            // 
            // tableLayoutPanelRestore
            // 
            this.tableLayoutPanelRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelRestore.ColumnCount = 2;
            this.tableLayoutPanelRestore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRestore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelRestore.Controls.Add(this.lblAvailableBackups, 0, 0);
            this.tableLayoutPanelRestore.Controls.Add(this.btnRefresh, 1, 0);
            this.tableLayoutPanelRestore.Controls.Add(this.lstBackups, 0, 1);
            this.tableLayoutPanelRestore.Controls.Add(this.btnRestore, 0, 2);
            this.tableLayoutPanelRestore.Controls.Add(this.btnDelete, 0, 3);
            this.tableLayoutPanelRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRestore.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelRestore.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanelRestore.Name = "tableLayoutPanelRestore";
            this.tableLayoutPanelRestore.RowCount = 4;
            this.tableLayoutPanelRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelRestore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelRestore.Size = new System.Drawing.Size(410, 302);
            this.tableLayoutPanelRestore.TabIndex = 0;
            // 
            // lblAvailableBackups
            // 
            this.lblAvailableBackups.AutoSize = true;
            this.lblAvailableBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblAvailableBackups.Depth = 0;
            this.lblAvailableBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailableBackups.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAvailableBackups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAvailableBackups.Location = new System.Drawing.Point(3, 0);
            this.lblAvailableBackups.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAvailableBackups.Name = "lblAvailableBackups";
            this.lblAvailableBackups.Size = new System.Drawing.Size(304, 40);
            this.lblAvailableBackups.TabIndex = 0;
            this.lblAvailableBackups.Text = "Mevcut Yedekler:";
            this.lblAvailableBackups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(314, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(92, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lstBackups
            // 
            this.lstBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelRestore.SetColumnSpan(this.lstBackups, 2);
            this.lstBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBackups.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstBackups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstBackups.FormattingEnabled = true;
            this.lstBackups.ItemHeight = 17;
            this.lstBackups.Location = new System.Drawing.Point(3, 43);
            this.lstBackups.Name = "lstBackups";
            this.lstBackups.Size = new System.Drawing.Size(404, 156);
            this.lstBackups.TabIndex = 2;
            // 
            // btnRestore
            // 
            this.btnRestore.AutoSize = false;
            this.btnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelRestore.SetColumnSpan(this.btnRestore, 2);
            this.btnRestore.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRestore.Depth = 0;
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestore.HighEmphasis = true;
            this.btnRestore.Icon = null;
            this.btnRestore.Location = new System.Drawing.Point(4, 208);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRestore.Size = new System.Drawing.Size(402, 38);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Seçili Yedeği Geri Yükle";
            this.btnRestore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRestore.UseAccentColor = false;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelRestore.SetColumnSpan(this.btnDelete, 2);
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(4, 258);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(402, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Seçili Yedeği Sil";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(472, 605);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FrmYedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardInfo.ResumeLayout(false);
            this.cardRestore.ResumeLayout(false);
            this.tableLayoutPanelRestore.ResumeLayout(false);
            this.tableLayoutPanelRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardInfo;
        private MaterialSkin.Controls.MaterialLabel lblInfo;
        private MaterialSkin.Controls.MaterialButton btnCreateBackup;
        private MaterialSkin.Controls.MaterialCard cardRestore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRestore;
        private MaterialSkin.Controls.MaterialLabel lblAvailableBackups;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.ListBox lstBackups;
        private MaterialSkin.Controls.MaterialButton btnRestore;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}
