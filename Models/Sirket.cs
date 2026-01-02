using System;
using Newtonsoft.Json; // Added for JsonProperty

namespace KompanzasyonHesapSistemi.Models
{
    public class Sirket
    {
        [JsonProperty("Id")]
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
