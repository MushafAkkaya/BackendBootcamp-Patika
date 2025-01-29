public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50));//Negatif ve pozitif random sayılar oluşturulup listeye atandı.
        }

        Console.WriteLine("Listedeki çift sayilar: ");

        var evenNumbers = numbers.Where(x => x % 2 == 0);

        foreach (var item in evenNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Listedeki tek sayilar: ");

        var oddNumbers = numbers.Where(x => x % 2 != 0);

        foreach (var item in oddNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Listedeki negatif sayilar: ");

        var negativeNumbers = numbers.Where(x => x < 0);

        foreach (var item in negativeNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Listedeki pozitif sayilar: ");

        var positiveNumbers = numbers.Where(x => x > 0);

        foreach (var item in positiveNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Listedeki 15 ve 22 arasındaki sayilar: ");

        var intervalNumbers = numbers.Where(x => x > 15 && x < 22);

        foreach (var item in intervalNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Listedeki her bir sayinin karesi: ");

        var squareNumbers = numbers.Select(x => x * x);

        foreach (var item in squareNumbers)
        {
            Console.WriteLine(item);
        }
    }
}