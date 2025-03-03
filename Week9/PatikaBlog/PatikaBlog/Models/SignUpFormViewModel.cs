using System.ComponentModel.DataAnnotations;

namespace PatikaBlog.Models
{
    public class SignUpFormViewModel
    {
        public string Email { get; set; }


        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Şifreler eşleşmiyor.")]
        public string PasswordConfirm { get; set; }
        public IFormFile Image { get; set; }
    }
}
