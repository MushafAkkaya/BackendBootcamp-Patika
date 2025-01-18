class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir sayı giriniz:");

        try
        {
            // Kullanıcıdan giriş alıyoruz
            string input = Console.ReadLine();

            // Girişi integer'a çeviriyoruz
            int number = int.Parse(input);

            // Sayının karesini hesaplayıp ekrana yazdırıyoruz
            int square = number * number;
            Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
        }
        catch (FormatException)
        {
            // Hatalı giriş yapılırsa bu mesaj gösterilir
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}