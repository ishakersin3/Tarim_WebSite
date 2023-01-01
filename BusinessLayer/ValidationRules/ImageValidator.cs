using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator:AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Görsel Başlığı Alanı Boş Geçilemez");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Görsel Açıklamasını Alanı Boş Geçilemez");
            RuleFor(x=>x.ImagreUrl).NotEmpty().WithMessage("Görsel Yolunu Alanı Boş Geçilemez");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Girmeyiniz");
            RuleFor(x => x.Title).MinimumLength(4).WithMessage("Lütfen 4 Karakterden Az Girmeyiniz");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Girmeyiniz");
            RuleFor(x => x.Description).MinimumLength(1).WithMessage("Lütfen 1 Karakterden Az Girmeyiniz");
        }
    }
}
