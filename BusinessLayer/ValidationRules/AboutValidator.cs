﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş bırakılamaz !");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Resim kısmı boş bırakılamaz !");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisini giriniz !");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakterlik açıklama bilgisini giriniz !");
        }
    }
}
