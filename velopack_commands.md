# Velopack Yayınlama ve Kurulum Dosyası Oluşturma

Bu döküman, Velopack kullanarak uygulamanızın yeni sürümlerini (1.3.0) nasıl paketleyeceğinizi ve kurulum dosyalarını nasıl oluşturacağınızı açıklar.

## Hazırlık Adımları

Komutları çalıştırmadan önce uygulamanızın en güncel halini `./publish` klasörüne çıkardığınızdan emin olun:

```powershell
dotnet publish KompanzasyonHesapSistemi.csproj -c Release -o ./publish
```

## 1. Paketleme ve Release Oluşturma Komutu

Aşağıdaki komut, uygulamanızı paketler, `./Releases` klasöründeki önceki sürümlerle karşılaştırarak delta paketleri oluşturur ve güncel bir `Setup.exe` (kurulum dosyası) üretir.

```powershell
vpk pack --packId "KompanzasyonHesap" --packVersion "1.3.0" --packDir "./publish" --mainExe "KompanzasyonHesapSistemi.exe" --icon "Calculator_30001.ico" --outputDir "./Releases"
```

### Parametre Açıklamaları:
- `--packId`: Uygulamanın benzersiz kimliği.
- `--packVersion`: Yeni sürüm numarası (İsteğinize göre **1.3.0** olarak güncellendi).
- `--packDir`: Derlenmiş dosyaların bulunduğu klasör.
- `--mainExe`: Uygulamanın ana çalıştırılabilir dosyası.
- `--icon`: Kurulum ve uygulama ikonu.
- `--outputDir`: Oluşturulan paketlerin ve `Setup.exe` dosyasının kaydedileceği klasör.

## 2. Kurulum Dosyası (Installer)

Yukarıdaki komutu çalıştırdığınızda, `./Releases` klasörü içerisinde şu dosya oluşacaktır:
- **KompanzasyonHesap-win-Setup.exe**: Bu dosya son kullanıcıya göndereceğiniz kurulum dosyasıdır.

## 3. GitHub'a Hangi Dosyalar Yüklenmeli?

Velopack'in otomatik güncelleme (auto-update) özelliğinin çalışması ve kullanıcıların kurulum yapabilmesi için `./Releases` klasöründeki şu dosyaları GitHub Release kısmına yüklemelisiniz:

1.  **`KompanzasyonHesap-win-Setup.exe`**: Kullanıcıların uygulamayı kurması için gereken ana dosya.
2.  **`RELEASES`**: Güncelleyici için kritik olan sürüm listesi dosyası.
3.  **`releases.win.json`**: Yeni nesil Velopack metadata dosyası.
4.  **`*.nupkg` (Full ve Delta)**: Güncelleme paketleri (Örn: `KompanzasyonHesap-1.3.0-full.nupkg`).
5.  **`KompanzasyonHesap-win-Portable.zip`** (Opsiyonel): Kurulum istemeyen kullanıcılar için taşınabilir sürüm.

> [!IMPORTANT]
> `RELEASES` ve `releases.win.json` dosyaları olmadan uygulamanız yeni güncellemeleri kontrol edemez. Bu dosyaları her yeni sürümde mutlaka yüklemelisiniz.

## 4. Uzak Sunucuya Yükleme (Otomatik)

```powershell
vpk upload github --repoUrl "https://github.com/kullanici/repo" --publish --outputDir "./Releases"
```
