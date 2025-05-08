using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınız Giriniz!")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
