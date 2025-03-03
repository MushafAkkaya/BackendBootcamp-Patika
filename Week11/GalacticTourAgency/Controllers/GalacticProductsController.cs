using GalacticTourAgency.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GalacticTourAgency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalacticProductsController : ControllerBase
    {
        private static List<GalacticProduct> _products = new List<GalacticProduct>
        {
            new GalacticProduct { Id = 1, GalacticRating = 5, ManifacturingDate = DateTime.Now.AddYears(-1), Name = "Product 1", Planet = "Merkür", Price = 4 }
        };

        [HttpGet]
        public ActionResult<GalacticProduct> Get(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null) return NotFound();

            return Ok();
        }

        [HttpPost]
        public ActionResult<GalacticProduct> Post([FromBody] GalacticProduct product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            product.Id = _products.Max(x => x.Id) + 1;

            _products.Add(product);

            return CreatedAtAction(nameof(Get), new { id = product.Id}, product);
        }
    }
}
