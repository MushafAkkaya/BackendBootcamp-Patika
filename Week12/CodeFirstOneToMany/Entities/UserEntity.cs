namespace CodeFirstOneToMany.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        //Relational Property
        public List<PostEntity> Posts { get; set; }
    }
}
