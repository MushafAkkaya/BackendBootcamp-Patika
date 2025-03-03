using Microsoft.AspNetCore.Mvc;
using PatikaBlog.Models;

namespace PatikaBlog.Controllers
{
    public class CategoryController : Controller
    {
        // Link ile tetikleniyorsa -> HttpGet
        // Form'daki buton ile tetikleniyorsa -> HttpPost

        public static List<Category> Categories = new List<Category>
        { new Category { Id = 1, Name = "Magazin"},
          new Category { Id = 2, Name = "Siyaset"},
          new Category { Id = 3, Name = "Spor"},
          new Category { Id = 4, Name = "Yemek"}
        };

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CategoryAddViewModel formData)
        {

            var newCategory = new Category
            {
                Id = Categories.Max(x => x.Id) + 1,
                Name = formData.CategoryName
            };

            Categories.Add(newCategory);




            return RedirectToAction("List");
        }

        [HttpGet]
        // Kategorileri ekleniyor mu diye test için açtığım sayfa. 
        public IActionResult List()
        {
            var viewModel = Categories.Select(x => new CategoryListViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();


            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = Categories.FirstOrDefault(x => x.Id == id);

            var categoryUpdateViewModel = new CategoryUpdateViewModel()
            {
                Id = category.Id,
                Name = category.Name,
            };

            return View(categoryUpdateViewModel);
        }

        [HttpPost]
        public IActionResult Update(CategoryUpdateViewModel formData)
        {

            var category = Categories.FirstOrDefault(x => x.Id == formData.Id);

            category.Name = formData.Name;

            return RedirectToAction("List");
        }
        
        // Httpget, yazmaya gerek yok, çünkü bu isimde bir tek bu var zaten.
        public IActionResult Delete(int id)
        {
            var category = Categories.FirstOrDefault(x => x.Id == id);

            Categories.Remove(category);

            return RedirectToAction("List");
        }
    }
}

// CRUD -> Create , Read , Update , Delete