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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoru = new MaterialSkin.Controls.MaterialLabel();
            this.txtCevap = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnIptal = new MaterialSkin.Controls.MaterialButton();
            this.btnTamam = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.lblSoru, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.txtCevap, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pnlButtons, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(410, 192);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSoru.Depth = 0;
            this.lblSoru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoru.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSoru.Location = new System.Drawing.Point(14, 10);
            this.lblSoru.Margin = new System.Windows.Forms.Padding(14, 10, 14, 0);
            this.lblSoru.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(382, 30);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Soru Metni";
            this.lblSoru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCevap
            // 
            this.txtCevap.AnimateReadOnly = false;
            this.txtCevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCevap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCevap.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCevap.Depth = 0;
            this.txtCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCevap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCevap.HideSelection = true;
            this.txtCevap.LeadingIcon = null;
            this.txtCevap.Location = new System.Drawing.Point(14, 46);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.txtCevap.MaxLength = 32767;
            this.txtCevap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.PasswordChar = '\0';
            this.txtCevap.PrefixSuffixText = null;
            this.txtCevap.ReadOnly = false;
            this.txtCevap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCevap.SelectedText = "";
            this.txtCevap.SelectionLength = 0;
            this.txtCevap.SelectionStart = 0;
            this.txtCevap.ShortcutsEnabled = true;
            this.txtCevap.Size = new System.Drawing.Size(382, 48);
            this.txtCevap.TabIndex = 1;
            this.txtCevap.TabStop = false;
            this.txtCevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCevap.TrailingIcon = null;
            this.txtCevap.UseAccent = false;
            this.txtCevap.UseSystemPasswordChar = false;
            this.txtCevap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCevap_KeyPress);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlButtons.Controls.Add(this.btnIptal);
            this.pnlButtons.Controls.Add(this.btnTamam);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlButtons.Location = new System.Drawing.Point(3, 103);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(404, 86);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.AutoSize = false;
            this.btnIptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIptal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIptal.Depth = 0;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIptal.HighEmphasis = true;
            this.btnIptal.Icon = null;
            this.btnIptal.Location = new System.Drawing.Point(280, 5);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIptal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIptal.Size = new System.Drawing.Size(100, 36);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "Ýptal";
            this.btnIptal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnIptal.UseAccentColor = false;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.AutoSize = false;
            this.btnTamam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTamam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTamam.Depth = 0;
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTamam.HighEmphasis = true;
            this.btnTamam.Icon = null;
            this.btnTamam.Location = new System.Drawing.Point(170, 5);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTamam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTamam.Size = new System.Drawing.Size(100, 36);
            this.btnTamam.TabIndex = 0;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTamam.UseAccentColor = false;
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // FrmInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 259);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Giriþi";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialLabel lblSoru;
        private MaterialSkin.Controls.MaterialTextBox2 txtCevap;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnTamam;
        private MaterialSkin.Controls.MaterialButton btnIptal;
    }
}
