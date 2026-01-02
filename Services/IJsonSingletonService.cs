using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Services
{
    public interface IJsonSingletonService<T> where T : class, new()
    {
        Task<T> GetAsync();
        Task SaveAsync(T item);
    }
}
