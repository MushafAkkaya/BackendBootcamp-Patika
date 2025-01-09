using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass
{
    public class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int OkulNo { get; set; }
        public string Brans { get; set; }

        public void Student()
        {
            Console.WriteLine($"{Ad} {Soyad} isimli {OkulNo} numaralı öğrencinin doğum tarihi {DogumTarihi} şeklindedir.");
        }

        public void Teacher()
        {
            Console.WriteLine($"{Ad} {Soyad} isimli, branşı {Brans} olan öğretmenin doğum tarihi {DogumTarihi} şeklindedir.");
        }
    }
}
