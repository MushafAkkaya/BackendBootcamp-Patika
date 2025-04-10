# 🔐 Identity and Data Protection API

A simple Web API built with **ASP.NET Core**, demonstrating **custom user identity**, **password encryption** using the **Data Protection API**, and **Entity Framework Core** with a **Code-First** approach.

---

## 📦 Features

- ✅ User registration with **model validation**
- 🔒 Password encryption using `IDataProtector`
- 🗄️ Entity Framework Core Code-First database generation
- 📡 RESTful API endpoint for user registration

---

## 🧱 Technologies Used

- ASP.NET Core Web API  
- Entity Framework Core  
- Data Protection API (`IDataProtector`)  
- Code-First Migration  
- SQL Server (or any EF-supported database)  
- Fluent validation attributes (`[Required]`, etc.)

---

## 📁 Project Structure

```
IdentityAndDataProtectionPractice/
│
├── Context/
│   └── IdentityDbContext.cs
│
├── Controllers/
│   └── AuthController.cs
│
├── Entities/
│   └── UserEntity.cs
│
├── Models/
│   └── UserRegisterRequest.cs
│
├── Program.cs
├── Startup.cs (or Program.cs with builder.Services...)
└── README.md
```

---

## 🧩 Database Design

### `UserEntity` Table

| Field     | Type     | Attributes            |
|-----------|----------|------------------------|
| `Id`      | int      | Primary Key, Identity  |
| `Email`   | string   | Required, Unique       |
| `Password`| string   | Required, Encrypted    |

```csharp
public class UserEntity
{
    public int Id { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
```

---

## 🧪 Model Validation

### `UserRegisterRequest.cs`

```csharp
public class UserRegisterRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }
}
```

---

## 🛡️ Password Encryption

Passwords are **not stored in plain text**. During registration, they are encrypted using the **Data Protection API**:

```csharp
_protector = provider.CreateProtector("UserPasswordProtector");

var userEntity = new UserEntity
{
    Email = request.Email,
    Password = _protector.Protect(request.Password)
};
```

---

## 📬 API Endpoint

### POST `/api/auth/register`

Registers a new user with encrypted password.

#### 🔸 Request Body

```json
{
  "email": "user@example.com",
  "password": "yourPassword123"
}
```

#### 🔹 Response

- `200 OK` on successful registration  
- `400 Bad Request` if validation fails

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/IdentityAndDataProtectionPractice.git
cd IdentityAndDataProtectionPractice
```

### 2. Configure your `appsettings.json`

Set up the connection string for your database:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=IdentityDb;Trusted_Connection=True;"
}
```

### 3. Add EF Core packages

If not already added:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 4. Run EF Core Migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5. Run the project

```bash
dotnet run
```

---

## 📌 Notes

- This example focuses on user registration only.
- No actual login/authentication is implemented (e.g., JWT tokens).
- For secure applications, hashing (e.g., BCrypt) is more common than encryption for passwords.
- The current implementation uses **symmetric encryption** for learning purposes.

---

## 📷 Demo Screenshot (optional)

> Add a screenshot of Postman or Swagger UI registering a user.

---

## 🧠 Future Improvements

- Implement login and token-based authentication
- Use hashing (`PasswordHasher`) instead of encryption for passwords
- Add email confirmation logic
- Implement user role management

---

## 📝 License

This project is licensed under the MIT License.

---

## 👨‍💻 Author

Built with ❤️ by [Your Name]
