using System;

namespace KompanzasyonHesapSistemi.Models
{
    public class Sirket
    {
        public int Id { get; set; }
        public string SirketAdi { get; set; } = string.Empty;
        public string VergiNo { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public DateTime KayitTarihi { get; set; }

        public Sirket()
        {
            KayitTarihi = DateTime.Now;
        }
    }
}
