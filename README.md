# Kompanzasyon Hesap Sistemi / Compensation Calculation System

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg)
![Framework](https://img.shields.io/badge/.NET_Framework-4.8-purple.svg)

[Türkçe](#türkçe)

---

<a name="türkçe"></a>
## 🇹🇷 Türkçe

### Proje Hakkında
**Kompanzasyon Hesap Sistemi**, elektrik mühendisleri ve teknisyenleri için geliştirilmiş kapsamlı bir masaüstü yazılımıdır. Bu uygulama, elektrik tesislerindeki kompanzasyon hesaplamalarını hassas bir şekilde yapmanızı, müşteri/şirket kayıtlarını yönetmenizi ve iş süreçlerinizi takip etmenizi sağlar. **Material Design** arayüzü ile modern bir kullanıcı deneyimi sunar ve **USB taşınabilir (portable)** çalışma desteği sağlar.

### Özellikler
*   **Gelişmiş Hesaplamalar:** Aktif/Reaktif güç, güç faktörü ve kondansatör/reaktör ihtiyaçlarını otomatik hesaplar.
*   **Şirket Yönetimi:** Müşteri ve şirket bilgilerini detaylı bir şekilde kaydedin ve yönetin.
*   **İş Takibi:** Projelerinizi ve günlük işlerinizi entegre modül üzerinden takip edin.
*   **Dashboard:** Verilerinizi ve istatistiklerinizi görsel grafiklerle (ScottPlot) analiz edin.
*   **Raporlama:** Hesaplama sonuçlarını ve verileri **PDF** (iText7) ve **Excel** (ClosedXML) formatlarında dışa aktarın.
*   **Güvenlik:** Güvenli kullanıcı girişi ve şifreleme (BCrypt) ile verilerinizi koruyun.
*   **Yedekleme:** Veri kaybını önlemek için otomatik veya manuel yedekleme ve geri yükleme sistemi.
*   **Taşınabilir Mod (Portable):** Kurulum gerektirmeden USB bellek üzerinden çalıştırılabilir, loglar ve veriler uygulama ile taşınır.
*   **Otomatik Güncelleme:** Velopack altyapısı ile uygulama her zaman güncel kalır.

### Kullanılan Teknolojiler
Bu proje **C#** ve **.NET Framework 4.8** kullanılarak geliştirilmiştir.
*   **Arayüz:** Windows Forms (MaterialSkin 2)
*   **Veri Yönetimi:** JSON (Newtonsoft.Json)
*   **Raporlama:** ClosedXML (Excel), iText7 (PDF)
*   **Grafik & Görselleştirme:** ScottPlot
*   **Loglama:** Serilog
*   **Dağıtım & Güncelleme:** Velopack
*   **Güvenlik:** BCrypt.Net-Next

### Kurulum ve Kullanım
1.  **İndirme:**
    *   Releases sayfasından en son sürümü indirin.
    *   İster `Setup.exe` ile kurun, ister `Portable` sürümü indirip direkt çalıştırın.
2.  **Gereksinimler:**
    *   Windows 7 veya üzeri işletim sistemi.
    *   .NET Framework 4.8 Runtime (Windows 10/11'de genellikle yüklü gelir).

### Lisans
Bu proje MIT Lisansı altında sunulmaktadır.
