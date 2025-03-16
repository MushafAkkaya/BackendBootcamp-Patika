---

# Survivor Web API

This is a .NET Core Web API project designed to manage competitors and categories for a hypothetical "Survivor" competition. The API provides endpoints to perform CRUD operations on competitors and categories, and it uses Entity Framework Core for database interactions.

## Table of Contents

1. [Project Overview](#project-overview)
2. [Technologies Used](#technologies-used)
3. [Database Context](#database-context)
4. [Controllers](#controllers)
   - [CategoriesController](#categoriescontroller)
   - [CompetitorsController](#competitorscontroller)
5. [Setup and Installation](#setup-and-installation)
6. [API Endpoints](#api-endpoints)
7. [Sample Requests](#sample-requests)

---

## Project Overview

The Survivor Web API is a RESTful service that allows you to:
- Manage categories (e.g., "Ünlüler" and "Gönüllüler").
- Manage competitors (e.g., "Acun Ilıcalı", "Aleyna Avcı").
- Associate competitors with specific categories.
- Perform CRUD (Create, Read, Update, Delete) operations on both categories and competitors.

The project uses Entity Framework Core for database interactions and follows a clean, modular structure.

---

## Technologies Used

- **.NET Core**: The framework used to build the API.
- **Entity Framework Core**: ORM for database interactions.
- **SQL Server**: Database to store categories and competitors.
- **Swagger**: API documentation and testing (optional).

---

## Database Context

The `SurvivorDbContext` class is the bridge between the application and the database. It defines the database schema and relationships using Entity Framework Core.

### Key Features:
- **Entities**:
  - `CategoryEntity`: Represents a category (e.g., "Ünlüler").
  - `CompetitorsEntity`: Represents a competitor (e.g., "Acun Ilıcalı").
- **Relationships**:
  - One-to-Many: A category can have many competitors.
- **Seed Data**:
  - Predefined categories and competitors are seeded into the database when it is created.

### Code Example:
```csharp
public class SurvivorDbContext : DbContext
{
    public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

    public DbSet<CompetitorsEntity> Competitors => Set<CompetitorsEntity>();
    public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // One-to-Many Relationship
        modelBuilder.Entity<CategoryEntity>()
            .HasMany(c => c.Competitors)
            .WithOne(c => c.Category)
            .HasForeignKey(c => c.CategoryId);

        // Seed Data for Categories
        modelBuilder.Entity<CategoryEntity>().HasData(
            new CategoryEntity { Id = 1, Name = "Ünlüler", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false },
            new CategoryEntity { Id = 2, Name = "Gönüllüler", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false }
        );

        // Seed Data for Competitors
        modelBuilder.Entity<CompetitorsEntity>().HasData(
            new CompetitorsEntity { Id = 1, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false },
            new CompetitorsEntity { Id = 2, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false }
        );

        base.OnModelCreating(modelBuilder);
    }
}
```

---

## Controllers

### CategoriesController

The `CategoriesController` handles CRUD operations for categories.

#### Endpoints:
- **GET `/api/categories`**: Retrieve all categories.
- **GET `/api/categories/{id}`**: Retrieve a category by ID.
- **POST `/api/categories`**: Add a new category.
- **PUT `/api/categories/{id}`**: Update an existing category.
- **DELETE `/api/categories/{id}`**: Soft delete a category (sets `IsDeleted` to `true`).

#### Code Example:
```csharp
[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly SurvivorDbContext _db;

    public CategoriesController(SurvivorDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var categories = _db.Categories.Where(x => !x.IsDeleted).OrderBy(x => x.Name).ToList();
        return Ok(categories);
    }

    [HttpPost]
    public IActionResult Add(CategoryAddRequest request)
    {
        var category = new CategoryEntity { Name = request.Name, ModifiedDate = DateTime.Now };
        _db.Categories.Add(category);
        _db.SaveChanges();
        return Created();
    }
}
```

---

### CompetitorsController

The `CompetitorsController` handles CRUD operations for competitors.

#### Endpoints:
- **GET `/api/competitors`**: Retrieve all competitors.
- **GET `/api/competitors/{id}`**: Retrieve a competitor by ID.
- **GET `/api/competitors/categories/{categoryId}`**: Retrieve competitors by category ID.
- **POST `/api/competitors`**: Add a new competitor.
- **PUT `/api/competitors/{id}`**: Update an existing competitor.
- **DELETE `/api/competitors/{id}`**: Soft delete a competitor (sets `IsDeleted` to `true`).

#### Code Example:
```csharp
[ApiController]
[Route("api/[controller]")]
public class CompetitorsController : ControllerBase
{
    private readonly SurvivorDbContext _db;

    public CompetitorsController(SurvivorDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var competitors = _db.Competitors.Where(x => !x.IsDeleted).OrderBy(x => x.FirstName).ToList();
        return Ok(competitors);
    }

    [HttpPost]
    public IActionResult Add(CompetitorAddRequest request)
    {
        var competitor = new CompetitorsEntity { FirstName = request.FirstName, LastName = request.LastName, ModifiedDate = DateTime.Now };
        _db.Competitors.Add(competitor);
        _db.SaveChanges();
        return Created();
    }
}
```

---

## Setup and Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-repo/survivor-web-api.git
   cd survivor-web-api
   ```

2. **Configure the Database**:
   - Update the `appsettings.json` file with your SQL Server connection string.
   - Run migrations to create the database:
     ```bash
     dotnet ef database update
     ```

3. **Run the Application**:
   ```bash
   dotnet run
   ```

4. **Access the API**:
   - The API will be available at `http://localhost:5000` (or `https://localhost:5001` for HTTPS).

---

## API Endpoints

### Categories
- `GET /api/categories`
- `GET /api/categories/{id}`
- `POST /api/categories`
- `PUT /api/categories/{id}`
- `DELETE /api/categories/{id}`

### Competitors
- `GET /api/competitors`
- `GET /api/competitors/{id}`
- `GET /api/competitors/categories/{categoryId}`
- `POST /api/competitors`
- `PUT /api/competitors/{id}`
- `DELETE /api/competitors/{id}`

---

## Sample Requests

### Add a New Category
**Request**:
```http
POST /api/categories
Content-Type: application/json

{
  "name": "Yeni Kategori"
}
```

### Retrieve Competitors by Category ID
**Request**:
```http
GET /api/competitors/categories/1
```

---
