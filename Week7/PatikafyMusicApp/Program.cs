using PatikafyMusicApp;

public class Program
{
    public static void Main()
    {
        List<Singer> singers = new List<Singer>()
        {
            new Singer{Name = "Ajda Pekkan", MusicType = "Pop", ReleaseDate = 1968, AlbumSales = 20000000},
            new Singer{Name = "Sezen Aksu", MusicType = "Türk Halk Müziği / Pop", ReleaseDate = 1971, AlbumSales = 10000000},
            new Singer{Name = "Funda Arar", MusicType = "Pop", ReleaseDate = 1999, AlbumSales = 3000000},
            new Singer{Name = "Sertab Erener", MusicType = "Pop", ReleaseDate = 1994, AlbumSales = 5000000},
            new Singer{Name = "Sıla", MusicType = "Pop", ReleaseDate = 2009, AlbumSales = 3000000},
            new Singer{Name = "Serdar Ortaç", MusicType = "Pop", ReleaseDate = 1994, AlbumSales = 10000000},
            new Singer{Name = "Tarkan", MusicType = "Pop", ReleaseDate = 1992, AlbumSales = 40000000},
            new Singer{Name = "Hande Yener", MusicType = "Pop", ReleaseDate = 1999, AlbumSales = 7000000},
            new Singer{Name = "Hadise", MusicType = "Pop", ReleaseDate = 2005, AlbumSales = 5000000},
            new Singer{Name = "Gülben Ergen", MusicType = "Pop / Türk Halk Müziği", ReleaseDate = 1997, AlbumSales = 10000000},
            new Singer{Name = "Neşet Ertaş", MusicType = "Türk Halk Müziği / Türk Sanat Müziği", ReleaseDate = 1960, AlbumSales = 2000000},

        };

        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar: ");
        var startWithS = singers.Where(x => x.Name.StartsWith("S"));

        foreach (var item in startWithS)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("--------------------------------");

        Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar: ");
        var albumSales = singers.Where(x => x.AlbumSales >= 10000000);

        foreach (var item in albumSales)
        {
            Console.WriteLine($"{item.Name} {item.AlbumSales}");
        }

        Console.WriteLine("--------------------------------");

        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar: ");
        var pop = singers.Where(x => x.ReleaseDate < 2000 && x.MusicType == "Pop");

        foreach (var item in pop)
        {
            Console.WriteLine($"Ad: {item.Name} / Müzik türü: {item.MusicType} / Çıkış yılı: {item.ReleaseDate}");
        }

        Console.WriteLine("--------------------------------");

        Console.WriteLine("En çok albüm satan şarkıcı: ");
        var topSinger = singers.OrderByDescending(x => x.AlbumSales).FirstOrDefault();
        Console.WriteLine(topSinger.Name);

        Console.WriteLine("--------------------------------");

        Console.WriteLine("En yeni çıkış yapan şarkıcı: ");
        var newestSinger = singers.OrderByDescending(x => x.ReleaseDate).FirstOrDefault();
        Console.WriteLine(newestSinger.Name);

        Console.WriteLine("--------------------------------");

        Console.WriteLine("En eski çıkış yapan şarkıcı: ");
        var oldestSinger = singers.OrderBy(x => x.ReleaseDate).FirstOrDefault();
        Console.WriteLine(oldestSinger.Name);
    }
}