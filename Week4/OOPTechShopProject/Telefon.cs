using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTechShopProject
{
    class Telefon : BaseMakine
    {
        public bool Lisans { get; set; }

        public override void BilgileriYazdir()//Telefon nesnesine göre metod ezilir.
        {
            base.BilgileriYazdir();
            if (Lisans)
            {
                Console.WriteLine($"Lisans Durumu: Devam ediyor.");
            }
            else
            {
                Console.WriteLine($"Lisans Durumu: Mevcut değil.");
            }
        }

        public override void UrunAdiGetir()//BaseClasstan gelen abstract metod ezilir.
        {
            Console.WriteLine($"Telefonunuzun adi: {Ad}");
        }
    }
}
