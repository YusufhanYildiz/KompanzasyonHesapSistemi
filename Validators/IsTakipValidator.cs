using FluentValidation;
using KompanzasyonHesapSistemi.Models;

namespace KompanzasyonHesapSistemi.Validators
{
    public class IsTakipValidator : AbstractValidator<IsTakip>
    {
        public IsTakipValidator()
        {
            RuleFor(x => x.IsAciklamasi)
                .NotEmpty().WithMessage("İş açıklaması boş bırakılamaz.")
                .MaximumLength(500).WithMessage("İş açıklaması 500 karakterden uzun olamaz.");

            RuleFor(x => x.SirketId)
                .GreaterThan(0).WithMessage("Lütfen bir şirket seçiniz.");

            RuleFor(x => x.IsUcreti)
                .GreaterThanOrEqualTo(0).WithMessage("İş ücreti 0 veya daha büyük olmalıdır.");

            RuleFor(x => x.AlinanTutar)
                .GreaterThanOrEqualTo(0).WithMessage("Alınan tutar 0 veya daha büyük olmalıdır.");
            
            RuleFor(x => x.Tarih)
                .NotEmpty().WithMessage("Tarih seçilmelidir.");
        }
    }
}
