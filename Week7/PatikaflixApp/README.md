# Patikaflix Series Platform

## Description
This project is a console-based application that allows users to create and manage a list of TV series. Users can input details of each series, including the name, release date, type, director, and platform. Additionally, the application extracts comedy series from the main list and displays them in a sorted manner.

## Features
- Users can add multiple TV series via console input.
- The application stores series data in a list.
- Users can stop adding series at any time.
- A filtered list of comedy series is created with only the essential details (Name, Type, and Director).
- The comedy series list is sorted alphabetically by name, then by director.
- The final lists are displayed in the console.

## Technologies Used
- **C#**
- **.NET Core**
- **LINQ** for filtering and sorting

## Usage
### Running the Program
1. Compile and run the program in a C# environment (such as Visual Studio or .NET CLI).
2. Enter details for each TV series when prompted.
3. Type 'h' to stop adding new series.
4. View the complete list of series entered.
5. View the sorted list of comedy series.

### Example Input/Output
#### User Input:
```
Dizinin adını girin: Friends
Dizinin yapım yılını girin: 1994
Dizinin türünü girin: Komedi
Dizinin yönetmenini girin: David Crane
Dizinin yayınlandığı ilk platformu girin: NBC

Yeni dizi eklemek istiyor musunuz?(e/h): e

Dizinin adını girin: Breaking Bad
Dizinin yapım yılını girin: 2008
Dizinin türünü girin: Drama
Dizinin yönetmenini girin: Vince Gilligan
Dizinin yayınlandığı ilk platformu girin: AMC

Yeni dizi eklemek istiyor musunuz?(e/h): h
```

#### Console Output:
```
Eklenen diziler:
Dizi adı: Friends / Yılı: 1994 / Türü: Komedi / Yönetmeni: David Crane / Platform: NBC
Dizi adı: Breaking Bad / Yılı: 2008 / Türü: Drama / Yönetmeni: Vince Gilligan / Platform: AMC

Komedi dizileri:
Adı: Friends / Türü: Komedi / Yönetmen: David Crane
```

## Code Structure
### `Series` Class
Defines the main TV series structure:
```csharp
internal class Series
{
    public string Name { get; set; }
    public int ReleaseDate { get; set; }
    public string Type { get; set; }
    public string Director { get; set; }
    public string Platform { get; set; }
}
```

### `NewSeries` Class
Defines a simplified structure for comedy series:
```csharp
internal class NewSeries
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Director { get; set; }
}
```

### Main Logic
- The program continuously asks for series input until the user decides to stop.
- Comedy series are filtered and extracted into a new list.
- The extracted list is sorted by series name and then by director.
- The lists are displayed on the console.
