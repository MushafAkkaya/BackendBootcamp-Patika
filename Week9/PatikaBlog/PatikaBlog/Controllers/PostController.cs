using Microsoft.AspNetCore.Mvc;
using PatikaBlog.Models;

namespace PatikaBlog.Controllers
{
    public class PostController : Controller
    {
        public static List<Category> Categories = new List<Category>
        { new Category { Id = 1, Name = "Magazin"},
          new Category { Id = 2, Name = "Siyaset"},
          new Category { Id = 3, Name = "Spor"},
          new Category { Id = 4, Name = "Yemek"}
        };

        public static List<Post> Posts = new List<Post>();

        public IActionResult List()
        {

            var viewModel = Posts.Select(x => new PostListViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
            }).ToList();


            return View(viewModel);
        }


        [HttpGet]
        public IActionResult Add()
        {
          

            ViewBag.Categories = Categories.Select(x => new CategoryListViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
             
            return View();
        }

        [HttpPost]
        public IActionResult Add(PostAddViewModel formData)
        {

            if (!ModelState.IsValid)
            {

                ViewBag.Categories = Categories.Select(x => new CategoryListViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();

                return View(formData);

            }

            var newPost = new Post()
            {
                
                Title = formData.Title,
                Content = formData.Content,
                CategoryId = formData.CategoryId
            };

            if (Posts.Any())
            {
                newPost.Id = Posts.Max(x => x.Id) + 1;
            }
            else
            {
                newPost.Id = 1;
            }

            Posts.Add(newPost);

            return RedirectToAction("List");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var post = Posts.FirstOrDefault(x => x.Id == id);

            Posts.Remove(post);

            return RedirectToAction("List");

            
        }
    }
}
