using GalacticTourAgency.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GalacticTourAgency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalacticToursController : ControllerBase
    {
        private static List<GalacticTour> _galacticTours = new List<GalacticTour>
        {
            new GalacticTour { Id = 1, PlanetName = "Mars", Duration = "2 ay", Price = 5000000 },
            new GalacticTour { Id = 2, PlanetName = "Venüs", Duration = "1 ay", Price = 40000 }
        };

        [HttpGet]
        public IEnumerable<GalacticTour> GetAll()
        {
            return _galacticTours;
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<GalacticTour> GetTour(int id)
        {
            var tour = _galacticTours.FirstOrDefault(x => x.Id == id);

            if (tour == null)
            {
                return NotFound();
            }
            return Ok(tour);
        }

        [HttpGet("planet/{planetName:alpha}")]
        public ActionResult<IEnumerable<GalacticTour>> GetToursByPlanet(string planetName)
        {
            var planetTours = _galacticTours.Where(x => x.PlanetName.Equals(planetName, StringComparison.OrdinalIgnoreCase));

            if (!planetTours.Any())
            {
                return NotFound();
            }

            return Ok(planetTours);
        }

        [HttpGet("price-range")]
        public ActionResult<IEnumerable<GalacticTour>> GetToursByPriceRange([FromQuery] decimal minPrice, [FromQuery] decimal maxPrice)
        {
            var filteredTours = _galacticTours.Where(x => x.Price >= minPrice && x.Price <= maxPrice);

            return Ok(filteredTours);
        }

        [HttpPost]
        public ActionResult<GalacticTour> Create([FromBody] GalacticTour tour)
        {
            var id = _galacticTours.Max(x => x.Id) + 1;
            tour.Id = id;

            _galacticTours.Add(tour);

            return CreatedAtAction(nameof(GetTour), new { id = tour.Id }, tour);
        }

        [HttpPost("create-package")]
        public ActionResult<GalacticTour> CreateTourPackage([FromBody] GalacticTourPackage tourPackage)
        {
            var tour = new GalacticTour
            {
                Id = _galacticTours.Max(x => x.Id) + 1,
                PlanetName = tourPackage.Destination,
                Duration = $"{tourPackage.DurationInDays} Gün",
                Price = tourPackage.BasePrice * tourPackage.DurationInDays
            };

            _galacticTours.Add(tour);

            return CreatedAtAction(nameof(GetTour), new { id = tour.Id }, tour);
        }

        [HttpPut("update/{id:int:min(1)}/{newPlanetName}")]
        public IActionResult UpdateTourPlanet(int id, string newPlanetName)
        {
            var tour = _galacticTours.FirstOrDefault(x => x.Id == id);

            if (tour == null)
            {
                return NotFound();
            }

            tour.PlanetName = newPlanetName;

            return NoContent();
        }

        [HttpDelete("{id:int:min(1)}")]
        [HttpDelete("cancel/{tourName}")]
        public IActionResult CancelTour(int? id, string tourName)
        {
            GalacticTour tourToRemove;

            if (id.HasValue)
            {
                tourToRemove = _galacticTours.FirstOrDefault(x =>x.Id == id);
            }
            else
            {
                tourToRemove = _galacticTours.FirstOrDefault(x => x.PlanetName.Equals(tourName, StringComparison.OrdinalIgnoreCase));
            }

            if (tourToRemove == null)
                return NotFound();

            _galacticTours.Remove(tourToRemove);

            return NoContent();
        }

        [HttpPatch("reschedule/{id:int:min(1)}/{newDate:datetime}")]
        public IActionResult RescheduleTour(int id, DateTime newDate, [FromBody] JsonPatchDocument<GalacticTour> patchDocument)
        {
            var tour = _galacticTours.FirstOrDefault(x =>x.Id == id);

            if (tour == null)  return NotFound();

            tour.DepartureDate = newDate;

            patchDocument.ApplyTo(tour);
            return NoContent();
        }

        [HttpPost("complex-search")]
        public ActionResult<IEnumerable<GalacticTour>> ComplexSearch([FromQuery] string name, [FromQuery] decimal? minPrice, [FromHeader(Name ="X-Planet")] string planet, [FromBody] SearchCriteria searchCriteria)
        {
            return Ok(Enumerable.Empty<GalacticTour>());
        }
    }
}
