namespace CustomIdentity_Live.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
