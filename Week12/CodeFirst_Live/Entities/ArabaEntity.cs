namespace CodeFirst_Live.Entities
{
    public class ArabaEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }
        public bool KoltukIsitmaVarMi { get; set; }
        public DateTime UretimTarihi { get; set; }
    }
}
