using OOPClass;

public class Program
{
    public static void Main(string[] args)
    {
        Person student = new Person();
        student.Ad = "Ahmet";
        student.Soyad = "Bozan";
        student.DogumTarihi = Convert.ToDateTime("12.02.2013");
        student.OkulNo = 175;

        Person teacher = new Person();
        teacher.Ad = "Mahmut";
        teacher.Soyad = "Özsoy";
        teacher.DogumTarihi = Convert.ToDateTime("01.01.1975");
        teacher.Brans = "Matematik";

        student.Student();

        teacher.Teacher();
    }
}