
using DependencyInjectionPractice.Models;

Teacher teacher = new Teacher("Ali", "Veli");

Classroom classroom = new Classroom(teacher);

Console.WriteLine(classroom.GetTeacherInfo());