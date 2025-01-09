# Patika Library

This project is a simple C# application created to record book information. It stores details such as book name, author name, page count, publisher, and registration date when creating book objects.

## Project Features

- **Book Object:** Includes book name, author name, author surname, page count, publisher, and registration date.
- **Registration Date:** Automatically assigned as the current date when a book object is created.
- **Constructor Alternatives:**
  1. **Parameterless Constructor:** Creates a default book object.
  2. **Parameterized Constructor:** Takes book name, author name, page count, and publisher information to create the object.

## Usage

### Creating and Saving Books

1. **Parameterless Constructor:**
```csharp
Library defaultLibrary = new Library();
defaultLibrary.BookName = "Ay'a Yolculuk";
defaultLibrary.AuthorName = "Jules";
defaultLibrary.AuthorSurname = "Verne";
defaultLibrary.PageNumber = 180;
defaultLibrary.Publisher = "Güneş";
defaultLibrary.SaveBook();
```

2. **Parameterized Constructor:**
```csharp
Library parametersLibrary = new Library("Hobbit", "Tolkien", 400, "İthaki");
parametersLibrary.SaveBook();
```

### Example Code
```csharp
using LibraryApp;

public class Program
{
    public static void Main(string[] args)
    {
        Library defaultLibrary = new Library();
        defaultLibrary.BookName = "Ay'a Yolculuk";
        defaultLibrary.AuthorName = "Jules";
        defaultLibrary.AuthorSurname = "Verne";
        defaultLibrary.PageNumber = 180;
        defaultLibrary.Publisher = "Güneş";

        Library parametersLibrary = new Library("Hobbit", "Tolkien", 400, "İthaki");

        defaultLibrary.SaveBook();
        parametersLibrary.SaveBook();
    }
}
```

### `SaveBook` Method Output
```plaintext
Jules Verne isimli yazarın 180 sayfalık Güneş yayınevi tarafından basılan Ay'a Yolculuk adındaki kitabı 09.01.2025 tarihinde sisteme kaydedilmiştir.
Tolkien  isimli yazarın 400 sayfalık İthaki yayınevi tarafından basılan Hobbit adındaki kitabı 09.01.2025 tarihinde sisteme kaydedilmiştir.
```

## Concepts

- **Class:** In object-oriented programming, a class is a blueprint used to create objects of a specific type. In this project, `Library` is a class.
- **Property:** Represents the characteristics of a class. For example, `BookName`, `AuthorName` are properties of the `Library` class.
- **New:** A keyword used to create a new instance of a class. For example, `Library defaultLibrary = new Library();`.
- **Constructor:** A special method that runs when an object of a class is created. This project includes both parameterless and parameterized constructors.

## Running the Project

1. Download the project files and open them in an IDE (such as Visual Studio).
2. Run the `Program.cs` file to test the project.

## Contribution

If you want to contribute to the project, please submit a pull request or open an issue.

## License

This project is licensed under the MIT License. For more information, see the [LICENSE](LICENSE) file.
