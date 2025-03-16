using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurvivorWebApi.Context;
using SurvivorWebApi.Entites;
using SurvivorWebApi.Models.Competitors;

namespace SurvivorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _db;
        public CompetitorsController(SurvivorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _db.Competitors.Where(x => x.IsDeleted == false).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(x => new CompetitorListResponse
            {
                Id = x.Id,
                FullName = x.FirstName + " " + x.LastName
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var competitor = _db.Competitors.Find(id);
            if (competitor == null) return NotFound();

            var response = new CompetitorListResponse()
            {
                Id = competitor.Id,
                FullName = competitor.FirstName + " " + competitor.LastName
            };

            return Ok(response);
        }

        [HttpGet("/categories/{categoryId}")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var competitor = _db.Competitors.Where(x => x.CategoryId == categoryId).Select(x => new CompetitorCategoryListResponse
            {
                Id = x.Id,
                FullName = x.FirstName + " " + x.LastName,
                CategoryId = x.CategoryId
            }).ToList();

            if (competitor == null) return NotFound();

            return Ok(competitor);
        }

        [HttpPost]
        public IActionResult Add(CompetitorAddRequest request)
        {
            var newCompetitor = new CompetitorsEntity()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                ModifiedDate = DateTime.Now
            };

            _db.Competitors.Add(newCompetitor);
            _db.SaveChanges();

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CompetitorUpdateRequest request)
        {
            var competitor = _db.Competitors.Find(id);
            if (competitor == null) return NotFound();

            competitor.FirstName = request.FirstName;
            competitor.LastName = request.LastName;
            competitor.ModifiedDate = DateTime.Now;

            _db.Competitors.Update(competitor);
            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var competitor = _db.Competitors.Find(id);

            if(competitor == null) return NotFound();

            competitor.IsDeleted = true;
            competitor.ModifiedDate = DateTime.Now;

            _db.Competitors.Update(competitor);
            _db.SaveChanges();

            return Ok();
        }
    }
}
