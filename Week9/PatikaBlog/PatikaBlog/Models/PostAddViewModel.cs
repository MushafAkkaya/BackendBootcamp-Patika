using System.ComponentModel.DataAnnotations;

namespace PatikaBlog.Models
{
    public class PostAddViewModel
    {
        [Required(ErrorMessage = "Başlık eklemek zorunludur.")]
        [MinLength(10,ErrorMessage = "Başlık en az 10 karakter uzunluğunda olmalıdır.")]
        [MaxLength(100,ErrorMessage ="Başlık en fazla 100 karakter uzunluğunda olabilir.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik metni eklemek zorunludur.")]
        [MinLength(100, ErrorMessage = "İçerik en az 100 karakter uzunluğunda olmalıdır.")]
        [MaxLength(500,ErrorMessage = "İçerik en fazla 500 karakter uzunluğunda olmalıdır.")]
        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}
