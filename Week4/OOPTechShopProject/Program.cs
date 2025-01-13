using OOPTechShopProject;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Teknoloji mağazasına hoşgeldiniz.");
            Console.WriteLine("Telefon kaydi oluşturmak için 1'e, Bilgisayar kaydi oluşturmak için 2'ye basiniz.");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)//Telefon için nesne üretilir ve bilgiler kullanıcıdan alınır.
            {
                Telefon telefon = new Telefon();

                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Seri No: ");
                telefon.SeriNo = Console.ReadLine();

                Console.Write("Aciklama: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İsletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisanslı mı? (true/false): ");
                telefon.Lisans = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("\nÜrün başarıyla üretildi");

                telefon.BilgileriYazdir();//BaseMakina sınıfından 2 metod çağrılarak bilgiler gösterilir.
                telefon.UrunAdiGetir();
            }
            else if (secim == 2)//Bilgisayar için nesne üretilir ve bilgiler kullanıcıdan alınır.
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Seri No: ");
                bilgisayar.SeriNo = Console.ReadLine();

                Console.Write("Aciklama: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İsletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("Usb Port Sayisi: ");
                bilgisayar.UsbPortSayisi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bluetooth var mi? (true/false): ");
                bilgisayar.BluetoothVarMi = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("\nÜrün başarıyla üretildi");

                bilgisayar.BilgileriYazdir();//BaseMakina sınıfından 2 metod çağrılarak bilgiler gösterilir.
                bilgisayar.UrunAdiGetir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim yaptınız. Lütfen tekrar deneyin.");
                continue;
            }

            Console.WriteLine("Yeni bir ürün üretmek ister misiniz? (evet/hayır)");
            string devamDurumu = Console.ReadLine().ToLower();
            if (devamDurumu != "evet")
            {
                Console.WriteLine("İyi günler dileriz.");
                break;
            }
        }
    }
}