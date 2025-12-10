using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KompanzasyonHesapSistemi.Models;
using KompanzasyonHesapSistemi.Services;

namespace KompanzasyonHesapSistemi.Forms
{
    public partial class FrmSirketIslemleri : Form
    {
        private readonly JsonService _jsonService;
        private const string SIRKETLER_FILE = "sirketler.json";
        private int _secilenSirketId = 0;

        public FrmSirketIslemleri()
        {
            InitializeComponent();
            _jsonService = new JsonService();
            ThemeHelper.ApplyTheme(this);
            DataGridViewAyarlari();
            SirketleriYukle();
        }

        /// <summary>
        /// DataGridView ayarları
        /// </summary>
        private void DataGridViewAyarlari()
        {
            dgvSirketler.AutoGenerateColumns = false;
            dgvSirketler.Columns.Clear();

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SirketAdi",
                HeaderText = "Şirket Adı",
                DataPropertyName = "SirketAdi",
                Width = 150
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VergiNo",
                HeaderText = "Vergi No",
                DataPropertyName = "VergiNo",
                Width = 100
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Telefon",
                HeaderText = "Telefon",
                DataPropertyName = "Telefon",
                Width = 100
            });

            dgvSirketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "KayitTarihi",
                HeaderText = "Kayıt Tarihi",
                DataPropertyName = "KayitTarihi",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd.MM.yyyy HH:mm"
                }
            });
        }
        /// <summary>
        /// Şirketleri yükle
        /// </summary>
        private void SirketleriYukle()
        {
            try
            {
                var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);
                dgvSirketler.DataSource = null;
                dgvSirketler.DataSource = sirketler;

                if (dgvSirketler.Rows.Count > 0)
                {
                    dgvSirketler.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şirketler yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Alanları temizle
        /// </summary>
        private void AlanlariTemizle()
        {
            txtSirketAdi.Clear();
            txtVergiNo.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            _secilenSirketId = 0;
            txtSirketAdi.Focus();
        }
        /// <summary>
        /// Yeni Şirket Ekle butonu
        /// </summary>
        private void btnYeniSirket_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtSirketAdi.Text))
                {
                    MessageBox.Show("Şirket adı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSirketAdi.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtVergiNo.Text))
                {
                    MessageBox.Show("Vergi no boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVergiNo.Focus();
                    return;
                }

                // Mevcut şirketleri oku
                var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);

                // Vergi no kontrolü
                var mevcutSirket = sirketler.FirstOrDefault(s =>
                    s.VergiNo.ToLower() == txtVergiNo.Text.ToLower());

                if (mevcutSirket != null)
                {
                    MessageBox.Show("Bu vergi numarası zaten kayıtlı!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni şirket oluştur
                var yeniSirket = new Sirket
                {
                    Id = sirketler.Count > 0 ? sirketler.Max(s => s.Id) + 1 : 1,
                    SirketAdi = txtSirketAdi.Text.Trim(),
                    VergiNo = txtVergiNo.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Adres = txtAdres.Text.Trim(),
                    KayitTarihi = DateTime.Now
                };

                sirketler.Add(yeniSirket);
                _jsonService.SaveList(SIRKETLER_FILE, sirketler);

                MessageBox.Show("Şirket başarıyla eklendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                AlanlariTemizle();
                SirketleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şirket ekleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Güncelle butonu
        /// </summary>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenSirketId == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek şirketi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtSirketAdi.Text))
                {
                    MessageBox.Show("Şirket adı boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSirketAdi.Focus();
                    return;
                }

                var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);
                var guncellenecekSirket = sirketler.FirstOrDefault(s => s.Id == _secilenSirketId);

                if (guncellenecekSirket != null)
                {
                    guncellenecekSirket.SirketAdi = txtSirketAdi.Text.Trim();
                    guncellenecekSirket.VergiNo = txtVergiNo.Text.Trim();
                    guncellenecekSirket.Telefon = txtTelefon.Text.Trim();
                    guncellenecekSirket.Adres = txtAdres.Text.Trim();

                    _jsonService.SaveList(SIRKETLER_FILE, sirketler);

                    MessageBox.Show("Şirket başarıyla güncellendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AlanlariTemizle();
                    SirketleriYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Sil butonu
        /// </summary>
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenSirketId == 0)
                {
                    MessageBox.Show("Lütfen silinecek şirketi seçiniz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bu şirketi silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);
                    var silinecekSirket = sirketler.FirstOrDefault(s => s.Id == _secilenSirketId);

                    if (silinecekSirket != null)
                    {
                        sirketler.Remove(silinecekSirket);
                        _jsonService.SaveList(SIRKETLER_FILE, sirketler);

                        MessageBox.Show("Şirket başarıyla silindi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AlanlariTemizle();
                        SirketleriYukle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// DataGridView satır seçildiğinde
        /// </summary>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void dgvSirketler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSirketler.Rows[e.RowIndex];

                    _secilenSirketId = Convert.ToInt32(row.Cells["Id"].Value);
                    txtSirketAdi.Text = row.Cells["SirketAdi"].Value?.ToString() ?? string.Empty;
                    txtVergiNo.Text = row.Cells["VergiNo"].Value?.ToString() ?? string.Empty;
                    txtTelefon.Text = row.Cells["Telefon"].Value?.ToString() ?? string.Empty;

                    // Adres DataGridView'de gösterilmiyor ama JSON'dan çekelim
                    var sirketler = _jsonService.ReadList<Sirket>(SIRKETLER_FILE);
                    var seciliSirket = sirketler.FirstOrDefault(s => s.Id == _secilenSirketId);
                    if (seciliSirket != null)
                    {
                        txtAdres.Text = seciliSirket.Adres ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seçim hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Kapat butonu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
