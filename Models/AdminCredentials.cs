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
                // Bu hash "KompAdmin2025!" şifresinin BCrypt karşılığıdır.
                // Şifre kodu içerisinde açık metin olarak bulunmaz, sadece bu hash saklanır.
                PasswordHash = "$2a$11$5L6aal.ff2Kg.iS9lXjUm.vEk5sCGwY9WUjrgGZA7p7EvDKAN/cbe",
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
