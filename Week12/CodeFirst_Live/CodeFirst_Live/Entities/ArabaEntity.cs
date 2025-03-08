namespace CodeFirst_Live.Entities
{
    // Entity -> Bu classtan veri tabanı tablosu oluşturulacak demek.
    public class ArabaEntity
    {
        public int Id { get; set; } // Identity kolonu
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }
        public bool KoltukIsitmaVarMi { get; set; }
        public DateTime UretimTarihi { get; set; }

    }
}
