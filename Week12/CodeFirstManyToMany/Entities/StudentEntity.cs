namespace CodeFirstManyToMany.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relational Property

        public List<StudentCourseEntity> StudentCourses { get; set; }
    }
}
