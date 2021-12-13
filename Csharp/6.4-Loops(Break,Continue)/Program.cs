using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Loops_Break_Continue_
{
    class Program
    {
        static void Main(string[] args)
        {
            //break anahtar kelimesi

            for (int i = 1; i <=10; i++)
            {
                if (i == 5)
                    break;            //break kelimesi i =5 olunca donguyu bitirdi.
                Console.WriteLine(i);
            }
            Console.WriteLine("******");




            for (int j = 1; j <=10; j++)
            {
                if (j == 5)
                    continue;         //continue kelimesi j=5 olunca for dongusunun basina tekrar dondu ve 5`i yazdirmadan calismaya devam etti
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
