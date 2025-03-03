using Microsoft.AspNetCore.Mvc;
using Movies_Basic_WebApi.Models;

namespace Movies_Basic_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>()
        {
            new Movie { Id = 1, Title = "Inception", Director = "Christoper Nolan", Year = 2010},
            new Movie { Id = 2, Title = "The Matrix", Director = "Wachowski", Year = 1999}
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
                return NotFound();

            var response = new MovieListResponse()
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Year = movie.Year
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult AddMovie(MovieAddRequest request)
        {
            var newMovie = new Movie()
            {
                Id = _movies.Max(x => x.Id) + 1,
                Title = request.Title,
                Director = request.Director,
                Year = request.Year
            };

            _movies.Add(newMovie);

            return CreatedAtAction(nameof(Get), new {id = newMovie.Id}, newMovie);
        }

        [HttpPut("{id}")]
        public IActionResult ChangeMovie(int id, MovieUpdateRequest request)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
                return NotFound();

            movie.Title = request.Title;
            movie.Director = request.Director;
            movie.Year = request.Year;

            return Ok(movie);
        }

    }
}
