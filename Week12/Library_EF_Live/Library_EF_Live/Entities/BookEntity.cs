namespace Library_EF_Live.Entities
{
    public class BookEntity : BaseEntity
    {
        public string Name { get; set; }
        public int? PageCount { get; set; }

        public int BookTypeId { get; set; }
        public int AuthorId { get; set; }

        // Relational Property

        public BookTypeEntity BookType { get; set; }
        public AuthorEntity Author { get; set; }
        public List<OperationEntity> Operations { get; set; }

    }
}
