# Kompanzasyon Hesap Sistemi / Compensation Calculation System

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg)
![Framework](https://img.shields.io/badge/.NET-9.0-purple.svg)

[Türkçe](#türkçe) | [English](#english)

---

<a name="türkçe"></a>
## 🇹🇷 Türkçe

### Proje Hakkında
**Kompanzasyon Hesap Sistemi**, elektrik mühendisleri ve teknisyenleri için geliştirilmiş kapsamlı bir masaüstü yazılımıdır. Bu uygulama, elektrik tesislerindeki kompanzasyon hesaplamalarını hassas bir şekilde yapmanızı, müşteri/şirket kayıtlarını yönetmenizi ve iş süreçlerinizi takip etmenizi sağlar. Modern arayüzü ve güçlü raporlama özellikleri ile karmaşık hesaplamaları basitleştirir.

### Özellikler
*   **Gelişmiş Hesaplamalar:** Aktif/Reaktif güç, güç faktörü ve kondansatör/reaktör ihtiyaçlarını otomatik hesaplar.
*   **Şirket Yönetimi:** Müşteri ve şirket bilgilerini detaylı bir şekilde kaydedin ve yönetin.
*   **İş Takibi:** Projelerinizi ve günlük işlerinizi entegre modül üzerinden takip edin.
*   **Dashboard:** Verilerinizi ve istatistiklerinizi görsel grafiklerle (LiveCharts, ScottPlot) analiz edin.
*   **Raporlama:** Hesaplama sonuçlarını ve verileri **PDF** (QuestPDF) ve **Excel** (ClosedXML) formatlarında dışa aktarın.
*   **Güvenlik:** Güvenli kullanıcı girişi ve şifreleme (BCrypt) ile verilerinizi koruyun.
*   **Yedekleme:** Veri kaybını önlemek için otomatik veya manuel yedekleme sistemi.

### Kullanılan Teknolojiler
Bu proje **C#** ve **.NET 9.0** kullanılarak geliştirilmiştir.
*   **Arayüz:** Windows Forms (WinForms)
*   **Veri & Raporlama:** ClosedXML, QuestPDF, Newtonsoft.Json
*   **Grafik & Görselleştirme:** LiveCharts, ScottPlot
*   **Güvenlik:** BCrypt.Net-Next

### Kurulum ve Kullanım
1.  **Gereksinimler:**
    *   Windows 10 veya üzeri işletim sistemi.
    *   .NET 9.0 Desktop Runtime yüklü olmalıdır.
2.  **Projeyi Çalıştırma:**
    *   Projeyi Releases kısmından 64 bit veya 32 bit olarak bilgisayarınıza indirin (Clone veya Zip).
    *   Exe olarak kurun ve çalıştırın.

### Lisans
Bu proje MIT Lisansı altında sunulmaktadır.

---

<a name="english"></a>
## 🇺🇸 English

### About the Project
**Compensation Calculation System** is a professional desktop application designed for electrical engineers and technicians. It enables precise electrical compensation calculations, management of client/company records, and tracking of workflow processes. With its modern interface and powerful reporting capabilities, it simplifies complex engineering tasks.

### Key Features
*   **Advanced Calculations:** Automatically calculates Active/Reactive power, power factor, and capacitor/reactor requirements.
*   **Company Management:** Detailed database management for client companies.
*   **Job Tracking:** Integrated module to track projects and daily tasks.
*   **Dashboard:** Visual analytics and statistics using interactive charts (LiveCharts, ScottPlot).
*   **Reporting:** Export calculation results and data to **PDF** (QuestPDF) and **Excel** (ClosedXML) formats.
*   **Security:** Secure user authentication and data encryption (BCrypt).
*   **Backup:** Automated and manual backup system to prevent data loss.

### Technologies Used
Built with **C#** and **.NET 9.0**.
*   **UI:** Windows Forms (WinForms)
*   **Data & Reporting:** ClosedXML, QuestPDF, Newtonsoft.Json
*   **Charting:** LiveCharts, ScottPlot
*   **Security:** BCrypt.Net-Next

### Installation & Usage
1.  **Prerequisites:**
    *   Windows 10 or later.
    *   .NET 9.0 Desktop Runtime.
2.  **Running the Project:**
    *   Clone or download the repository.
    *   Open `KompanzasyonHesapSistemi.sln` with Visual Studio 2022 (or newer).
    *   Build the solution and run the application.

### License
This project is licensed under the MIT License.
