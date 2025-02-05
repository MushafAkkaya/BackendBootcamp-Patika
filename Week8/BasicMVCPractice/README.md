# Basic MVC Project

## Overview
This project is a simple ASP.NET MVC application designed to display customer and order information. The application follows the MVC architecture, incorporating models, a view model, controllers, and views to provide a structured and maintainable implementation.

## Features
- Displays customer details such as ID, first name, last name, and email.
- Lists orders associated with a customer, including order ID, product name, price, and quantity.
- Uses a ViewModel to combine customer and order data.
- Implements a controller to process and send data to the view.
- Uses Razor views to render customer and order details in an HTML table.

## Project Structure

```
BasicMVCPractice/
│── Controllers/
│   ├── CustomerOrdersController.cs
│── Models/
│   ├── Customer.cs
│   ├── Order.cs
│   ├── CustomerOrderViewModel.cs
│── Views/
│   ├── CustomerOrders/
│   │   ├── Index.cshtml
│── wwwroot/
│── Program.cs
│── Startup.cs
│── appsettings.json
```

## Implementation Steps

### 1. Model Creation
#### Customer Model
The `Customer` class represents a customer with the following properties:
```csharp
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
```
#### Order Model
The `Order` class represents an order with the following properties:
```csharp
public class Order
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

### 2. ViewModel Creation
The `CustomerOrderViewModel` is used to combine customer and order data:
```csharp
public class CustomerOrderViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
}
```

### 3. Controller Implementation
The `CustomerOrdersController` is responsible for handling customer order data:
```csharp
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

        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        return View(viewModel);
    }
}
```

### 4. View Implementation
The `Index.cshtml` file displays customer and order information:
```html
@model BasicMVCPractice.Models.CustomerOrderViewModel

<!DOCTYPE html>
<html>
<head>
    <title>Customer Orders</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css">
</head>
<body>
     <div class="container">
     <h1>@Model.Customer</h1>
     <h2>Customer Details</h2>
     <p><strong>Id:</strong> @Model.Customer.Id</p>
     <p><strong>First Name:</strong> @Model.Customer.FirstName</p>
     <p><strong>Last Name:</strong> @Model.Customer.LastName</p>
     <p><strong>Email:</strong> @Model.Customer.Email</p>

     <h2>Order Details</h2>

     <table class="table">
         <thead>
             <tr>
                 <th scope="col">Id</th>
                 <th scope="col">ProductName</th>
                 <th scope="col">Price</th>
                 <th scope="col">Quantity</th>
             </tr>
         </thead>
         <tbody>
             @foreach (var item in Model.Orders)
             {
                 <tr>
                     <td>@item.Id</td>
                     <td>@item.ProductName</td>
                     <td>@item.Price</td>
                     <td>@item.Quantity</td>
                 </tr>
             }
         </tbody>
     </table>
 </div>
</body>
</html>
```

## How to Run the Project
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/your-repository.git
   cd your-repository
   ```
2. Open the project in Visual Studio.
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Run the application:
   ```sh
   dotnet run
   ```
5. Open the browser and navigate to:
   ```
   http://localhost:5000/CustomerOrders
   ```

## Technologies Used
- ASP.NET Core MVC
- C#
- Razor View Engine
- Bootstrap for styling

## License
This project is open-source and available under the MIT License.

