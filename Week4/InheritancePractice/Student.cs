using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Student : BasePerson
    {
        public int StudentNumber { get; set; }

        public Student(string name, string surname, int studentNumber)
        {
            Name = name;
            Surname = surname;
            StudentNumber = studentNumber;
        }

        public override void Person()
        {
            Console.WriteLine("Öğrenci adı, soyadı ve okul numarası: " + Name + " " + Surname + " / " + StudentNumber);
        }
    }
}
