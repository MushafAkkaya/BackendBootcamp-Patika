using Microsoft.AspNetCore.Mvc;
using PatikaBlog.Models;
using System.ComponentModel.DataAnnotations;

namespace PatikaBlog.Controllers
{
    public class UserController : Controller
    {
        public static List<User> users = new List<User>()
        {
            new User{Email = "AjdaPekkan@gmail.com", Password="123",ImageUrl="udemyfatura-0a34bc37-96f7-4557-bb77-fc52795dd388.png"},
            new User{Email ="Sortac@kibris.com", Password="sekerpatlat",ImageUrl="yoooooooooooooooo-93f09a0b-3e24-4d5c-9e4b-43f2c3d45984.jpg" }
        };


        public IActionResult list()
        {
            var viewModel = users.Select(x => new UserListViewModel
            {
                Email = x.Email,
                ImageUrl = x.ImageUrl,
            }).ToList();

            return View(viewModel);
        }
    }
}
