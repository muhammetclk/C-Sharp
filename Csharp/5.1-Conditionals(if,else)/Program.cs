using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Conditionals_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            //ogrencinin notu 50 den buyukse basarili degilse basarisiz yazan program ciktisini yaziniz.
            //eger girdigimiz not 50 den buyukse if  calisir.50 den buyuk degilse else calisir.
            //eger if veya else`ten sonra tek kod satiri varsa suslu parantez kullanmaya gerek yoktur.

            Console.Write("Ogrencinin notunu giriniz:");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not > 50)
                Console.WriteLine("Basarili");

            else
                Console.WriteLine("Basarisiz");


            Console.ReadLine();
        }
    }
}
