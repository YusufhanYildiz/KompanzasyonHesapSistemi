using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Models
{
    public class Hesaplama
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public string SirketAdi { get; set; } = string.Empty;
        public DateTime Tarih { get; set; }

        // Önceki Sayaç Değerleri (Girilen)
        public double OncekiAktif { get; set; }
        public double OncekiEnduktif { get; set; }
        public double OncekiKapasitif { get; set; }

        // Mevcut Sayaç Değerleri (Girilen)
        public double MevcutAktif { get; set; }
        public double MevcutEnduktif { get; set; }
        public double MevcutKapasitif { get; set; }

        // Hesaplanan Tüketim Değerleri (Fark = Mevcut - Önceki)
        public double AktifTuketim { get; set; }      // kWh
        public double EnduktifTuketim { get; set; }    // kVArh
        public double KapasitifTuketim { get; set; }   // kVArh

        // Hesaplanan Değerler
        public double EnduktifOran { get; set; }       // %
        public double KapasitifOran { get; set; }      // %

        // Ceza Durumu
        public bool EnduktifCezaVar { get; set; }
        public bool KapasitifCezaVar { get; set; }
        public string CezaDurumu { get; set; } = string.Empty;

        public Hesaplama()
        {
            Tarih = DateTime.Now;
        }

        // Hesaplama Metodu
        public void HesaplaOranlari()
        {
            if (AktifTuketim > 0)
            {
                // Endüktif Oran = (Endüktif / Aktif) * 100
                EnduktifOran = (EnduktifTuketim / AktifTuketim) * 100;

                // Kapasitif Oran = (Kapasitif / Aktif) * 100
                KapasitifOran = (KapasitifTuketim / AktifTuketim) * 100;
            }

            // Ceza Kontrolü (Endüktif > %20 veya Kapasitif > %15 ise ceza var)
            EnduktifCezaVar = EnduktifOran > 20;
            KapasitifCezaVar = KapasitifOran > 15;

            if (EnduktifCezaVar || KapasitifCezaVar)
            {
                CezaDurumu = "CEZA VAR";
            }
            else
            {
                CezaDurumu = "CEZA YOK";
            }
        }
    }
}
