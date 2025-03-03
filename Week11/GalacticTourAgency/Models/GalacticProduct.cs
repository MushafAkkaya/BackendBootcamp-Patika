using System.ComponentModel.DataAnnotations;

namespace GalacticTourAgency.Models
{
    public class GalacticProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı gereklidir.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Ürün adı 3-100 karakter arasında olmalı.")]
        public string Name { get; set; }

        [Range(0.01, 1000, ErrorMessage = "Fiyat 0.01-1000 arasında olmalı.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Gezegen adı boş geçilemez.")]
        [RegularExpression("^(Merkür|Venüs|Mars)$", ErrorMessage = "Geçerli gezegene ait bir ürün değil.")]
        public string Planet { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Üretim Tarihi")]
        public DateTime ManifacturingDate { get; set; }

        [Range(1, 10)]
        [Display(Name = "Reyting")]
        public int GalacticRating { get; set; }
    }
}
