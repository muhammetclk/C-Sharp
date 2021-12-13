using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_Loops_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1`den 10`a kadar olan sayilari while dongusuyle yazdiran program.

              int i = 1;
              while (i <= 10)  //i degeri kucukmudur 10 dan diye sorarak false olana kadar devam eder.
              {
                  Console.WriteLine(i);
                  i += 1;
              }
            Console.WriteLine("********");



            //100`den 0`a kadar  cift olan sayilari buyukten kucuge sekilde yazdiran program.

            int j = 100;
            while (j >= 0)
            {
                Console.WriteLine(j);
                j -= 2;
            }
            Console.ReadLine();
        }
    }
}
