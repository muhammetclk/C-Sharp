using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Arrays_Foreach_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 15, 20, 25 };

            foreach (int i in sayilar) //foreach dongusu ile dizinin degerlerini sirayla i degiskenine atayip ekrana yazdirdik.
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
