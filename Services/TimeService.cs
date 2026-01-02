using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace KompanzasyonHesapSistemi.Services
{
    public class TimeService
    {
        /// <summary>
        /// İnternet üzerinden güvenilir saati almaya çalışır.
        /// Başarısız olursa (internet yoksa) sistem saatini (UTC) döndürür.
        /// </summary>
        public async Task<DateTime> GetReliableTimeAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Kısa bir zaman aşımı belirle, kullanıcıyı bekletme
                    client.Timeout = TimeSpan.FromSeconds(3);
                    
                    // Google'a sadece başlık (HEAD) isteği atarak Date bilgisini al
                    // Bu yöntem NTP'den daha kolaydır çünkü genellikle 80/443 portları açıktır
                    var response = await client.GetAsync("http://www.google.com", HttpCompletionOption.ResponseHeadersRead);
                    
                    if (response.Headers.Date.HasValue)
                    {
                        return response.Headers.Date.Value.UtcDateTime;
                    }
                }
            }
            catch
            {
                // İnternet yoksa, timeout olursa veya başka bir hata durumunda
                // sessizce sistem saatine dön
            }

            // Fallback: Sistem saati
            return DateTime.UtcNow;
        }
    }
}
