using System.ComponentModel.DataAnnotations;

namespace CustomIdentity_Live.Models
{
    public class RegisterRequest
    {
        [EmailAddress]
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}
