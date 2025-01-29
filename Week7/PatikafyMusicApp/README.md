# PatikafyMusicApp

## Overview
PatikafyMusicApp is a simple C# console application that processes a list of singers and performs various queries using LINQ. The application defines a `Singer` class, creates a list of singers, and executes different queries to extract meaningful insights.

## Features
- Filters singers whose names start with 'S'.
- Retrieves singers with album sales over 10 million.
- Finds pop singers who debuted before the year 2000 and sorts them alphabetically.
- Identifies the highest-selling singer.
- Finds the most recent and the oldest debuting singer.

## Data Structure
The application defines a `Singer` class with the following properties:

```csharp
namespace PatikafyMusicApp
{
    internal class Singer
    {
        public string Name { get; set; }
        public string MusicType { get; set; }
        public int ReleaseDate { get; set; }
        public int AlbumSales { get; set; }
    }
}
```

## Implementation
### Creating the List of Singers
A list of `Singer` objects is initialized with predefined values.

```csharp
List<Singer> singers = new List<Singer>()
{
    new Singer{Name = "Ajda Pekkan", MusicType = "Pop", ReleaseDate = 1968, AlbumSales = 20000000},
    new Singer{Name = "Sezen Aksu", MusicType = "Türk Halk Müziği / Pop", ReleaseDate = 1971, AlbumSales = 10000000},
    new Singer{Name = "Funda Arar", MusicType = "Pop", ReleaseDate = 1999, AlbumSales = 3000000},
    new Singer{Name = "Sertab Erener", MusicType = "Pop", ReleaseDate = 1994, AlbumSales = 5000000},
    new Singer{Name = "Sıla", MusicType = "Pop", ReleaseDate = 2009, AlbumSales = 3000000},
    new Singer{Name = "Serdar Ortaç", MusicType = "Pop", ReleaseDate = 1994, AlbumSales = 10000000},
    new Singer{Name = "Tarkan", MusicType = "Pop", ReleaseDate = 1992, AlbumSales = 40000000},
    new Singer{Name = "Hande Yener", MusicType = "Pop", ReleaseDate = 1999, AlbumSales = 7000000},
    new Singer{Name = "Hadise", MusicType = "Pop", ReleaseDate = 2005, AlbumSales = 5000000},
    new Singer{Name = "Gülben Ergen", MusicType = "Pop / Türk Halk Müziği", ReleaseDate = 1997, AlbumSales = 10000000},
    new Singer{Name = "Neşet Ertaş", MusicType = "Türk Halk Müziği / Türk Sanat Müziği", ReleaseDate = 1960, AlbumSales = 2000000},
};
```

## LINQ Queries
### 1. Find Singers Whose Names Start with 'S'
```csharp
var startWithS = singers.Where(x => x.Name.StartsWith("S"));
```

### 2. Find Singers with Album Sales Over 10 Million
```csharp
var highSales = singers.Where(x => x.AlbumSales >= 10000000);
```

### 3. Find Pop Singers Who Debuted Before 2000 (Sorted Alphabetically)
```csharp
var oldPopSingers = singers.Where(x => x.ReleaseDate < 2000 && x.MusicType.Contains("Pop"))
                            .OrderBy(x => x.ReleaseDate)
                            .ThenBy(x => x.Name);
```

### 4. Find the Highest-Selling Singer
```csharp
var topSinger = singers.OrderByDescending(x => x.AlbumSales).FirstOrDefault();
```

### 5. Find the Most Recent and Oldest Debuting Singer
```csharp
var newestSinger = singers.OrderByDescending(x => x.ReleaseDate).FirstOrDefault();
var oldestSinger = singers.OrderBy(x => x.ReleaseDate).FirstOrDefault();
```

## Output
The results of the queries are printed to the console. Example output:

```
Singers whose names start with 'S':
Sertab Erener
Sıla
Serdar Ortaç

Singers with album sales over 10 million:
Ajda Pekkan - 20000000
Sezen Aksu - 10000000
Serdar Ortaç - 10000000
Tarkan - 40000000
Gülben Ergen - 10000000

Pop singers who debuted before 2000:
Ajda Pekkan
Funda Arar
Hande Yener
Sertab Erener
Serdar Ortaç
Tarkan

Highest-selling singer:
Tarkan

Most recent debuting singer:
Sıla

Oldest debuting singer:
Neşet Ertaş
```

## Conclusion
This project demonstrates how to use LINQ queries to filter, sort, and extract specific data from a list of objects. The application effectively showcases fundamental LINQ operations in C# with a real-world example.

## Requirements
- .NET SDK
- C# Compiler

## How to Run
1. Clone or download the project.
2. Open a terminal and navigate to the project folder.
3. Run the following command:
   ```sh
   dotnet run
   ```
