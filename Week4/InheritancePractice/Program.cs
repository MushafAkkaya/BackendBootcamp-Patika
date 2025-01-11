using InheritancePractice;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("Mahmut", "Özman", 1234);
        student.Person();

        Teacher teacher = new Teacher("Ali", "Veli", 50000);
        teacher.Person();
    }
    
}