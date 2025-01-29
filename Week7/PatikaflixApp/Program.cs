using PatikaflixApp;

public class Program
{
    public static void Main()
    {
        List<Series> series = new List<Series>();

        while (true)
        {
            Series newSeries = new Series();

            Console.Write("Dizinin adını girin: ");
            newSeries.Name = Console.ReadLine();

            Console.Write("Dizinin yapım yılını girin: ");
            newSeries.ReleaseDate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dizinin türünü girin: ");
            newSeries.Type = Console.ReadLine();

            Console.Write("Dizinin yönetmenini girin: ");
            newSeries.Director = Console.ReadLine();

            Console.Write("Dizinin yayınlandığı ilk platformu girin: ");
            newSeries.Platform = Console.ReadLine();

            series.Add(newSeries);

            Console.WriteLine("Yeni dizi eklemek istiyor musunuz?(e/h)");
            string answer = Console.ReadLine();

            if (answer.Contains("h"))
            {
                break;
            }
        }

        Console.WriteLine("Eklenen diziler:");
        foreach (var item in series)
        {
            Console.WriteLine($"Dizi adı: {item.Name} / Yılı: {item.ReleaseDate} / Türü: {item.Type} / Yönetmeni: {item.Director} / Platform: {item.Platform}");
        }

        List<NewSeries> comedySeries = series
            .Where(x => x.Type.Equals("Komedi", StringComparison.OrdinalIgnoreCase))
            .Select(x => new NewSeries { Name = x.Name, Type = x.Type, Director = x.Director })
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Director)
            .ToList(); // Komedi dizileri için yeni bir liste oluşturuldu ve kullanıcıdan alınan verilerle oluşturulmuş olan dizi listesinden istenilen sütunlar alındı.

        Console.WriteLine("Komedi dizileri: ");
        foreach (var item in comedySeries)
        {
            Console.WriteLine($"Adı: {item.Name} / Türü: {item.Type} / Yönetmen: {item.Director}");
        }
    }
}