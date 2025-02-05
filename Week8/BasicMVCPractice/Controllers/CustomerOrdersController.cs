using BasicMVCPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCPractice.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Veli",
                Email = "aliveli@gmail.com"
            };

            var order = new Order
            {
                Id = 1,
                ProductName = "Telefon",
                Price = 50000,
                Quantity = 1
            };

            List<Order> orders = new List<Order> { order };

            var customerOrders = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(customerOrders);
        }
    }
}
