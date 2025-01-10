# Encapsulation Practice in C#

This project demonstrates the concept of encapsulation in C# through a simple `Car` (Araba) class. The program utilizes properties to control and validate access to class fields, ensuring better code integrity and maintainability.

## Project Structure

- **Program.cs**: Contains the `Main` method that serves as the entry point of the program.
- **Araba.cs**: Defines the `Araba` class, which includes properties and a method for displaying car details.

## Features

1. **Encapsulation**:  
   The `Araba` class demonstrates encapsulation by using private fields and public properties to control access and enforce rules (e.g., valid door numbers).
   
2. **Validation**:  
   The `KapiSayisi` property only accepts valid values (2 or 4). If an invalid value is provided, a default value of `-1` is set, and an error message is displayed.

3. **Data Display**:  
   The `ArabaBilgileri` method displays the details of the car, including its make, model, color, and the number of doors.

## Usage

To run the program:
1. Clone or download the project.
2. Compile and run it in a C#-supported IDE or use the command line.

### Example Output
Running the program with the given code produces the following output:

Renault marka ve 2004 model arabanın rengi Bej, kapı sayısı 4


## Code Overview

### Program.cs
The `Program` class creates an instance of the `Araba` class, assigns values to its properties, and invokes the `ArabaBilgileri` method.

### Araba.cs
The `Araba` class includes:
- **Fields**: Private variables for car attributes (`_marka`, `_model`, `_renk`, `_kapiSayisi`).
- **Properties**: Public accessors for controlling and validating the fields.
- **Methods**: A method (`ArabaBilgileri`) to display car information.

## Learning Objectives

- Understand and implement encapsulation in C#.
- Learn to validate property values in a controlled manner.
- Gain hands-on experience with class design and basic OOP principles.

## Requirements

- .NET SDK
- C# 7.0 or later
