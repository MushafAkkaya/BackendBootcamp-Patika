using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTechShopProject
{
    class Bilgisayar : BaseMakine
    {
        private int _usbPortSayisi;
        public bool BluetoothVarMi { get; set; }

        public int UsbPortSayisi 
        { 
            get { return _usbPortSayisi; }
            set 
            {
                if (value == 2 || value == 4)
                {
                    _usbPortSayisi = value;
                }
                else
                {
                    _usbPortSayisi = -1;
                    Console.WriteLine("Usb portlarını 2 veya 4 tane olabilir!");//Kullanıcıdan belirli usb port sayıları alabilmek için encapsulation yapılır.
                }
            } 
        }

        public override void BilgileriYazdir()//Bilgisayar nesnesine göre metod ezilir.
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Usb Port Sayisi: {UsbPortSayisi}");
            if (BluetoothVarMi)
            {
                Console.WriteLine("Bluetooth: Var");
            }
            else
            {
                Console.WriteLine("Bluetooth: Yok");
            }
        }

        public override void UrunAdiGetir()//BaseClasstan alınan abstract metod ezilir ve isteğe göre şekillendirilir.
        {
            Console.WriteLine($"Bilgisayarinizin adi: {Ad}");
        }
    }
}
