# Kompanzasyon Hesap Sistemi / Compensation Calculation System

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg)
![Framework](https://img.shields.io/badge/.NET_Framework-4.8-purple.svg)

[Türkçe](#türkçe) | [English](#english)

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
    *   Windows 10 veya üzeri işletim sistemi.
    *   .NET Framework 4.8 Runtime (Windows 10/11'de genellikle yüklü gelir).

### Lisans
Bu proje MIT Lisansı altında sunulmaktadır.

---

<a name="english"></a>
## 🇺🇸 English

### About the Project
**Compensation Calculation System** is a professional desktop application designed for electrical engineers and technicians. It enables precise electrical compensation calculations, management of client/company records, and tracking of workflow processes. It offers a modern user experience with **Material Design** UI and supports **USB portable** operation.

### Key Features
*   **Advanced Calculations:** Automatically calculates Active/Reactive power, power factor, and capacitor/reactor requirements.
*   **Company Management:** Detailed database management for client companies.
*   **Job Tracking:** Integrated module to track projects and daily tasks.
*   **Dashboard:** Visual analytics and statistics using interactive charts (ScottPlot).
*   **Reporting:** Export calculation results and data to **PDF** (iText7) and **Excel** (ClosedXML) formats.
*   **Security:** Secure user authentication and data encryption (BCrypt).
*   **Backup:** Automatic or manual backup and restore system to prevent data loss.
*   **Portable Mode:** Can run directly from a USB drive without installation; data and logs travel with the app.
*   **Auto-Update:** Keeps the application up-to-date using Velopack.

### Technologies Used
Built with **C#** and **.NET Framework 4.8**.
*   **UI:** Windows Forms (MaterialSkin 2)
*   **Data Management:** JSON (Newtonsoft.Json)
*   **Reporting:** ClosedXML (Excel), iText7 (PDF)
*   **Charting:** ScottPlot
*   **Logging:** Serilog
*   **Deployment & Update:** Velopack
*   **Security:** BCrypt.Net-Next

### Installation & Usage
1.  **Download:**
    *   Download the latest release from the Releases page.
    *   Install via `Setup.exe` or simply run the `Portable` version.
2.  **Prerequisites:**
    *   Windows 10 or later.
    *   .NET Framework 4.8 Runtime (usually included in Windows 10/11).

### License
This project is licensed under the MIT License.
