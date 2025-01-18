using Week5LastProject;

public class Program
{
    public static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();

        Console.WriteLine("Yeni bir araba üretmek istiyor musunuz?(e/h)");
        string cevap = Console.ReadLine().ToLower();

        while (!cevap.Contains("h"))
        {
            if (cevap.Contains("e"))
            {
                Araba araba = new Araba();

                Console.Write("Seri No: ");
                araba.SeriNo = Console.ReadLine();

                Console.Write("Marka: ");
                araba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                araba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                araba.Renk = Console.ReadLine();

                kapi:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    araba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Kapı sayısını geçersiz girdiniz. Lütfen sayısal bir değer giriniz.");
                    goto kapi;
                }

                arabalar.Add(araba);
                Console.WriteLine("Yeni araba üretildi!");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen 'e' veya 'h' giriniz.");
            }

            Console.WriteLine("Başka bir araba üretmek istiyor musunuz? (e/h)");
            cevap = Console.ReadLine().ToLower();
        }

        Console.WriteLine("\nÜretilen arabalar");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}");
        }

        Console.WriteLine("Program Tamamlandı.");
    }
}