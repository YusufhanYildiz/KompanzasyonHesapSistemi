using System;
using System.Drawing;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Services
{
    public static class ResolutionHelper
    {
        // Tasarımın yapıldığı baz çözünürlük (Örn: 1920x1080)
        public static readonly Size DesignResolution = new Size(1920, 1080);

        /// <summary>
        /// Mevcut ekranın ölçekleme oranını hesaplar.
        /// </summary>
        public static float GetScaleFactor(Form form)
        {
            // Mevcut ekranın çalışma alanını al
            Rectangle screenBounds = Screen.FromControl(form).Bounds;
            
            // Genişlik ve yükseklik oranlarını hesapla
            float widthRatio = (float)screenBounds.Width / DesignResolution.Width;
            float heightRatio = (float)screenBounds.Height / DesignResolution.Height;

            // En boy oranını korumak için küçük olan oranı baz al
            // Bu sayede taşma olmaz, sığdırma yapılır
            return Math.Min(widthRatio, heightRatio);
        }

        /// <summary>
        /// Mevcut DPI değerini döndürür.
        /// </summary>
        public static int GetCurrentDpi(Form form)
        {
            return form.DeviceDpi;
        }
    }
}
