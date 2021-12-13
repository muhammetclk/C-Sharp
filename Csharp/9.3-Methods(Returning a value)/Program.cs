using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_Methods_Returning_a_value_
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelendeger = toplamayap(4, 5);
            Console.WriteLine("Gelendeger:" + gelendeger);
            double gelendeger2 = carpmayap(2.5, 4);
            Console.WriteLine("Gelendeger2:" + gelendeger2);
            Console.ReadLine();
        }

        static int toplamayap(int sayi1, int sayi2) //parametre alan ve deger donduren fonksiyon tanimlamasi.
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        static double carpmayap(double sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

}
