using System;
using Newtonsoft.Json; // Added for JsonProperty

namespace KompanzasyonHesapSistemi.Models
{
    public class IsTakip
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string IsAciklamasi { get; set; } = string.Empty;
        public decimal IsUcreti { get; set; }
        public decimal AlinanTutar { get; set; }
        public decimal Bakiye { get; set; }
        public int SirketId { get; set; }
        public string SirketAdi { get; set; } = string.Empty;

        public IsTakip()
        {
            Tarih = DateTime.Now;
        }

        // Bakiye Hesaplama
        public void HesaplaBakiye()
        {
            Bakiye = IsUcreti - AlinanTutar;
        }
    }
}
