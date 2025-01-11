using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    public class Gorev : Calisan
    {
        public string CalisanPozisyon { get; set; }
        public Gorev(string ad, string soyad, string departman, string calisanPozisyon)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            CalisanPozisyon = calisanPozisyon;
        }

        public override void Pozisyon()
        {
            Console.WriteLine("Ben "+ Ad + " " + Soyad + ", " + Departman + " departmanında " + CalisanPozisyon + " pozisyonunda çalışıyorum.");
        }
    }
}
