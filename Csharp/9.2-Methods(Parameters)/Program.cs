using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_Methods_Parameters_
{
    class Program
    {
        static void Main(string[] args)
        {
            toplamayap(4, 8);
            carpmayap(5, 4, 2.5);
            adiniyazdir("Muhammet", "Celik");
            Console.ReadLine();
        }
        static void toplamayap(int a, int b) //deger dondurmeyen parametreli fonksiyon
        {
            Console.WriteLine("Degerlerin toplami:" + (a + b));
        }
        static void carpmayap(int a, int b, double c)
        {
            Console.WriteLine(a + "*" + b + "*" + c + ":" + (a * b * c));
        }
        static void adiniyazdir(string isim, string soyisim)
        {
            Console.Write("isminiz ve soyisminiz:" + isim + " " + soyisim);
        }
    }
}
