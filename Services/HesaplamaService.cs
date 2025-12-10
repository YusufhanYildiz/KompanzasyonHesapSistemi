using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KompanzasyonHesapSistemi.Models;

namespace KompanzasyonHesapSistemi.Services
{
    public class HesaplamaService
    {
        private readonly JsonService _jsonService;
        private const string HESAPLAMALAR_FILE = "hesaplamalar.json";

        public HesaplamaService()
        {
            _jsonService = new JsonService();
        }

        /// <summary>
        /// Yeni hesaplama ekle
        /// </summary>
        public bool HesaplamaEkle(Hesaplama hesaplama)
        {
            try
            {
                // Önce oranları hesapla
                hesaplama.HesaplaOranlari();

                // Mevcut hesaplamaları oku
                var hesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);

                // Yeni ID oluştur
                hesaplama.Id = hesaplamalar.Count > 0 ? hesaplamalar.Max(h => h.Id) + 1 : 1;

                // Listeye ekle
                hesaplamalar.Add(hesaplama);

                // Kaydet
                _jsonService.SaveList(HESAPLAMALAR_FILE, hesaplamalar);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hesaplama ekleme hatası: {ex.Message}");
            }
        }

        /// <summary>
        /// Tüm hesaplamaları getir
        /// </summary>
        public List<Hesaplama> TumHesaplamalariGetir()
        {
            return _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
        }

        /// <summary>
        /// Şirkete göre hesaplamaları getir
        /// </summary>
        public List<Hesaplama> SirketHesaplamalariniGetir(int sirketId)
        {
            var tumHesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
            return tumHesaplamalar.Where(h => h.SirketId == sirketId).ToList();
        }

        /// <summary>
        /// Tarihe göre hesaplamaları getir
        /// </summary>
        public List<Hesaplama> TariheGoreHesaplamalar(DateTime baslangic, DateTime bitis)
        {
            var tumHesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
            return tumHesaplamalar.Where(h => h.Tarih >= baslangic && h.Tarih <= bitis).ToList();
        }

        /// <summary>
        /// Cezalı hesaplamaları getir
        /// </summary>
        public List<Hesaplama> CezaliHesaplamalariGetir()
        {
            var tumHesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
            return tumHesaplamalar.Where(h => h.CezaDurumu == "CEZA VAR").ToList();
        }

        /// <summary>
        /// Hesaplama sil
        /// </summary>
        public bool HesaplamaSil(int id)
        {
            try
            {
                var hesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
                var silinecek = hesaplamalar.FirstOrDefault(h => h.Id == id);

                if (silinecek != null)
                {
                    hesaplamalar.Remove(silinecek);
                    _jsonService.SaveList(HESAPLAMALAR_FILE, hesaplamalar);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hesaplama silme hatası: {ex.Message}");
            }
        }

        /// <summary>
        /// Hesaplama güncelle
        /// </summary>
        public bool HesaplamaGuncelle(Hesaplama hesaplama)
        {
            try
            {
                // Önce oranları hesapla
                hesaplama.HesaplaOranlari();

                var hesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
                var guncellenecek = hesaplamalar.FirstOrDefault(h => h.Id == hesaplama.Id);

                if (guncellenecek != null)
                {
                    hesaplamalar.Remove(guncellenecek);
                    hesaplamalar.Add(hesaplama);
                    _jsonService.SaveList(HESAPLAMALAR_FILE, hesaplamalar);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hesaplama güncelleme hatası: {ex.Message}");
            }
        }

        /// <summary>
        /// Toplam ceza sayısını getir
        /// </summary>
        public int ToplamCezaSayisi()
        {
            var hesaplamalar = _jsonService.ReadList<Hesaplama>(HESAPLAMALAR_FILE);
            return hesaplamalar.Count(h => h.CezaDurumu == "CEZA VAR");
        }
    }
}
