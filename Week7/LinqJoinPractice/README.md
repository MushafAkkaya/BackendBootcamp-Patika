# LinqJoinPractice

## Overview
This project demonstrates how to use LINQ join operations in C# to combine data from two lists: `Authors` and `Books`. It illustrates the power of LINQ's `join` clause for querying related data in a concise and readable manner.

## Technologies Used
- C#
- .NET
- LINQ (Language Integrated Query)

## Project Structure
The project consists of three main classes:
1. `Authors`: Represents an author with an `AuthorId` and `Name`.
2. `Books`: Represents a book with a `BookId`, `Title`, and `AuthorId` (which links it to an `Author`).
3. `Program`: Contains the `Main` method, which demonstrates the LINQ join operation.

## Code Explanation

```csharp
using LinqJoinPractice;

public class Program
{
    public static void Main()
    {
        List<Authors> authors = new List<Authors>()
        {
            new Authors{AuthorId = 1, Name = "Orhan Pamuk"},
            new Authors{AuthorId = 2, Name = "Elif Şafak"},
            new Authors{AuthorId = 3, Name = "Ahmet Ümit"}
        };

        List<Books> books = new List<Books>()
        {
            new Books{BookId = 1, Title = "Kar", AuthorId = 1},
            new Books{BookId = 2, Title = "İstanbul", AuthorId = 1},
            new Books{BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2},
            new Books{BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3},
        };

        var group = from author in authors
                    join book in books
                    on author.AuthorId equals book.AuthorId
                    select new
                    {
                        Title = book.Title,
                        Name = author.Name
                    };

        foreach (var item in group)
        {
            Console.WriteLine($"Book Title: {item.Title} / Author: {item.Name}");
        }
    }
}
```

## How It Works
1. **Data Creation**:
   - A list of authors (`authors`) and a list of books (`books`) are created.
   - Each book has an `AuthorId` that links it to an author.

2. **LINQ Join Operation**:
   - The `join` operation matches authors and books based on `AuthorId`.
   - The result is a new anonymous object containing the book title and author's name.

3. **Displaying the Result**:
   - The `foreach` loop iterates through the results and prints book titles with their respective authors.

## Expected Output
```
Book Title: Kar / Author: Orhan Pamuk
Book Title: İstanbul / Author: Orhan Pamuk
Book Title: 10 Minutes 38 Seconds in This Strange World / Author: Elif Şafak
Book Title: Beyoğlu Rapsodisi / Author: Ahmet Ümit
```

## Running the Project
To run the project, follow these steps:
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the application.
3. Observe the output in the console.

## Use Cases
- Combining related data from multiple collections.
- Data filtering and manipulation using LINQ.
- Understanding basic LINQ join operations in C#.

## Contributions
Feel free to fork this repository and add more LINQ join examples or improve the existing code.

## License
This project is open-source and free to use for educational purposes.

