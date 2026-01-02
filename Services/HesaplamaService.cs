using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KompanzasyonHesapSistemi.Models;
using Newtonsoft.Json; // Added for JsonProperty

namespace KompanzasyonHesapSistemi.Services
{
    public class HesaplamaService
    {
        private readonly IJsonDataService<Hesaplama> _jsonDataService;

        public HesaplamaService(IJsonDataService<Hesaplama> jsonDataService)
        {
            _jsonDataService = jsonDataService;
        }

        public async Task<bool> HesaplamaEkleAsync(Hesaplama hesaplama)
        {
            try
            {
                hesaplama.HesaplaTuketim(); // Ensure consumption is calculated before ratio
                hesaplama.HesaplaOranlari();
                await _jsonDataService.AddAsync(hesaplama);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hesaplama ekleme hatası: {ex.Message}");
            }
        }

        public async Task<List<Hesaplama>> TumHesaplamalariGetirAsync()
        {
            return await _jsonDataService.GetAllAsync();
        }

        public async Task<List<Hesaplama>> SirketHesaplamalariniGetirAsync(int sirketId)
        {
            var allHesaplamalar = await _jsonDataService.GetAllAsync();
            return allHesaplamalar.Where(h => h.SirketId == sirketId).ToList();
        }

        public async Task<List<Hesaplama>> TariheGoreHesaplamalarAsync(DateTime baslangic, DateTime bitis)
        {
            var allHesaplamalar = await _jsonDataService.GetAllAsync();
            return allHesaplamalar
                        .Where(h => h.Tarih.Date >= baslangic.Date && h.Tarih.Date <= bitis.Date)
                        .ToList();
        }

        public async Task<List<Hesaplama>> CezaliHesaplamalariGetirAsync()
        {
            var allHesaplamalar = await _jsonDataService.GetAllAsync();
            return allHesaplamalar.Where(h => h.EnduktifCezaVar || h.KapasitifCezaVar).ToList();
        }

        public async Task<bool> HesaplamaSilAsync(int id)
        {
            try
            {
                await _jsonDataService.DeleteAsync(id);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false; // Item not found
            }
            catch (Exception ex)
            {
                throw new Exception($"Hesaplama silme hatası: {ex.Message}");
            }
        }

        public async Task<bool> HesaplamaGuncelleAsync(Hesaplama hesaplama)
        {
            try
            {
                hesaplama.HesaplaTuketim(); // Ensure consumption is calculated before ratio
                hesaplama.HesaplaOranlari();
                await _jsonDataService.UpdateAsync(hesaplama);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false; // Item not found
            }
            catch (Exception ex)
            {
                throw new Exception($"Hesaplama güncelleme hatası: {ex.Message}");
            }
        }
    }
}
