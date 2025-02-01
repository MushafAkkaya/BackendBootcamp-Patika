# Linq Group Join Practice

## Overview
This project demonstrates how to use LINQ group join operations in C# to combine data from two tables: `Students` and `Classes`. It showcases how to group students under their respective classes using LINQ.

## Technologies Used
- C#
- .NET
- LINQ (Language Integrated Query)

## Project Structure
The project consists of three main classes:
1. `Students`: Represents a student with a `StudentId`, `StudentName`, and `ClassId`.
2. `Classes`: Represents a class with a `ClassId` and `ClassName`.
3. `Program`: Contains the `Main` method, which demonstrates the LINQ group join operation.

## Code Explanation

```csharp
using LinqGroupJoinPractice;

public class Program
{
    public static void Main()
    {
        List<Students> students = new List<Students>()
        {
            new Students{StudentId = 1, StudentName = "Ali", ClassId = 1},
            new Students{StudentId = 2, StudentName = "Ayşe", ClassId = 2},
            new Students{StudentId = 3, StudentName = "Mehmet", ClassId = 1},
            new Students{StudentId = 4, StudentName = "Fatma", ClassId = 3},
            new Students{StudentId = 5, StudentName = "Ahmet", ClassId = 2}
        };

        List<Classes> classes = new List<Classes>()
        {
            new Classes{ClassId = 1, ClassName = "Matematik"},
            new Classes{ClassId = 2, ClassName = "Türkçe"},
            new Classes{ClassId = 3, ClassName = "Kimya"}
        };

        var groupJoin = classes.GroupJoin(
            students,
            c => c.ClassId,
            s => s.ClassId,
            (c, sGroup) => new
            {
                Class = c,
                Student = sGroup.ToList(),
            }
        );

        foreach (var item in groupJoin)
        {
            Console.WriteLine($"{item.Class.ClassName}");
            foreach (var student in item.Student)
            {
                Console.WriteLine($"{student.StudentName}");
            }
        }
    }
}
```

## How It Works
1. **Data Creation**:
   - A list of students (`students`) and a list of classes (`classes`) are created.
   - Each student has a `ClassId` that links them to a class.

2. **LINQ Group Join Operation**:
   - The `GroupJoin` operation groups students under their respective classes using `ClassId`.
   - The result is a new anonymous object containing the class and its associated students.

3. **Displaying the Result**:
   - The `foreach` loop iterates through the grouped results and prints class names followed by the student names belonging to that class.

## Expected Output
```
Matematik
Ali
Mehmet
Türkçe
Ayşe
Ahmet
Kimya
Fatma
```

## Running the Project
To run the project, follow these steps:
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the application.
3. Observe the output in the console.

## Use Cases
- Grouping related data using LINQ.
- Understanding basic LINQ group join operations in C#.
- Displaying hierarchical relationships between entities.

## Contributions
Feel free to fork this repository and add more LINQ group join examples or improve the existing code.

## License
This project is open-source and free to use for educational purposes.

