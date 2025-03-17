namespace DependencyInjectionPractice.Models
{
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}
