using System;
using System.Drawing;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Services
{
    public static class ScaleUtils
    {
        /// <summary>
        /// Bir kontrolü ve alt kontrollerini verilen oranda ölçekler.
        /// </summary>
        public static void ScaleControl(Control control, float scaleFactor)
        {
            // Eğer ölçek 1 ise işlem yapma (Gereksiz döngüden kaçın)
            if (Math.Abs(scaleFactor - 1.0f) < 0.01f) return;

            // 1. Font Ölçekleme
            // Mevcut font boyutunu al ve oranla çarp
            float newFontSize = control.Font.Size * scaleFactor;
            
            // Font stili ve ailesini koruyarak yeni font oluştur
            // Not: Min font boyutu kontrolü eklenebilir (örn: 8pt altı okunmaz)
            if (newFontSize < 8) newFontSize = 8;
            
            control.Font = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);

            // 2. Alt Kontrolleri (Children) Recursive Olarak Ölçekle
            foreach (Control child in control.Controls)
            {
                ScaleControl(child, scaleFactor);
            }

            // Not: WinForms AutoScaleMode.Dpi veya Font kullanıyorsa, 
            // boyutlandırmayı otomatik yapmaya çalışır. 
            // Ancak manuel pozisyonlama gerekiyorsa buraya eklenebilir.
            // Genellikle TableLayoutPanel veya Dock kullanmak manuel boyutlandırmadan daha iyidir.
        }
    }
}
