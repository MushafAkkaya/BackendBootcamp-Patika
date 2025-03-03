using Microsoft.AspNetCore.Mvc;

namespace PatikaBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List", "Post");
        }
    }
}
