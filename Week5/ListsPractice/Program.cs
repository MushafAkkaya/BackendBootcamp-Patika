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