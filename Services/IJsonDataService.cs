using System.Collections.Generic;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Services
{
    public interface IJsonDataService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(int id);
        Task SaveChangesAsync(List<T> items);
    }
}
