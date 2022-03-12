using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._4_Collections_Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            //anahtar kelimeyle degerler ulasmak icin dictionary kullaniriz.
            Dictionary<string, string> dictionary = new Dictionary<string, string>();//string tipinde anhtar kelime ve string tipinde degeri.
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("Pencil", "Kalem");
            dictionary.Add("Book", "Kitap");
            Console.WriteLine(dictionary["Book"]);//anahtar kelimesini vererek degerini aldik.
            //Console.WriteLine(dictionary["Table"]);//olmayan bir seyi ararsak hata verir.
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);//tum degerlere bu sekilde ulasiriz.item.Value veya item.Key diyerek sadece onlarada ulasabiliriz.
            }
            Console.WriteLine(dictionary.ContainsKey("Table"));//Table kelimesi varmi diye kontrol edebiliriz.
            Console.WriteLine(dictionary.ContainsKey("Pencil"));
            Console.ReadLine();
        }
    }
}
