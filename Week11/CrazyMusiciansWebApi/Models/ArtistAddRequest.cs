using System.ComponentModel.DataAnnotations;

namespace CrazyMusiciansWebApi.Models
{
    public class ArtistAddRequest
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(100)]
        public string Job { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string FunFeature { get; set; }
    }
}
