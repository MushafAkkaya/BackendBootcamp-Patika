using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice
{
    public class Araba
    {
        private string _marka;
        private int _model;
        private string _renk;
        private int _kapiSayisi;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }
        public int Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set 
            {
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    _kapiSayisi = -1;
                    Console.WriteLine("Kapı sayısı 2 veya 4'den farklı olamaz!");
                }
            }
        }

        public void ArabaBilgileri() 
        {
            Console.WriteLine(Marka + " marka ve " + Model + " model arabanın rengi " + Renk + ", kapı sayısı " + KapiSayisi);
        }
    }
}
