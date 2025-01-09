using ConstructorUsage;

public class Program
{
    public static void Main(string[] args)
    {
        Baby baby = new Baby();
        baby.Name = "Ali";
        baby.Surname = "Veli";

        Baby baby2 = new Baby("Ayşe","Gül");

        baby.NewBaby();
        baby2.NewBaby();
    }
}