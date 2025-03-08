namespace Library_EF_Live.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string SchoolNumber { get; set; }

        // Relational Property

        public List<OperationEntity> Operations { get; set; }

    }
}
