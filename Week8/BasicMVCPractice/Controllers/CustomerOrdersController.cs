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
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Laptop", Price = 1200, Quantity = 1 },
                new Order { Id = 102, ProductName = "Mouse", Price = 50, Quantity = 2 }
            };

            var customerOrders = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(customerOrders);
        }
    }
}
