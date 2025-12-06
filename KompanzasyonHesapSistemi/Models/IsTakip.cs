using System;

namespace KompanzasyonHesapSistemi.Models
{
    public class IsTakip
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string IsAciklamasi { get; set; } = string.Empty;
        public decimal IsUcreti { get; set; }
        public decimal AlinanTutar { get; set; }
        public decimal Bakiye { get; set; }

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
