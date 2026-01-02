using System;
using BCrypt.Net;

namespace KompanzasyonHesapSistemi.Services
{
    /// <summary>
    /// Şifre hash'leme ve doğrulama servisi
    /// BCrypt algoritması kullanarak güvenli şifre yönetimi sağlar
    /// </summary>
    public static class PasswordService
    {
        /// <summary>
        /// Şifreyi BCrypt ile hash'ler
        /// </summary>
        /// <param name="password">Düz metin şifre</param>
        /// <returns>Hash'lenmiş şifre</returns>
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(12));
        }

        /// <summary>
        /// Girilen şifrenin hash ile eşleşip eşleşmediğini kontrol eder
        /// </summary>
        /// <param name="password">Düz metin şifre</param>
        /// <param name="hashedPassword">Saklanan hash</param>
        /// <returns>Eşleşirse true</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch
            {
                return false;
            }
        }
    }
}
