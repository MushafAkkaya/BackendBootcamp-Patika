using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTechShopProject
{
    abstract class BaseMakine
    {   // Alt sınıfların ortak özellikleri tanımlanır.
        public string Ad { get; set; }
        public string SeriNo { get; set; }
        public DateTime UretimTarihi { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;//Nesne üretildiğinde tarih anlık olarak atanır.
        }

        public virtual void BilgileriYazdir()//Kullanıcının girdiği bilgileri yakalayıp çağırıldığında ekrana yazdıran metod
        {
            Console.WriteLine($"Ürün Bilgileri: \nAd: {Ad}\nSeri No: {SeriNo}" +
                $"\nUretim Tarihi: {UretimTarihi}" +
                $"\nAciklama: {Aciklama}\nIsletim Sistemi: {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();//Alt sınıflarda ezilebilir abstract metod
        
    }
}
