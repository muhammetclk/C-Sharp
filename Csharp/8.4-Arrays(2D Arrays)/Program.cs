using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_Arrays_2D_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            //cok boyutlu dizi.

            string[,] regions = new string[7, 3] //7 sayisi satiri,3 sayisi sutunu olusturur.
            {
                {"istanbul","yalova","izmit"},
                {"van","siirt","mus"},
                {"ankara","konya","kirikkale"},
                {"antalya","adana","mersin"},
                {"mugla","izmir","aydin"},
                {"bitlis","diyarbakir","mardin"},
                {"rize","giresun","samsun"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) //GetUpperBound(0) satirin uzunlugunu gosterir. (0 dizinin satirini temsil ediyor)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)//GetUpperBound(1) sutunun uzunlugunu gosterir (1 dizinin sutununu temsil ediyor.)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }
            Console.ReadLine();
        }
    }
}
