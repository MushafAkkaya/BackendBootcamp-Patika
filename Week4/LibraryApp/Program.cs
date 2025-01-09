using LibraryApp;

public class Program
{
    public static void Main(string[] args)
    {
        Library defaultLibrary = new Library();
        defaultLibrary.BookName = "Ay'a Yolculuk";
        defaultLibrary.AuthorName = "Jules";
        defaultLibrary.AuthorSurname = "Verne";
        defaultLibrary.PageNumber = 180;
        defaultLibrary.Publisher = "Güneş";

        Library parametersLibrary = new Library("Hobbit","Tolkien",400,"İthaki");

        defaultLibrary.SaveBook();
        parametersLibrary.SaveBook();
    }
}