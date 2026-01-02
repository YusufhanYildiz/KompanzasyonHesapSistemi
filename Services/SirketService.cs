using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KompanzasyonHesapSistemi.Models;

namespace KompanzasyonHesapSistemi.Services
{
    public class SirketService
    {
        private readonly IJsonDataService<Sirket> _jsonDataService;

        public SirketService(IJsonDataService<Sirket> jsonDataService)
        {
            _jsonDataService = jsonDataService;
        }

        public async Task<List<Sirket>> GetAllAsync()
        {
            return await _jsonDataService.GetAllAsync();
        }

        public async Task<Sirket?> GetByIdAsync(int id)
        {
            var allSirkets = await _jsonDataService.GetAllAsync();
            return allSirkets.FirstOrDefault(s => s.Id == id);
        }

        public async Task AddAsync(Sirket sirket)
        {
            // JsonDataService will handle setting the Id and saving.
            // KayitTarihi is set in the Sirket model constructor if not explicitly set.
            await _jsonDataService.AddAsync(sirket);
        }

        public async Task UpdateAsync(Sirket sirket)
        {
            await _jsonDataService.UpdateAsync(sirket);
        }

        public async Task DeleteAsync(int id)
        {
            await _jsonDataService.DeleteAsync(id);
        }
    }
}

