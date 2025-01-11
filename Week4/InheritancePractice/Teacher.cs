using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Teacher : BasePerson
    {
        public int Salary { get; set; }

        public Teacher(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override void Person()
        {
            Console.WriteLine("Öğretmen adı, soyadı ve maaşı: " + Name + " " + Surname + " / " + Salary);
        }
    }
}
