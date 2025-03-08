namespace CodeFirstManyToMany.Entities
{
    public class CourseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Relational Property

        public List<StudentCourseEntity> StudentCourses { get; set; }
    }
}
