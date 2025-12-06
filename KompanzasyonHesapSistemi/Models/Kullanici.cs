using System;

namespace KompanzasyonHesapSistemi.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; } = string.Empty;
        public string Sifre { get; set; } = string.Empty;
        public string AdSoyad { get; set; } = string.Empty;
        public DateTime KayitTarihi { get; set; }

        public Kullanici()
        {
            KayitTarihi = DateTime.Now;
        }
    }
}
