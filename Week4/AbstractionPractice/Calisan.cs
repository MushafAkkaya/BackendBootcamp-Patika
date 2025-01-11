using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public abstract void Pozisyon();
    }
}
