using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace KompanzasyonHesapSistemi.Services
{
    public static class HardwareService
    {
        /// <summary>
        /// Bilgisayar için benzersiz bir donanım kimliği oluşturur.
        /// CPU ID'sini alır ve bunu SHA256 ile hash'ler.
        /// </summary>
        /// <returns>Benzersiz hash'lenmiş donanım kimliği.</returns>
        public static string GetHardwareId()
        {
            try
            {
                string cpuId = GetCpuId();
                if (string.IsNullOrEmpty(cpuId))
                {
                    // Alternatif bir veya daha fazla ID birleştirilebilir, örn: anakart, disk
                    // Şimdilik basit bir sabit değer dönüyoruz hata durumunda.
                    cpuId = "UNABLE_TO_READ_HWID";
                }

                // ID'yi her zaman aynı formatta ve güvenli bir şekilde saklamak için hash'leyelim.
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(cpuId));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception)
            {
                // Herhangi bir ManagementException veya başka bir hata olursa
                return "HWID_ERROR";
            }
        }

        private static string GetCpuId()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    // İlk işlemcinin ID'sini al
                    cpuInfo = mo.Properties["processorID"]?.Value?.ToString() ?? string.Empty;
                    break;
                }
            }
            return cpuInfo;
        }
    }
}
