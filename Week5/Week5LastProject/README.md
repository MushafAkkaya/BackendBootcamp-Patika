# Car Production Console Application

## Overview
This is a console-based C# application that simulates the process of creating and managing cars in a car factory. Users can produce multiple cars by entering relevant details and view the list of produced cars upon completion.

## Features
1. **Car Production Process**:
   - Users can decide whether to produce a new car or exit the program.
   - For each car, users input:
     - Serial Number (SeriNo)
     - Brand (Marka)
     - Model
     - Color (Renk)
     - Number of Doors (KapıSayisi)
   - The production date (`UretimTarihi`) is automatically set to the current date.

2. **Validation**:
   - Ensures that the number of doors is a valid integer.
   - Provides error messages for invalid inputs and prompts users to try again.

3. **List Management**:
   - All produced cars are stored in a list.
   - At the end of the program, the serial number and brand of each car are displayed.

## Usage
1. Run the program.
2. Respond to the prompt to decide whether to produce a new car (`e` for yes, `h` for no).
3. If yes, input the following details for each car:
   - Serial Number
   - Brand
   - Model
   - Color
   - Number of Doors
4. After completing each car, decide whether to create another.
5. Exit the program by responding with `h`.
6. View the list of all produced cars in the console.

## Code Structure
### Program Class
The `Program` class manages the main workflow:
- Handles user interactions to produce cars.
- Validates inputs.
- Manages the list of cars and displays the final summary.

### Araba Class
The `Araba` class defines the car object with the following properties:
- `UretimTarihi`: Automatically set to the current date during object creation.
- `SeriNo`: Serial number of the car.
- `Marka`: Brand of the car.
- `Model`: Model of the car.
- `Renk`: Color of the car.
- `KapiSayisi`: Number of doors.

## Example Output
```
Yeni bir araba üretmek istiyor musunuz?(e/h)
e
Seri No: 12345
Marka: Toyota
Model: Corolla
Renk: Beyaz
Kapı Sayısı: 4
Yeni araba üretildi!

Başka bir araba üretmek istiyor musunuz? (e/h)
h

Üretilen arabalar:
Marka: Toyota, Model: Corolla
Program Tamamlandı.
```

## Requirements
- .NET SDK

## Running the Program
1. Clone or download the project.
2. Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).
3. Build and run the program.

## Notes
- Input validation ensures a smooth user experience.
- The program uses a `while` loop to handle continuous user input and car production.
- `goto` is used to manage retries for invalid inputs.

## Future Enhancements
- Add a database to persist car data.
- Implement a graphical user interface (GUI).
- Add more properties like engine type, fuel consumption, etc.
