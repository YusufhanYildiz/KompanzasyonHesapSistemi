using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmInputDialog : BaseForm
    {
        public string Cevap { get; private set; } = string.Empty;

        public FrmInputDialog(string soru, string baslik = "Bilgi Girişi")
        {
            InitializeComponent();
            this.Text = baslik;
            lblSoru.Text = soru;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            Cevap = txtCevap.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTamam_Click(sender, e);
            }
        }
        /// <summary>
        /// Static metod - Kolay kullanım için
        /// </summary>
        public static string Show(string soru, string baslik = "Bilgi Girişi")
        {
            using (FrmInputDialog dialog = new FrmInputDialog(soru, baslik))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.Cevap;
                }
                return string.Empty;
            }
        }
    }
}
