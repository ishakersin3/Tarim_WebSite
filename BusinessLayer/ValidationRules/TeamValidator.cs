using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x=>x.PersonName).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez");
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Görev Alanı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 20 Karakterden Fazla Girmeyiniz");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen 5 Karakterden Az Girmeyiniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen Bu Alan İçin 50 Karakterden Fazla Girmeyiniz");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen Bu Alan İçin 3 Karakterden Az Girmeyiniz");
        }
    }
}
