using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Loops_For_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1`den 10`a kadar olan sayilari alt alta yazdiran program.

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**********");




            //1`den 10`a kadar cift olan sayilari alt alta yazdiran program.

            for (int j = 2; j <= 10; j += 2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("**********");




            /*1
              12
              123 seklinde  devam edip
              12345678910 da biten program ciktisini kodlayiniz 
              */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine("");

            }
            Console.ReadLine();
        }
    }
}
