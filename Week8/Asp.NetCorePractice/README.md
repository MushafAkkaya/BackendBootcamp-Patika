# ASP.NET Core MVC Practice

## Overview
This project demonstrates how to set up an ASP.NET Core Empty project and configure it according to the MVC (Model-View-Controller) design pattern. The necessary directories and configurations are included to support controllers, models, views, static files, and routing.

## Project Structure
The following directories should be created within the project:

- **Controllers**: Stores controller classes that handle incoming requests.
- **Models**: Contains data models for handling business logic and database interactions.
- **Views**: Holds Razor view files (`.cshtml`) used for rendering HTML output.
- **wwwroot**: Stores static assets such as CSS, JavaScript, and image files.

## Configuration in `Program.cs`
The `Program.cs` file has been configured to enable MVC services, serve static files, and define routing settings. Below is the implemented code:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Enable MVC services

var app = builder.Build();

app.UseStaticFiles(); // Serve static files from wwwroot

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();
```

## Explanation of Key Concepts

### **MVC Components**
- **Controller**: Handles incoming requests and interacts with the model if necessary.
- **Action**: A method inside a controller that processes incoming requests.
- **Model**: Represents data and business logic, typically interacting with a database.
- **View**: The user interface (UI) layer where `.cshtml` files are used to render HTML pages.

### **Razor & Razor View**
- **Razor**: A syntax that allows embedding C# code within HTML.
- **Razor View**: `.cshtml` files that integrate Razor and HTML to generate dynamic web pages.

### **Static Files & `wwwroot`**
- **`wwwroot`**: A folder that stores static files like CSS, JavaScript, and images.
- **`app.UseStaticFiles();`**: Middleware that enables serving static files from the `wwwroot` directory.

### **Application Lifecycle Methods**
- **`builder.Build()`**: Creates the application object and configures services.
- **`app.Run()`**: Starts the application and begins listening for HTTP requests. This is the final middleware in the pipeline and cannot be followed by other middleware.

## Running the Project
1. Open the project in Visual Studio.
2. Ensure the necessary directories (`Controllers`, `Models`, `Views`, `wwwroot`) exist.
3. Build and run the project (`Ctrl + F5` or `dotnet run`).
4. Navigate to `https://localhost:5001/` (or the assigned port) in your browser to access the application.

## Conclusion
This project provides a foundational setup for an ASP.NET Core MVC application, including essential components such as controllers, views, models, static file handling, and routing. It serves as a starting point for further development and customization.

