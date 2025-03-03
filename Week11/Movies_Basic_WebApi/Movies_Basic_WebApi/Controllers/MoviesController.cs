using Microsoft.AspNetCore.Mvc;
using Movies_Basic_WebApi.Models;

namespace Movies_Basic_WebApi.Controllers
{
    [ApiController] // bu bir api controllerdır.
    [Route("api/[controller]")] // isteği hangi şekilde uri'den atacağım.
    public class MoviesController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie{ Id = 1, Title = "Inception" , Director = "Christopher Nolan" , Year = 2010},
            new Movie {  Id = 2 , Title = "The Matrix" , Director = "Wachowski",  Year  = 1999}

        };

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _movies.Select(x => new MovieListResponse
            {
                Id = x.Id,
                Title = x.Title,
                Director = x.Director,
                Year = x.Year,
            }).ToList();
            
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
                return NotFound(); // return StatusCode(404);


            var response = new MovieListResponse()
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Year = movie.Year,
            };

            return Ok(response);

            

            // Find -> id ile nokta atışı bulur. Bulamazsa null döner.
            // First -> ilk olanı bulur, kalanı taramaz. bulamazsa hata verir.
            // FirstOrDefault -> ilk olanı bulur, kalanı taramaz. bulamazsa null döner.
            // Single -> tüm diziyi tarar, bir tane bulursa döner, birden fazla bulursa ya da bulamazsa error.
            // SingleOrDefault -> tüm diziyi tarar, bir tane bulursa döner, birden fazla bulursa error, bulamazsa null

            // 1 Ajda
            // 2 Hande
            // 3 Funda
            // 4 Sertan
            // 5 Tarkan
            // 6 Sertan
            // 7 Oğuzhan

            // Find > First/FirstOrDefault  > Single/SingleOrDefault
        }


        [HttpPost]
        public IActionResult AddMovie(MovieAddRequest request)
        {
            var newMovie = new Movie()
            {
                Id = _movies.Max(x => x.Id) + 1,
                Title = request.Title,
                Director = request.Director,
                Year = request.Year,
            };

            _movies.Add(newMovie);

            

            return CreatedAtAction(nameof(Get), new { id = newMovie.Id }, newMovie); // Status code 201

            return Created(); // status code 204

            // 20.30'a kadar ara.

        }

        [HttpPut("{id}")]
        public IActionResult ChangeMovie(int id, MovieUpdateRequest request)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
                return NotFound(); // return StatusCode(404);

            movie.Title = request.Title;
            movie.Director = request.Director;
            movie.Year = request.Year;

            return Ok();
            return NoContent(); // Update kısımlarında başarılı geri dönüş olarak görebilirsiniz ama ben Ok tercih ediyorum.

        }

        [HttpPatch("{id}")]
        public IActionResult ChangeTitle(int id, MovieTitleUpdateRequest request)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
                return NotFound(); // return StatusCode(404);

            movie.Title = request.Title;

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
                return NotFound(); // return StatusCode(404);

            _movies.Remove(movie);

            return Ok();
        }
    }
}
