using Library_EF_Live.Context;
using Library_EF_Live.Entities;
using Library_EF_Live.Models.Authors;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Library_EF_Live.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly LibraryDbContext _db;

        public AuthorsController(LibraryDbContext db)
        {
            _db = db;
        }


        // FirstName -> George
        // LastName -> Orwell

        [HttpPost]
        public IActionResult Add(AuthorAddRequest request)
        {
            var newAuthor = new AuthorEntity()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
            };

            _db.Authors.Add(newAuthor); // _db veritabanın kopyası/temsilcisi.

            _db.SaveChanges(); // işlemi gerçek veritabanında güncelle.

            return Created();

        }


        [HttpGet]
        public IActionResult ListAll()
        {
            var response = _db.Authors.Where(x => x.IsDeleted == false ).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(x => new AuthorListResponse
            {
                Id = x.Id,
                FullName = x.FirstName + " " + x.LastName
            }).ToList();

            // To.List() yük bindirir, mümkün olduğunca geç at.
            // OrderBy'ı IQueryable üzerinde atmak ile ToList sonrası atmak arasında büyük sistemsel yük farkı var.

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           
            var author = _db.Authors.Find(id);

            if(author is null)
            {
                return NotFound();
            }

            var response = new AuthorListResponse()
            {
                Id = author.Id,
                FullName = author.FirstName + " " + author.LastName
            };

            return Ok(response);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AuthorUpdateRequest request)
        {
            var author = _db.Authors.Find(id);

            if (author is null)
            {
                return NotFound();
            }

            author.FirstName = request.FirstName;
            author.LastName = request.LastName;
            author.ModifiedDate = DateTime.Now;

            _db.Authors.Update(author);
            _db.SaveChanges();

            return Ok("Uğur Sütlaç Yiyor.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = _db.Authors.Find(id);

            if (author is null)
            {
                return NotFound();
            }

            author.IsDeleted = true;
            author.ModifiedDate = DateTime.Now;
            _db.Authors.Update(author); // olmasa da olur da sen yine de yaz :D
            _db.SaveChanges();

            

            return Ok();
        }
        


    }
}
