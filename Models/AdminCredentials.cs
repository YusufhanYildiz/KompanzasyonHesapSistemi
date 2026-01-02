using System;
using Newtonsoft.Json; // Added for consistency

namespace KompanzasyonHesapSistemi.Models
{
    /// <summary>
    /// Admin kullanıcı bilgilerini tutar
    /// Şifre BCrypt ile hash'lenmiş olarak saklanır
    /// </summary>
    public class AdminCredentials
    {
        public string Username { get; set; } = "admin";
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }

        /// <summary>
        /// İlk kurulum için yönetici yapılandırmasını oluşturur.
        /// </summary>
        public static AdminCredentials CreateDefault()
        {
            return new AdminCredentials
            {
                Username = "admin",
                // Şifre ilk girişte belirlenmelidir. Bu varsayılan bir değer içermez.
                PasswordHash = string.Empty,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
