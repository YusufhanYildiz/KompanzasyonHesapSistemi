using System;

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
        /// İlk kurulum için varsayılan şifreyi hash'leyerek oluşturur
        /// Varsayılan şifre: "admin123" - İlk girişte değiştirin!
        /// </summary>
        public static AdminCredentials CreateDefault()
        {
            return new AdminCredentials
            {
                Username = "admin",
                // Varsayılan şifre: "admin123" - BCrypt hash'i
                // İlk girişte kullanıcı şifresini değiştirmeli!
                PasswordHash = Services.PasswordService.HashPassword("admin123"),
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
