using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3_Loops_Do_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            //do daki kodlari calistirip while dongusundeki sarta bakar sagliyorsa dongu calismaya devam eder.
            //1`den 10`a kadar olan sayilari do-while ile yazdirma

            int i = 1; //degiskeni disarda tanimlamalisin.
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.WriteLine("*******");



            //1 den 100`e kadar olan sayilarin toplamini yazdiran program.

            int j = 1;
            int result = 0;
            do
            {
                result += j;
                j++;
            } while (j <= 100);

            Console.WriteLine("result:" + result);






            Console.ReadLine();
        }
    }
}
