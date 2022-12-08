using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriği Boş Geçilemez.");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Blog Görseli Boş Geçilemez.");

            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("5 Karakterden Uzun Bir Başlık Giriniz...");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("5 Karakterden Uzun Bir İçerik Giriniz...");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("150 Karakterden Kısa Bir Başlık Giriniz...");
        }
    }
}
