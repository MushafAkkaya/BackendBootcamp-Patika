using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurvivorWebApi.Context;
using SurvivorWebApi.Entites;
using SurvivorWebApi.Models.Categories;
using SurvivorWebApi.Models.Competitors;

namespace SurvivorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SurvivorDbContext _db;
        public CategoriesController(SurvivorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _db.Categories.Where(x => x.IsDeleted == false).OrderBy(x => x.Name).Select(x => new CategoryListResponse
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _db.Categories.Find(id);
            if (category == null) return NotFound();

            var response = new CategoryListResponse()
            {
                Id = category.Id,
                Name = category.Name
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(CategoryAddRequest request)
        {
            var newCategory = new CategoryEntity()
            {
                Name = request.Name,
                ModifiedDate = DateTime.Now
            };

            _db.Categories.Add(newCategory);
            _db.SaveChanges();

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryUpdateRequest request)
        {
            var category = _db.Categories.Find(id);
            if (category == null) return NotFound();

            category.Name = request.Name;
            category.ModifiedDate = DateTime.Now;

            _db.Categories.Update(category);
            _db.SaveChanges();
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _db.Categories.Find(id);

            if (category == null) return NotFound();

            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;

            _db.Categories.Update(category);
            _db.SaveChanges();

            return Ok();
        }
    }
}
