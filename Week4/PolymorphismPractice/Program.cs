using PolymorphismPractice;

public class Program
{
    public static void Main(string[] args)
    {
        Kare kare = new Kare(5, 5);
        kare.AlanHesapla();

        Dikdortgen dikdortgen = new Dikdortgen(7, 5);
        dikdortgen.AlanHesapla();

        DikUcgen dikUcgen = new DikUcgen(8, 10);
        dikUcgen.AlanHesapla();
    }
}