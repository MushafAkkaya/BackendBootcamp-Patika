using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5LastProject
{
    internal class Araba
    {
        public DateTime UretimTarihi { get; set; }
        public string SeriNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }
    }
}
