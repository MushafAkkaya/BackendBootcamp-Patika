using CrazyMusiciansWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusiciansWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static List<Artist> _artist = new List<Artist>()
        {
            new Artist { Id = 1, FullName = "Ahmet Çalgı", Job = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Artist { Id = 2, FullName = "Zeynep Melodi", Job = "Popüler Melodi Yazarı", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new Artist { Id = 3, FullName = "Cemil Akor", Job = "Çılgın Akorist", FunFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new Artist { Id = 4, FullName = "Fatma Nota", Job = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar" },
            new Artist { Id = 5, FullName = "Hasan Ritim", Job = "Ritim Canavan", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new Artist { Id = 6, FullName = "Elif Armoni", Job = "Armoni Ustası", FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new Artist { Id = 7, FullName = "Ali Perde", Job = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new Artist { Id = 8, FullName = "Ayşe Rezonans", Job = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new Artist { Id = 9, FullName = "Murat Ton", Job = "Tonlama Meraklısı", FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
            new Artist { Id = 10, FullName = "Selin Akor", Job = "Akor Sihirbazı", FunFeature = "Akorları değiştirdiğinde bazen sessiz bir hava yaratır" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _artist.Select(x => new ArtistListResponse
            {
                Id = x.Id,
                FullName = x.FullName,
                Job = x.Job,
                FunFeature = x.FunFeature,
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id:int:min(1)}")]
        public IActionResult GetById(int id)
        {
            var artist = _artist.FirstOrDefault(x => x.Id == id);

            if (artist == null)
                return NotFound();

            var response = new ArtistListResponse()
            {
                Id = artist.Id,
                FullName = artist.FullName,
                Job = artist.Job,
                FunFeature = artist.FunFeature,
            };

            return Ok(response);
        }

        [HttpPost("create-artist")]
        public IActionResult AddArtist(ArtistAddRequest request)
        {
            var newArtist = new Artist()
            {
                Id = _artist.Max(x => x.Id) + 1,
                FullName = request.FullName,
                Job = request.Job,
                FunFeature = request.FunFeature,
            };

            _artist.Add(newArtist);

            return CreatedAtAction(nameof(GetById), new { id = newArtist.Id }, newArtist);
        }

        [HttpPut("update/{id:int:min(1)}")]
        public IActionResult UpdateArtist(int id, ArtistUpdateRequest request)
        {
            var artist = _artist.FirstOrDefault(x => x.Id == id);

            if (artist == null)
                return NotFound();

            artist.FullName = request.FullName;
            artist.Job = request.Job;
            artist.FunFeature = request.FunFeature;

            return Ok();
        }

        [HttpPatch("change-name/{id:int:min(1)}")]
        public IActionResult ChangeName(int id, ArtistNameChangeRequest request)
        {
            var artist = _artist.FirstOrDefault(x => x.Id == id);

            if (artist == null)
                return NotFound();

            artist.FullName = request.FullName;

            return Ok();
        }

        [HttpDelete("cancel/{id:int:min(1)}")]
        public IActionResult Delete(int id)
        {
            var artist = _artist.FirstOrDefault(x => x.Id == id);

            if (artist is null)
                return NotFound();

            _artist.Remove(artist);

            return Ok();
        }

        [HttpPost("search")]
        public ActionResult<IEnumerable<ArtistListResponse>> Search([FromQuery] string fullName)
        {
            return Ok(Enumerable.Empty<ArtistListResponse>());
        }
    }
}
