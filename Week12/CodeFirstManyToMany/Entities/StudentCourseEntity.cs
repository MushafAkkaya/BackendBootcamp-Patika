namespace CodeFirstManyToMany.Entities
{
    public class StudentCourseEntity
    {
        public int StudentId { get; set; }
        public StudentEntity Student { get; set; }

        public int CourseId { get; set; }
        public CourseEntity Course { get; set; }
    }
}
