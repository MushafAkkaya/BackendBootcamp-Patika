using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorUsage
{
    public class Baby
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Baby() 
        {
            //Default ctor
        }

        public Baby(string name, string surname) // Ctor with 2 parameters
        {
            Name = name;
            Surname = surname;
        }

        public void NewBaby()
        {
            BirthDate = DateTime.Now; // When method call then set birth date right that moment.
            Console.WriteLine($"{Name} {Surname} isimli bebeğin doğum tarihi: {BirthDate}");
            Console.WriteLine("Ingaaa!");
        }
    }
}
