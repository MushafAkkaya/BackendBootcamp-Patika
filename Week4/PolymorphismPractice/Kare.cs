namespace PolymorphismPractice
{
    internal class Kare : BaseGeometrikSekil
    {
        public Kare(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override void AlanHesapla()
        {
            Console.Write("Karenin alanı: ");
            base.AlanHesapla();
        }
    }
}
