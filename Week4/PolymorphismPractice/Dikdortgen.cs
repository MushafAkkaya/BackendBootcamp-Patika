namespace PolymorphismPractice
{
    internal class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override void AlanHesapla()
        {
            Console.Write("Dikdortgenin alanı: ");
            base.AlanHesapla();
        }
    }
}
