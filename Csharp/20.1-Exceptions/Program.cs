using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._1_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] cities = new string[3] { "Adana", "istanbul", "izmir" };
                cities[3] = "ankara"; //3. indeks olmadigindan hata olur.(ve catch kismina gecer.)


            }
            catch (IndexOutOfRangeException exception) //index siniri hatasi verince bu catch girer.(sadece catch yazip parametresizde olusturabilirdik.)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)//diger hatalarda bu catcha girer.(bu sekilde birden fazla catch olusturabiliriz.)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();

        }
    }
}
