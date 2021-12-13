using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] sayi = { 1, 2, 3 };diziyi olustururken ilk deger atamasini yapabiliriz.

            double[] ondaliklisayi = new double[4];
            for (int i = 0; i < ondaliklisayi.Length; i++)
            {
                Console.Write("Dizinin " + (i + 1) + ". elamanini giriniz:");
                ondaliklisayi[i] = Convert.ToDouble(Console.ReadLine()); //dizinin degerlerini kullanicidan aldik.
            }
            for (int j = 0; j < ondaliklisayi.Length; j++)
                Console.WriteLine(ondaliklisayi[j]);
            Console.ReadLine();
        }
    }
}
