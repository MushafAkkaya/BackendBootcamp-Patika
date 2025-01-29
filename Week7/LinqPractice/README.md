# LINQ Practice

## Description
This project demonstrates basic LINQ operations on a randomly generated list of 10 integers. The numbers range from -50 to 50, and various LINQ queries are applied to filter and transform the data.

## Features
The program performs the following operations using LINQ:
- Filters even numbers
- Filters odd numbers
- Filters negative numbers
- Filters positive numbers
- Filters numbers between 15 and 22 (exclusive)
- Computes the square of each number

## Technologies Used
- C#
- .NET Core
- LINQ

## Usage
1. Clone or download the repository.
2. Open the project in an IDE that supports C# (e.g., Visual Studio, Rider, or VS Code with C# extension).
3. Run the program.
4. The results will be displayed in the console.

## Code Example
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50));
        }

        Console.WriteLine("Even numbers:");
        numbers.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Odd numbers:");
        numbers.Where(x => x % 2 != 0).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Negative numbers:");
        numbers.Where(x => x < 0).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Positive numbers:");
        numbers.Where(x => x > 0).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Numbers between 15 and 22:");
        numbers.Where(x => x > 15 && x < 22).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("Squares of the numbers:");
        numbers.Select(x => x * x).ToList().ForEach(Console.WriteLine);
    }
}
```
