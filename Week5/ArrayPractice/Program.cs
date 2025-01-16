public class Program
{
    static void Main()
    {
        int[] array = new int[10];//10 elemanlık dizi tanımlandı.

        for (int i = 0; i < array.Length; i++)//diziye 0'dan boyutuna kadar değer eklendi.
        {
            array[i] = i;
        }

        foreach (var item in array)//Diziye eklenen elemanlar ekrana yazdırıldı.
        {
            Console.WriteLine(item);
        }

        Console.Write("Bu diziye yeni bir değer ekleyin: ");

        if (int.TryParse(Console.ReadLine(), out int newNumber))//Kullanıcıdan alınan değer geçerli mi kontrolü. Geçerli ise out ile değişkene atanır.
        {
            List<int> numberlist = new List<int>(array);//Dizi'ler sabit boyutlu olduğundan dolayı eleman eklemek için listeye çevirdik.
            numberlist.Add(newNumber);

            numberlist.Sort();//Liste küçükten büyüğe sıralandı.
            numberlist.Reverse();//Büyükten küçüğe sıralama istendiği için liste ters çevirildi.

            Console.WriteLine("Dizinin büyükten küçüğe sıralanışı: ");

            foreach (var item in numberlist)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş yaptınız.");
        }


    }
}

