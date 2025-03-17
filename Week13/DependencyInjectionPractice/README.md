# Dependency Injection Example in C#

This project demonstrates the use of **Dependency Injection (DI)** in C#. It consists of two main classes, `Teacher` and `ClassRoom`, and an interface `ITeacher`. The `ClassRoom` class depends on the `Teacher` class, and this dependency is injected through the constructor (Constructor Injection).

## Table of Contents
1. [Project Structure](#project-structure)
2. [How It Works](#how-it-works)
3. [Code Explanation](#code-explanation)
4. [How to Run](#how-to-run)
5. [Benefits of Dependency Injection](#benefits-of-dependency-injection)

---

## Project Structure

The project consists of the following components:

1. **`ITeacher` Interface**: Defines the properties and methods that a `Teacher` class must implement.
2. **`Teacher` Class**: Implements the `ITeacher` interface and provides functionality to retrieve teacher information.
3. **`ClassRoom` Class**: Depends on the `ITeacher` interface. It uses the injected `Teacher` object to retrieve and display teacher information.
4. **`Program` Class**: The entry point of the application, where Dependency Injection is demonstrated.

---

## How It Works

1. The `Teacher` class implements the `ITeacher` interface and provides a method (`GetInfo`) to return the teacher's full name.
2. The `ClassRoom` class accepts an `ITeacher` object in its constructor (Constructor Injection). This allows the `ClassRoom` class to use the `Teacher` object without creating it directly.
3. In the `Program` class, a `Teacher` object is created and injected into the `ClassRoom` object. The `ClassRoom` object then retrieves and displays the teacher's information.

---

## Code Explanation

### 1. `ITeacher` Interface
```csharp
public interface ITeacher
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string GetInfo();
}
```
- This interface defines the properties (`FirstName` and `LastName`) and the `GetInfo` method that any `Teacher` class must implement.

### 2. `Teacher` Class
```csharp
public class Teacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"{FirstName} {LastName}";
    }
}
```
- The `Teacher` class implements the `ITeacher` interface.
- The `GetInfo` method returns the teacher's full name by combining `FirstName` and `LastName`.

### 3. `ClassRoom` Class
```csharp
public class ClassRoom
{
    private readonly ITeacher _teacher;

    public ClassRoom(ITeacher teacher)
    {
        _teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}
```
- The `ClassRoom` class depends on the `ITeacher` interface.
- The `Teacher` object is injected through the constructor (Constructor Injection).
- The `GetTeacherInfo` method calls the `GetInfo` method of the injected `Teacher` object.

### 4. `Program` Class
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Teacher class.
        ITeacher teacher = new Teacher("Ali", "Veli");

        // Inject the Teacher instance into the ClassRoom constructor.
        ClassRoom classRoom = new ClassRoom(teacher);

        // Display the teacher's information.
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}
```
- A `Teacher` object is created and injected into the `ClassRoom` object.
- The `GetTeacherInfo` method is called to retrieve and display the teacher's information.

---

## How to Run

1. Clone or download the project to your local machine.
2. Open the project in an IDE that supports C# (e.g., Visual Studio, JetBrains Rider, or Visual Studio Code).
3. Build and run the project.
4. The output will display the teacher's full name: `Ahmet Yılmaz`.

---

## Benefits of Dependency Injection

1. **Loose Coupling**: The `ClassRoom` class does not directly depend on the `Teacher` class. Instead, it depends on the `ITeacher` interface, making the code more flexible and maintainable.
2. **Testability**: Dependency Injection makes it easier to unit test the `ClassRoom` class by allowing mock implementations of the `ITeacher` interface.
3. **Reusability**: The `Teacher` class can be reused in other parts of the application without modification.
4. **Scalability**: New implementations of the `ITeacher` interface can be added without changing the existing code.

---

## License

This project is open-source and available under the MIT License. Feel free to use, modify, and distribute it as needed.

---

This `README.md` file provides a comprehensive overview of the project and its implementation. You can customize it further to suit your needs!
