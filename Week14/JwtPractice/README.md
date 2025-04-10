# 🔐 JWT Authentication API

A secure Web API project built with **ASP.NET Core**, demonstrating **JWT-based authentication** using **Entity Framework Core**, user credential validation, and route protection using `[Authorize]`.

---

## 📦 Features

- ✅ User login with credential validation
- 🔐 JWT token generation on successful login
- 🧾 Protected API routes using `[Authorize]`
- 🗄️ Entity Framework Core Code-First database generation

---

## 🧱 Technologies Used

- ASP.NET Core Web API  
- Entity Framework Core  
- JWT Bearer Authentication  
- Code-First Migration  
- SQL Server (or any EF-supported database)  
- Claim-based Identity  

---

## 📁 Project Structure

```
JwtAuthenticationApi/
│
├── Context/
│   └── JwtDbContext.cs
│
├── Controllers/
│   └── AuthController.cs
│
├── Helpers/
│   └── JwtHelper.cs
│
├── Entities/
│   └── User.cs
│
├── Models/
│   └── LoginRequestDto.cs
│
├── Program.cs
└── README.md
```

---

## 🧩 Database Design

### `User` Table

| Field     | Type     | Attributes            |
|-----------|----------|------------------------|
| `Id`      | int      | Primary Key, Identity  |
| `Email`   | string   | Required, Unique       |
| `Password`| string   | Required               |

```csharp
public class User
{
    public int Id { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
```

---

## 🧪 Login Model

### `LoginRequestDto.cs`

```csharp
public class LoginRequestDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
```

---

## 🔐 JWT Generation

### `JwtHelper.cs` Example

```csharp
public class JwtHelper
{
    private readonly IConfiguration _configuration;

    public JwtHelper(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(User user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
```

---

## 📬 API Endpoints

### POST `/api/auth/login`

Authenticates a user and returns a JWT token.

#### 🔸 Request Body

```json
{
  "email": "user@example.com",
  "password": "yourPassword123"
}
```

#### 🔹 Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

---

### GET `/api/auth`

Returns the email from the token **(requires authentication)**.

#### Header

```http
Authorization: Bearer <your_jwt_token>
```

#### Response

```json
{
  "email": "user@example.com"
}
```

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/JwtAuthenticationApi.git
cd JwtAuthenticationApi
```

### 2. Configure `appsettings.json`

```json
"Jwt": {
  "Key": "super_secret_key_here_123!",
  "Issuer": "yourdomain.com",
  "Audience": "yourdomain.com"
},
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=JwtDb;Trusted_Connection=True;"
}
```

### 3. Add EF Core and JWT Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
```

### 4. Run Migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5. Run the Project

```bash
dotnet run
```

---

## 🧪 Testing the API

You can use **Postman** or **Swagger UI** to test:

1. Send POST `/api/auth/login` → receive JWT token  
2. Use the token in `Authorization: Bearer <token>` header  
3. Send GET `/api/auth` to test protected route

---

## 📌 Notes

- Passwords are stored in plain text in this example (not secure). Use `PasswordHasher` or BCrypt for production.
- JWT tokens are short-lived (1 hour). You can change the expiration as needed.
- Email field must be unique in the database.

---

## 🧠 Future Enhancements

- Use hashed passwords for secure storage
- Add refresh token mechanism
- Add registration endpoint
- Add user roles and role-based authorization

---

## 📝 License

This project is licensed under the MIT License.

---
