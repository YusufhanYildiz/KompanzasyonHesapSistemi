using KompanzasyonHesapSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; // Added for JsonProperty

namespace KompanzasyonHesapSistemi.Services
{
    public class IsTakipService
    {
        private readonly IJsonDataService<IsTakip> _jsonDataService;

        public IsTakipService(IJsonDataService<IsTakip> jsonDataService)
        {
            _jsonDataService = jsonDataService;
        }

        public async Task<List<IsTakip>> GetAllAsync()
        {
            return await _jsonDataService.GetAllAsync();
        }

        public async Task<List<IsTakip>> GetFilteredAsync(DateTime baslangic, DateTime bitis, int? sirketId)
        {
            var allIsTakip = await _jsonDataService.GetAllAsync();
            var filtered = allIsTakip
                .Where(it => it.Tarih.Date >= baslangic.Date && it.Tarih.Date <= bitis.Date);

            if (sirketId.HasValue)
            {
                filtered = filtered.Where(it => it.SirketId == sirketId.Value);
            }

            return filtered.ToList();
        }

        public async Task<bool> AddAsync(IsTakip isTakip)
        {
            try
            {
                await _jsonDataService.AddAsync(isTakip);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(IsTakip isTakip)
        {
            try
            {
                await _jsonDataService.UpdateAsync(isTakip);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false; // Item not found
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}
