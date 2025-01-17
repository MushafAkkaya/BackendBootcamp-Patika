using IMDBList;

public class Program
{
    public static void Main()
    {
        List<Film> cinema = new List<Film>();

        while (true)
        {
            film: Console.Write("Film ismi giriniz: ");
            string movieName = Console.ReadLine();

            if (cinema.Count > 0)
            {
                bool isExist = false;
                foreach (var item in cinema)
                {
                    if (item.MovieName.ToLower() == movieName.ToLower())
                    {
                        isExist = true;
                        Console.WriteLine("Bu isimde bir film daha önce eklendi.");
                        break;
                    }
                }
                if (isExist) 
                {
                    continue;
                }
            }

            imdb: Console.Write("Filmin imdb puanını giriniz: ");
            double imdbScore = Convert.ToDouble(Console.ReadLine());

            if (imdbScore !> 0 && imdbScore !< 10)
            {
                Console.WriteLine("Geçerli bir imdb puanı girmeniz gerekiyor.");
                goto imdb;
            }

            cinema.Add(new Film(movieName, imdbScore));

            Console.WriteLine("Yeni bir film eklemek ister misiniz? (evet/hayır)");
            string isContinue = Console.ReadLine().ToLower();

            if (isContinue.Contains("evet") || isContinue.Contains("e"))
            {
                goto film;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Eklenen tüm filmler:");
        foreach (var item in cinema)
        {
            Console.WriteLine(item.MovieName);
        }

        Console.WriteLine("Imdb puanı 4 ile 9 arası olan filmler:");
        foreach (var item in cinema)
        {
            if (item.ImdbScore >= 4.0 && item.ImdbScore <= 9.0)
            {
                Console.WriteLine(item.MovieName);
            }
        }

        Console.WriteLine("İsmi 'A' ile başlayan filmler:");
        foreach (var item in cinema)
        {
            if (item.MovieName.StartsWith("A") || item.MovieName.StartsWith("a"))
            {
                Console.WriteLine(item.MovieName + " / " + item.ImdbScore);
            }
        }
    }
}