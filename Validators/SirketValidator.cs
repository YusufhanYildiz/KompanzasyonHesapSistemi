using FluentValidation;
using KompanzasyonHesapSistemi.Models;

namespace KompanzasyonHesapSistemi.Validators
{
    public class SirketValidator : AbstractValidator<Sirket>
    {
        public SirketValidator()
        {
            RuleFor(x => x.SirketAdi)
                .NotEmpty().WithMessage("Şirket adı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Şirket adı 100 karakterden uzun olamaz.");

            RuleFor(x => x.VergiNo)
                .NotEmpty().WithMessage("Vergi/TC No boş bırakılamaz.")
                .Length(10, 11).WithMessage("Vergi No 10, TC No 11 haneli olmalıdır.")
                .Matches("^[0-9]*$").WithMessage("Vergi/TC No sadece rakamlardan oluşmalıdır.");

            RuleFor(x => x.Adres)
                .MaximumLength(250).WithMessage("Adres 250 karakterden uzun olamaz.");

            RuleFor(x => x.Telefon)
                .Matches(@"^(\+90|0)?[0-9]{10}$").When(x => !string.IsNullOrEmpty(x.Telefon))
                .WithMessage("Geçerli bir telefon numarası giriniz (Örn: 5XX XXX XX XX).");
        }
    }
}
