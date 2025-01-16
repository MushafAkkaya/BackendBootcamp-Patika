//PRACTICE 1
List<string> inviteList = new List<string>() //Davetli listesi tanımlanıp içine değerler eklenir.
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

Console.WriteLine("** Davetliler **");

foreach (var item in inviteList)
{
    Console.WriteLine(item);
}


//PRACTICE 2
List<string> coffee = new List<string>(5);

Console.WriteLine("Sırasıyla 5 kahve ismi giriniz.");

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Kahve {i}:");
    coffee.Add(Console.ReadLine());
}

Console.WriteLine("Girilen kahve isimleri:");

foreach (var item in coffee)
{
    Console.WriteLine(item);
}
