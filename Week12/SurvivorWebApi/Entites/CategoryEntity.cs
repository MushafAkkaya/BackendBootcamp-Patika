namespace SurvivorWebApi.Entites
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; }

        public List<CompetitorsEntity> Competitors { get; set; }
    }
}
