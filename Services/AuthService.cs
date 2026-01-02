using KompanzasyonHesapSistemi.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Services
{
    public class AuthService
    {
        private readonly IJsonSingletonService<AdminCredentials> _adminCredentialsService;

        public AuthService(IJsonSingletonService<AdminCredentials> adminCredentialsService)
        {
            _adminCredentialsService = adminCredentialsService;
        }

        public async Task<AdminCredentials?> GetAdminCredentialsAsync()
        {
            return await _adminCredentialsService.GetAsync();
        }

        public async Task SaveAdminCredentialsAsync(AdminCredentials credentials)
        {
            await _adminCredentialsService.SaveAsync(credentials);
        }

        public async Task UpdateLastLoginAsync(string username)
        {
            var credentials = await _adminCredentialsService.GetAsync();
            if (credentials != null && credentials.Username == username)
            {
                credentials.LastLoginAt = DateTime.UtcNow;
                await _adminCredentialsService.SaveAsync(credentials);
            }
        }

        public async Task<AdminCredentials> InitializeDefaultAdminAsync()
        {
            var defaultAdmin = AdminCredentials.CreateDefault();
            await SaveAdminCredentialsAsync(defaultAdmin);
            return defaultAdmin;
        }
    }
}
