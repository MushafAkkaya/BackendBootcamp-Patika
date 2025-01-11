Pratik - Inheritance
This project is created as part of the Backend Bootcamp on Patika.dev. It demonstrates the concept of inheritance in object-oriented programming (OOP) using C#. The example involves creating a base class (BaseKisi) and extending it to form specific classes for Ogrenci (Student) and Ogretmen (Teacher).

Project Requirements
1. BaseKisi Class
The BaseKisi class serves as the base class and includes:

Properties:
Ad (string): The first name of the person.
Soyad (string): The last name of the person.
Method:
A method to print the person's full name (Ad and Soyad) to the console.
2. Ogrenci Class
The Ogrenci class inherits from BaseKisi and includes:

Additional Property:
OgrenciNumarasi (string): The student's unique number.
Additional Method:
A method to print the student's number along with their full name to the console.
3. Ogretmen Class
The Ogretmen class also inherits from BaseKisi and includes:

Additional Property:
Maas (decimal): The teacher's salary information.
Additional Method:
A method to print the teacher's salary along with their full name to the console.
Key Concept:
Methods within a class can call other methods from the same or base class to reuse functionality.
4. Program.cs
In the Program class:

Examples of Ogrenci and Ogretmen objects are created.
Properties of these objects are assigned values.
Methods are used to print their details to the console.
How to Run
Clone the repository:

bash
Kodu kopyala
git clone https://github.com/MushafAkkaya/BackendBootcamp-Patika.git  
Navigate to the project directory:

bash
Kodu kopyala
cd BackendBootcamp-Patika/Week4/InheritancePractice  
Open the project in your preferred IDE.

Build and run the project to observe the output.

Example Output
Here’s an example of what the console output might look like when running the program:

text
Kodu kopyala
Ad: Ali  
Soyad: Yılmaz  
Ogrenci Numarası: 12345  

Ad: Ayşe  
Soyad: Demir  
Maaş: 5000  
Key Learning Objectives
This project helps to understand:

Inheritance: Sharing common properties and methods among related classes.
Encapsulation: Encapsulating data and methods in specific classes.
Code Reusability: Using base class functionality in derived classes.
Method Reuse: Calling one method from another to avoid redundancy.
