using LinqGroupJoinPractice;

public class Program
{
    public static void Main()
    {
        List<Students> students = new List<Students>()
        {
            new Students{StudentId = 1, StudentName = "Ali", ClassId = 1},
            new Students{StudentId = 2, StudentName = "Ayşe", ClassId = 2},
            new Students{StudentId = 3, StudentName = "Mehmet", ClassId = 1},
            new Students{StudentId = 4, StudentName = "Fatma", ClassId = 3},
            new Students{StudentId = 5, StudentName = "Ahmet", ClassId = 2}
        };

        List<Classes> classes = new List<Classes>()
        {
            new Classes{ClassId = 1, ClassName = "Matematik"},
            new Classes{ClassId = 2, ClassName = "Türkçe"},
            new Classes{ClassId = 3, ClassName = "Kimya"}
        };

        var groupJoin = classes.GroupJoin(
            students,
            c => c.ClassId,
            s => s.ClassId,
            (c, sGroup) => new
            {
                Class = c,
                Student = sGroup.ToList(),
            }
        );

        foreach (var item in groupJoin)
        {
            Console.WriteLine($"{item.Class.ClassName}");
            foreach (var student in item.Student)
            {
                Console.WriteLine($"{student.StudentName}");
            }
        }
    }
}