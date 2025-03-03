using System.ComponentModel.DataAnnotations;

namespace CrazyMusiciansWebApi.Models
{
    public class ArtistNameChangeRequest
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(50)]
        public string FullName { get; set; }
    }
}
