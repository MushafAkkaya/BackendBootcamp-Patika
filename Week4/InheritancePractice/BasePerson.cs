using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public abstract class BasePerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void Person()
        {
            Console.WriteLine(Name + Surname);
        }
    }
}
