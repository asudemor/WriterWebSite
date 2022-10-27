﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı - Soyadı Boş Geçilemez...");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez...");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez...");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("2 Karakterden Uzun Bir İsim Giriniz...");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("50 Karakterden Kısa Bir İsim Giriniz...");
        }
    }
}
