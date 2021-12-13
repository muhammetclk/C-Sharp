using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_Recap2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan alinan sayiya kadar olan degerleri toplayip ortalamasini bulan program
            //ortalama 50`den buyukse ortalama 50`den buyuktur degilse 50`den kucuktur yazsin.

            Console.Write("Girdiginiz sayiya kadar toplayip Ortalamasi alinacak sayiyi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;

            int i = 0;
            for (; i <= sayi; i++)
            {
                toplam += i;
            }
            double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalama 50`den buyuktur.");
                Console.WriteLine("Ortalama" + ortalama);
            }
            else
            {
                Console.WriteLine("Ortalama 50`den kucuktur.");
                Console.WriteLine("Ortalama:" + ortalama);
            }

            Console.ReadLine();
        }
    }
}
