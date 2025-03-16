namespace SurvivorWebApi.Entites
{
    public class CompetitorsEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
