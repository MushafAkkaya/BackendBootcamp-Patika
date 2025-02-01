using LinqJoinPractice;

public class Program
{
    public static void Main()
    {
        List<Authors> authors = new List<Authors>()
        {
            new Authors{AuthorId = 1, Name = "Orhan Pamuk"},
            new Authors{AuthorId = 2, Name = "Elif Şafak"},
            new Authors{AuthorId = 3, Name = "Ahmet Ümit"}
        };

        List<Books> books = new List<Books>()
        {
            new Books{BookId = 1, Title = "Kar", AuthorId = 1},
            new Books{BookId = 2, Title = "İstanbul", AuthorId = 1},
            new Books{BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2},
            new Books{BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3},
        };

        var group = from author in authors
                    join book in books
                    on author.AuthorId equals book.AuthorId
                    select new
                    {
                        Title = book.Title,
                        Name = author.Name
                    };

        foreach (var item in group)
        {
            Console.WriteLine($"Kitap adı: {item.Title} / yazarı: {item.Name}");
        }
    }
}