# IMDB Film List Application

## Project Description
This project is a console application written in C# that allows users to create and manage a list of movies with their respective IMDb ratings. The program provides features to add movies, validate inputs, and display various filtered lists of movies based on user-defined criteria.

## Features
- **Add Movies**: Users can add movies with their names and IMDb scores.
- **Input Validation**: The program ensures:
  - IMDb scores are between 0 and 10.
  - Duplicate movie names are not allowed.
- **Continue or Stop**: After each addition, users can decide whether to add another movie or stop.
- **List Movies**:
  - Display all added movies.
  - Display movies with IMDb scores between 4 and 9.
  - Display movies that start with the letter 'A' (case-insensitive).

## Usage Instructions
1. Clone the repository or copy the source code.
2. Compile and run the program using a C# compiler or IDE.
3. Follow the prompts to:
   - Enter movie names and IMDb scores.
   - Decide whether to continue adding movies.
4. Upon exiting, the program will display the following lists:
   - All movies.
   - Movies with IMDb scores between 4 and 9.
   - Movies starting with the letter 'A'.

## Code Overview

### `Film` Class
The `Film` class represents a movie with two properties:
- `MovieName` (string): The name of the movie.
- `ImdbScore` (double): The IMDb score of the movie.

### `Program` Class
The `Program` class contains the main logic:
- A `List<Film>` is used to store the movies.
- A loop collects user input for movie names and IMDb scores.
- Input validations:
  - Duplicate movie names are rejected.
  - IMDb scores must be between 0 and 10.
- Displays filtered movie lists when the user chooses to stop adding movies.

## Sample Output
```
Film ismi giriniz: Avatar
Filmin imdb puanını giriniz: 8.5
Yeni bir film eklemek ister misiniz? (evet/hayır): evet
Film ismi giriniz: Titanic
Filmin imdb puanını giriniz: 9.1
Yeni bir film eklemek ister misiniz? (evet/hayır): hayır

Eklenen tüm filmler:
Avatar
Titanic

Imdb puanı 4 ile 9 arası olan filmler:
Avatar

İsmi 'A' ile başlayan filmler:
Avatar / 8.5
```

## Prerequisites
- .NET SDK (version 6.0 or later).
- A C# compiler or IDE (e.g., Visual Studio, Visual Studio Code).

## How to Run
1. Copy the project files to your local machine.
2. Open the project in your preferred C# IDE.
3. Build and run the program.

## Future Enhancements
- Add an option to edit or delete movies from the list.
- Implement sorting options for the movie list.
- Create a GUI version of the application.

## Acknowledgments
- Developed by [Mushaf Akkaya].
