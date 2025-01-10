using EncapsulationPractice;

public class Program
{
    public static void Main(string[] args)
    {
        Araba araba = new Araba();
        araba.Marka = "Renault";
        araba.Model = 2004;
        araba.Renk = "Bej";
        araba.KapiSayisi = 4;

        araba.ArabaBilgileri();
    }
}