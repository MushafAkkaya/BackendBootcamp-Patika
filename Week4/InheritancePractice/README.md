# InheritancePractice

This project demonstrates the concept of inheritance in object-oriented programming. It includes a base class `BaseKisi` and two derived classes, `Ogrenci` (Student) and `Ogretmen` (Teacher).

## Classes and Properties

### BaseKisi (BasePerson)
- **Properties:**
  - `Ad` (Name)
  - `Soyad` (Surname)
- **Methods:**
  - A method that prints the name and surname to the console.

### Ogrenci (Student)
- **Inherits:** `BaseKisi`
- **Additional Properties:**
  - `OgrenciNumarasi` (Student Number)
- **Methods:**
  - A method that prints the student number, name, and surname to the console.

### Ogretmen (Teacher)
- **Inherits:** `BaseKisi`
- **Additional Properties:**
  - `MaasBilgisi` (Salary Information)
- **Methods:**
  - A method that prints the salary information, name, and surname to the console.

## Example Usage

The program creates instances of the `Ogrenci` and `Ogretmen` classes, assigns values to their properties, and calls their methods to display the data.


## How It Works
1. The `BaseKisi` class defines shared properties (`Ad` and `Soyad`) and a method (`Yazdir`) to print them.
2. The `Ogrenci` class extends `BaseKisi` by adding a `OgrenciNumarasi` property and a method (`OgrenciBilgisiYazdir`) that uses the base class method.
3. The `Ogretmen` class extends `BaseKisi` by adding a `MaasBilgisi` property and a method (`OgretmenBilgisiYazdir`) that also utilizes the base class method.
4. Instances of both `Ogrenci` and `Ogretmen` are created, and their properties are initialized with sample data.
5. Methods are called to display the details of the student and teacher.

