# Tech Store Management System

This C# project implements a simple tech store management system, allowing users to create records for Phones and Computers. The system demonstrates key object-oriented programming principles such as inheritance, encapsulation, abstraction, and polymorphism.

## Features

### Phone Class
- **Attributes:**
  - Production Date (automatically assigned upon object creation)
  - Serial Number
  - Name
  - Description
  - Operating System
  - Whether it has a TR license or not
- **Methods:**
  - Displays detailed information, including TR license status.
  - Outputs the phone's name with a custom message.

### Computer Class
- **Attributes:**
  - Production Date (automatically assigned upon object creation)
  - Serial Number
  - Name
  - Description
  - Operating System
  - USB Port Count (restricted to 2 or 4; invalid values result in a warning and default to -1)
  - Whether it has Bluetooth or not
- **Methods:**
  - Displays detailed information, including USB port count and Bluetooth status.
  - Outputs the computer's name with a custom message.

### Base Class: `BaseMakine`
- **Attributes:**
  - Production Date
  - Serial Number
  - Name
  - Description
  - Operating System
- **Methods:**
  - `BilgileriYazdir()`: Prints common attributes. Can be overridden to include class-specific details.
  - Abstract method `UrunAdiGetir()`, which is implemented in derived classes to provide customized product name messages.

## Program Flow
1. The user is prompted to choose whether to create a Phone or a Computer:
   - Input `1` for Phone.
   - Input `2` for Computer.
2. Based on the selection, the program collects product details from the user via the console.
3. Once all details are entered:
   - The program creates an instance of the selected class.
   - Displays a success message.
   - Prints the product details and its name using polymorphism.
4. The user is asked whether they want to create another product:
   - Input `yes` to restart the process.
   - Input `no` to exit the program with a farewell message.

## Object-Oriented Principles Used

### 1. Inheritance
The `Phone` and `Computer` classes inherit common attributes and methods from the `BaseMakine` class.

### 2. Encapsulation
- The `USB Port Count` attribute in the `Computer` class is validated to accept only specific values (2 or 4).
- Invalid values trigger a warning, and the default value of `-1` is assigned.

### 3. Abstraction
The `BaseMakine` class includes an abstract method `UrunAdiGetir()`, forcing derived classes to implement it with their unique functionality.

### 4. Polymorphism
The `BilgileriYazdir()` method is overridden in the `Phone` and `Computer` classes to include additional attributes.

## Usage Instructions
1. Compile and run the program using a C# compiler or an IDE such as Visual Studio.
2. Follow the on-screen prompts to create and view product records.

## Example Output
### Input:
```
1
Serial Number: 12345
Name: Galaxy S21
Description: A flagship smartphone
Operating System: Android
TR Licensed? (Yes/No): Yes
```
### Output:
```
Product successfully created!

Production Date: 1/13/2025
Serial Number: 12345
Name: Galaxy S21
Description: A flagship smartphone
Operating System: Android
TR Licensed: Yes

Your phone's name ---> Galaxy S21
```

## Requirements
- .NET Framework or .NET Core runtime
- Console-based application execution environment

## Future Enhancements
- Add support for more product types.
- Persist product records using a database or file system.
- Enhance the user interface with a graphical UI.

---

Feel free to contribute to or suggest improvements for this project!
