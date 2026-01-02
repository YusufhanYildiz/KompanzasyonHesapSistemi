# Kompanzasyon Hesap Sistemi

## 📋 Proje Hakkında
Kompanzasyon Hesap Sistemi, elektrik sistemlerindeki kompanzasyon hesaplamalarını kolaylaştırmak, enerji takibini sağlamak ve reaktif ceza risklerini minimize etmek amacıyla geliştirilmiş kapsamlı bir masaüstü uygulamasıdır.

## 🚀 Özellikler

### ⚡ Hesaplama Modülü
* **Detaylı Analiz:** Aktif, endüktif ve kapasitif sayaç değerleri üzerinden kesin hesaplamalar.
* **Otomatik Öneri:** Gerekli kondansatör gücünü otomatik belirleme.
* **Ceza Takibi:** Reaktif ceza sınırlarına yaklaşıldığında görsel uyarılar.

### 🏢 Şirket Yönetimi
* **Çoklu Şirket Desteği:** Birden fazla işletmenin verilerini ayrı ayrı takip edebilme.
* **Cari Takip:** Şirketlere ait geçmiş hesaplamaların ve işlemlerin kaydı.

### 📊 Dashboard ve Raporlama
* **Görsel Grafikler:** Tüketim verilerinin grafiksel analizi.
* **Excel/PDF Dışa Aktarım:** Hesaplama sonuçlarının raporlanması.

### 🔒 Güvenlik ve Yedekleme
* **Kullanıcı Yetkilendirme:** Güvenli giriş sistemi.
* **Veri Yedekleme:** Otomatik ve manuel yedekleme seçenekleri.

## 🛠️ Teknolojiler
* **Dil:** C# (.NET Framework 4.8)
* **Arayüz:** Windows Forms (MaterialSkin ile modern arayüz)
* **Veritabanı:** JSON tabanlı yerel veri saklama (Hafif ve taşınabilir)
* **Kütüphaneler:** 
  * `Newtonsoft.Json` (Veri işleme)
  * `BCrypt.Net` (Şifreleme)
  * `ScottPlot` (Grafik çizimi)
  * `ClosedXML` & `iText7` (Raporlama)

## 📦 Kurulum

1. **Gereksinimler:**
   * Windows İşletim Sistemi (7/8/10/11)
   * .NET Framework 4.8 Runtime

2. **Çalıştırma:**
   * Projeyi indirin.
   * `bin/Release/net48` klasörü altındaki `.exe` dosyasını çalıştırın.
   * İlk girişte varsayılan yönetici ayarları yapılandırılacaktır.

## 🤝 Katkıda Bulunma
Projeye katkıda bulunmak isterseniz, lütfen bir "Pull Request" gönderin veya hataları "Issues" bölümünden bildirin.

## 📄 Lisans
Bu proje MIT Lisansı ile lisanslanmıştır.
