using FluentValidation;
using MovieWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebSite.Validators
{
    public class WebsiteValidator : AbstractValidator<Website>
    {
        public WebsiteValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Film - Dizi adı boş geçilemez.")
                .Length(2, 150).WithMessage("Karakter sayısı en az 2 olmalıdır.");

            RuleFor(x => x.ReleaseYear).GreaterThanOrEqualTo(1500).WithMessage("Lütfen doğru bir tarih giriniz.");




            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Lütfen 500 karakterden fazla açıklama metni girmeyiniz.").
                MinimumLength(2).WithMessage("Lütfen 2 karakterden fazla açıklama metni giriniz.");

            RuleFor(x => x.Rating).InclusiveBetween(1, 10).WithMessage("Lütfen 1 ile 10 arasında bir Imdb Puanı giriniz.");

            RuleFor(x => x.WatchTime).Custom((watchTime, context) =>
            {
                var arr = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                if (!arr.Contains(watchTime.Substring(0, 1)))
                {
                    context.AddFailure("Film izleme süresi sayı ile başlamalıdır.");
                }
            });

            RuleFor(x => x.Director).MinimumLength(2).WithMessage("Karakter sayısı en az 2 olmalıdır.");
            RuleFor(x => x.Director).Matches(@"^[a-zA-Z, ]*$").WithMessage("Lütfen sadece harf giriniz.");

            RuleFor(x => x.Actors).MinimumLength(2).WithMessage("Karakter sayısı en az 2 olmalıdır.");
            RuleFor(x => x.Actors).Matches(@"^[a-zA-Z, ]*$").WithMessage("Lütfen sadece harf giriniz.");

        }
    }
}
