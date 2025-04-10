using System.ComponentModel.DataAnnotations;

namespace IdentityAndDataProtectionPractice.Models
{
    public class UserRegisterRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
