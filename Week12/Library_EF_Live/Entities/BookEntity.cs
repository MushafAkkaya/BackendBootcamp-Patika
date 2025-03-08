namespace Library_EF_Live.Entities
{
    public class BookEntity : BaseEntity
    {
        public string Name { get; set; }
        public int? PageCount { get; set; }

        public int BookTypeId { get; set; }

        // Relational Property

        public BookTypeEntity BookType { get; set; }
    }
}
