namespace PolymorphismPractice
{
    internal class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override void AlanHesapla()
        {
            Console.Write("Dik üçgenin alanı: " + (Genislik * Yukseklik) / 2);
        }
    }
}
