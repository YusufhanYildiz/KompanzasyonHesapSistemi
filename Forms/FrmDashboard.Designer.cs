namespace KompanzasyonHesapSistemi.Forms
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cardsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cardCeza = new MaterialSkin.Controls.MaterialCard();
            this.lblCezaTitle = new System.Windows.Forms.Label();
            this.lblCezaValue = new System.Windows.Forms.Label();
            this.cardHesaplama = new MaterialSkin.Controls.MaterialCard();
            this.lblHesaplamaTitle = new System.Windows.Forms.Label();
            this.lblHesaplamaValue = new System.Windows.Forms.Label();
            this.cardSirket = new MaterialSkin.Controls.MaterialCard();
            this.lblSirketTitle = new System.Windows.Forms.Label();
            this.lblSirketValue = new System.Windows.Forms.Label();
            this.chartsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelChartRight = new MaterialSkin.Controls.MaterialCard();
            this.lblChartRightTitle = new System.Windows.Forms.Label();
            this.panelChartLeft = new MaterialSkin.Controls.MaterialCard();
            this.lblChartLeftTitle = new System.Windows.Forms.Label();
            this.dgvSonIslemler = new System.Windows.Forms.DataGridView();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnKapat = new MaterialSkin.Controls.MaterialButton();
            this.btnYenile = new MaterialSkin.Controls.MaterialButton();
            this.mainLayout.SuspendLayout();
            this.cardsLayout.SuspendLayout();
            this.cardCeza.SuspendLayout();
            this.cardHesaplama.SuspendLayout();
            this.cardSirket.SuspendLayout();
            this.chartsLayout.SuspendLayout();
            this.panelChartRight.SuspendLayout();
            this.panelChartLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonIslemler)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.cardsLayout, 0, 0);
            this.mainLayout.Controls.Add(this.chartsLayout, 0, 1);
            this.mainLayout.Controls.Add(this.dgvSonIslemler, 0, 2);
            this.mainLayout.Controls.Add(this.actionPanel, 0, 3);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(3, 64);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(10);
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayout.Size = new System.Drawing.Size(1394, 733);
            this.mainLayout.TabIndex = 0;
            // 
            // cardsLayout
            // 
            this.cardsLayout.ColumnCount = 3;
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.cardsLayout.Controls.Add(this.cardCeza, 2, 0);
            this.cardsLayout.Controls.Add(this.cardHesaplama, 1, 0);
            this.cardsLayout.Controls.Add(this.cardSirket, 0, 0);
            this.cardsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsLayout.Location = new System.Drawing.Point(13, 13);
            this.cardsLayout.Name = "cardsLayout";
            this.cardsLayout.RowCount = 1;
            this.cardsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardsLayout.Size = new System.Drawing.Size(1368, 136);
            this.cardsLayout.TabIndex = 0;
            // 
            // cardCeza
            // 
            this.cardCeza.Controls.Add(this.lblCezaTitle);
            this.cardCeza.Controls.Add(this.lblCezaValue);
            this.cardCeza.Depth = 0;
            this.cardCeza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCeza.Location = new System.Drawing.Point(915, 5);
            this.cardCeza.Margin = new System.Windows.Forms.Padding(5);
            this.cardCeza.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCeza.Name = "cardCeza";
            this.cardCeza.Padding = new System.Windows.Forms.Padding(10);
            this.cardCeza.Size = new System.Drawing.Size(448, 126);
            this.cardCeza.TabIndex = 2;
            // 
            // lblCezaTitle
            // 
            this.lblCezaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCezaTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCezaTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblCezaTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCezaTitle.Name = "lblCezaTitle";
            this.lblCezaTitle.Size = new System.Drawing.Size(428, 20);
            this.lblCezaTitle.TabIndex = 0;
            this.lblCezaTitle.Text = "CEZA RİSK ORANI (SON 30 GÜN)";
            this.lblCezaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCezaValue
            // 
            this.lblCezaValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCezaValue.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCezaValue.Location = new System.Drawing.Point(10, 40);
            this.lblCezaValue.Name = "lblCezaValue";
            this.lblCezaValue.Size = new System.Drawing.Size(428, 76);
            this.lblCezaValue.TabIndex = 1;
            this.lblCezaValue.Text = "%0";
            this.lblCezaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardHesaplama
            // 
            this.cardHesaplama.Controls.Add(this.lblHesaplamaTitle);
            this.cardHesaplama.Controls.Add(this.lblHesaplamaValue);
            this.cardHesaplama.Depth = 0;
            this.cardHesaplama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHesaplama.Location = new System.Drawing.Point(460, 5);
            this.cardHesaplama.Margin = new System.Windows.Forms.Padding(5);
            this.cardHesaplama.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardHesaplama.Name = "cardHesaplama";
            this.cardHesaplama.Padding = new System.Windows.Forms.Padding(10);
            this.cardHesaplama.Size = new System.Drawing.Size(445, 126);
            this.cardHesaplama.TabIndex = 1;
            // 
            // lblHesaplamaTitle
            // 
            this.lblHesaplamaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHesaplamaTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHesaplamaTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblHesaplamaTitle.Location = new System.Drawing.Point(10, 10);
            this.lblHesaplamaTitle.Name = "lblHesaplamaTitle";
            this.lblHesaplamaTitle.Size = new System.Drawing.Size(425, 20);
            this.lblHesaplamaTitle.TabIndex = 0;
            this.lblHesaplamaTitle.Text = "TOPLAM KAYIT";
            this.lblHesaplamaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHesaplamaValue
            // 
            this.lblHesaplamaValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHesaplamaValue.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHesaplamaValue.Location = new System.Drawing.Point(10, 40);
            this.lblHesaplamaValue.Name = "lblHesaplamaValue";
            this.lblHesaplamaValue.Size = new System.Drawing.Size(425, 76);
            this.lblHesaplamaValue.TabIndex = 1;
            this.lblHesaplamaValue.Text = "0";
            this.lblHesaplamaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardSirket
            // 
            this.cardSirket.Controls.Add(this.lblSirketTitle);
            this.cardSirket.Controls.Add(this.lblSirketValue);
            this.cardSirket.Depth = 0;
            this.cardSirket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSirket.Location = new System.Drawing.Point(5, 5);
            this.cardSirket.Margin = new System.Windows.Forms.Padding(5);
            this.cardSirket.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSirket.Name = "cardSirket";
            this.cardSirket.Padding = new System.Windows.Forms.Padding(10);
            this.cardSirket.Size = new System.Drawing.Size(445, 126);
            this.cardSirket.TabIndex = 0;
            // 
            // lblSirketTitle
            // 
            this.lblSirketTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSirketTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSirketTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSirketTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSirketTitle.Name = "lblSirketTitle";
            this.lblSirketTitle.Size = new System.Drawing.Size(425, 20);
            this.lblSirketTitle.TabIndex = 0;
            this.lblSirketTitle.Text = "KAYITLI ŞİRKETLER";
            this.lblSirketTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSirketValue
            // 
            this.lblSirketValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSirketValue.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSirketValue.Location = new System.Drawing.Point(10, 40);
            this.lblSirketValue.Name = "lblSirketValue";
            this.lblSirketValue.Size = new System.Drawing.Size(425, 76);
            this.lblSirketValue.TabIndex = 1;
            this.lblSirketValue.Text = "0";
            this.lblSirketValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartsLayout
            // 
            this.chartsLayout.ColumnCount = 2;
            this.chartsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartsLayout.Controls.Add(this.panelChartRight, 1, 0);
            this.chartsLayout.Controls.Add(this.panelChartLeft, 0, 0);
            this.chartsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsLayout.Location = new System.Drawing.Point(13, 155);
            this.chartsLayout.Name = "chartsLayout";
            this.chartsLayout.RowCount = 1;
            this.chartsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartsLayout.Size = new System.Drawing.Size(1368, 250);
            this.chartsLayout.TabIndex = 1;
            // 
            // panelChartRight
            // 
            this.panelChartRight.Controls.Add(this.lblChartRightTitle);
            this.panelChartRight.Depth = 0;
            this.panelChartRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartRight.Location = new System.Drawing.Point(689, 5);
            this.panelChartRight.Margin = new System.Windows.Forms.Padding(5);
            this.panelChartRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelChartRight.Name = "panelChartRight";
            this.panelChartRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelChartRight.Size = new System.Drawing.Size(674, 240);
            this.panelChartRight.TabIndex = 1;
            // 
            // lblChartRightTitle
            // 
            this.lblChartRightTitle.AutoSize = true;
            this.lblChartRightTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblChartRightTitle.Location = new System.Drawing.Point(10, 10);
            this.lblChartRightTitle.Name = "lblChartRightTitle";
            this.lblChartRightTitle.Size = new System.Drawing.Size(141, 18);
            this.lblChartRightTitle.TabIndex = 1;
            this.lblChartRightTitle.Text = "Trend Analizi (Yıllık)";
            // 
            // panelChartLeft
            // 
            this.panelChartLeft.Controls.Add(this.lblChartLeftTitle);
            this.panelChartLeft.Depth = 0;
            this.panelChartLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartLeft.Location = new System.Drawing.Point(5, 5);
            this.panelChartLeft.Margin = new System.Windows.Forms.Padding(5);
            this.panelChartLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelChartLeft.Name = "panelChartLeft";
            this.panelChartLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelChartLeft.Size = new System.Drawing.Size(674, 240);
            this.panelChartLeft.TabIndex = 0;
            // 
            // lblChartLeftTitle
            // 
            this.lblChartLeftTitle.AutoSize = true;
            this.lblChartLeftTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblChartLeftTitle.Location = new System.Drawing.Point(10, 10);
            this.lblChartLeftTitle.Name = "lblChartLeftTitle";
            this.lblChartLeftTitle.Size = new System.Drawing.Size(100, 18);
            this.lblChartLeftTitle.TabIndex = 1;
            this.lblChartLeftTitle.Text = "Ceza Dağılımı";
            // 
            // dgvSonIslemler
            // 
            this.dgvSonIslemler.AllowUserToAddRows = false;
            this.dgvSonIslemler.AllowUserToDeleteRows = false;
            this.dgvSonIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonIslemler.BackgroundColor = System.Drawing.Color.White;
            this.dgvSonIslemler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSonIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSonIslemler.Location = new System.Drawing.Point(13, 411);
            this.dgvSonIslemler.Name = "dgvSonIslemler";
            this.dgvSonIslemler.ReadOnly = true;
            this.dgvSonIslemler.RowHeadersVisible = false;
            this.dgvSonIslemler.RowHeadersWidth = 51;
            this.dgvSonIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonIslemler.Size = new System.Drawing.Size(1368, 255);
            this.dgvSonIslemler.TabIndex = 2;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnKapat);
            this.actionPanel.Controls.Add(this.btnYenile);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(13, 672);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(1368, 48);
            this.actionPanel.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKapat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKapat.Depth = 0;
            this.btnKapat.HighEmphasis = true;
            this.btnKapat.Icon = null;
            this.btnKapat.Location = new System.Drawing.Point(1280, 6);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKapat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKapat.Size = new System.Drawing.Size(68, 36);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnKapat.UseAccentColor = false;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYenile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYenile.Depth = 0;
            this.btnYenile.HighEmphasis = true;
            this.btnYenile.Icon = null;
            this.btnYenile.Location = new System.Drawing.Point(1190, 6);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYenile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYenile.Size = new System.Drawing.Size(70, 36);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnYenile.UseAccentColor = false;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.mainLayout);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik Analiz Ekranı";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.mainLayout.ResumeLayout(false);
            this.cardsLayout.ResumeLayout(false);
            this.cardCeza.ResumeLayout(false);
            this.cardHesaplama.ResumeLayout(false);
            this.cardSirket.ResumeLayout(false);
            this.chartsLayout.ResumeLayout(false);
            this.panelChartRight.ResumeLayout(false);
            this.panelChartRight.PerformLayout();
            this.panelChartLeft.ResumeLayout(false);
            this.panelChartLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonIslemler)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel cardsLayout;
        private MaterialSkin.Controls.MaterialCard cardSirket;
        private System.Windows.Forms.Label lblSirketTitle;
        private System.Windows.Forms.Label lblSirketValue;
        private MaterialSkin.Controls.MaterialCard cardCeza;
        private MaterialSkin.Controls.MaterialCard cardHesaplama;
        private System.Windows.Forms.Label lblCezaValue;
        private System.Windows.Forms.Label lblCezaTitle;
        private System.Windows.Forms.Label lblHesaplamaValue;
        private System.Windows.Forms.Label lblHesaplamaTitle;
        private System.Windows.Forms.TableLayoutPanel chartsLayout;
        private MaterialSkin.Controls.MaterialCard panelChartRight;
        private MaterialSkin.Controls.MaterialCard panelChartLeft;
        private System.Windows.Forms.Panel actionPanel;
        private MaterialSkin.Controls.MaterialButton btnYenile;
        private MaterialSkin.Controls.MaterialButton btnKapat;
        private System.Windows.Forms.Label lblChartRightTitle;
        private System.Windows.Forms.Label lblChartLeftTitle;
        private System.Windows.Forms.DataGridView dgvSonIslemler;
    }
}
