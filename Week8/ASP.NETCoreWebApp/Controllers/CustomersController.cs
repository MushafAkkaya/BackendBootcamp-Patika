using ASP.NETCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApp.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Jack",
                LastName = "Sparrow",
                Email = "jacksparrow@gmail.com"
            };

            var vievModel = new CustomerViewModel
            {
                Customer = customer,
                WelcomeMessage = "Welcome to our customer portal!"
            };

            return View(vievModel);
        }
    }
}
