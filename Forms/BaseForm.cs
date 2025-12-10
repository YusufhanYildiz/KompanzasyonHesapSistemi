using KompanzasyonHesapSistemi.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KompanzasyonHesapSistemi.Forms
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // DPI değişimlerini algıla
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Tasarım zamanı boyutunu korumak için
            // Eğer form zaten scale edilmişse tekrar etmemek için kontrol eklenebilir
            // Ancak basitlik adına her yüklemede hesaplıyoruz.
            
            ApplyResponsiveScaling();
        }

        private void ApplyResponsiveScaling()
        {
            // 1. Ölçekleme oranını hesapla
            float scaleFactor = ResolutionHelper.GetScaleFactor(this);

            // Eğer oran 1'e çok yakınsa işlem yapma
            if (Math.Abs(scaleFactor - 1.0f) < 0.01f) return;

            // 2. Formun kendisini ölçekle (Boyut)
            this.Width = (int)(this.Width * scaleFactor);
            this.Height = (int)(this.Height * scaleFactor);

            // 3. İçerikleri ölçekle
            ScaleUtils.ScaleControl(this, scaleFactor);

            // 4. Ekran ortasına al (Opsiyonel)
            this.CenterToScreen();
        }

        // DPI değiştiğinde (örn: pencereyi başka monitöre sürükleyince) tetiklenir
        protected override void OnDpiChanged(DpiChangedEventArgs e)
        {
            base.OnDpiChanged(e);
            
            // WinForms .NET Core/5+ genellikle bunu otomatik halleder
            // Ancak özel çizimler varsa burada refresh gerekebilir
            this.Invalidate();
        }
    }
}
