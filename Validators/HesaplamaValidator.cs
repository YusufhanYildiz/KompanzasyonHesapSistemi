using FluentValidation;
using KompanzasyonHesapSistemi.Models;

namespace KompanzasyonHesapSistemi.Validators
{
    public class HesaplamaValidator : AbstractValidator<Hesaplama>
    {
        public HesaplamaValidator()
        {
            RuleFor(x => x.SirketId)
                .GreaterThan(0).WithMessage("Lütfen bir şirket seçiniz.");

            RuleFor(x => x.Tarih)
                .NotEmpty().WithMessage("Tarih seçilmelidir.");

            // Negatif değer kontrolleri
            RuleFor(x => x.OncekiAktif).GreaterThanOrEqualTo(0).WithMessage("Önceki Aktif 0'dan küçük olamaz.");
            RuleFor(x => x.OncekiEnduktif).GreaterThanOrEqualTo(0).WithMessage("Önceki Endüktif 0'dan küçük olamaz.");
            RuleFor(x => x.OncekiKapasitif).GreaterThanOrEqualTo(0).WithMessage("Önceki Kapasitif 0'dan küçük olamaz.");

            RuleFor(x => x.MevcutAktif).GreaterThanOrEqualTo(0).WithMessage("Mevcut Aktif 0'dan küçük olamaz.");
            RuleFor(x => x.MevcutEnduktif).GreaterThanOrEqualTo(0).WithMessage("Mevcut Endüktif 0'dan küçük olamaz.");
            RuleFor(x => x.MevcutKapasitif).GreaterThanOrEqualTo(0).WithMessage("Mevcut Kapasitif 0'dan küçük olamaz.");

            // Mantıksal kontroller (Cross-property validation)
            RuleFor(x => x.MevcutAktif)
                .GreaterThanOrEqualTo(x => x.OncekiAktif)
                .WithMessage("Mevcut aktif tüketim, önceki değerden küçük olamaz.");

            RuleFor(x => x.MevcutEnduktif)
                .GreaterThanOrEqualTo(x => x.OncekiEnduktif)
                .WithMessage("Mevcut endüktif tüketim, önceki değerden küçük olamaz.");

            RuleFor(x => x.MevcutKapasitif)
                .GreaterThanOrEqualTo(x => x.OncekiKapasitif)
                .WithMessage("Mevcut kapasitif tüketim, önceki değerden küçük olamaz.");
            
            RuleFor(x => x.AktifTuketim)
                .GreaterThan(0)
                .WithMessage("Aktif tüketim farkı 0'dan büyük olmalıdır.");
        }
    }
}
