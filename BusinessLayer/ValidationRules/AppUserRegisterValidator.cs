using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilmez !");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilmez !");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilmez !");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilmez !");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilmez !");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilmez !");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız !");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız !");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler Birbiriyle Uyuşmuyor");
        }
    }
}
