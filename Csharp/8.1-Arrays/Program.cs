using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5]; //int tipinde 5 indislik sayilar isminde bir dizi tanimladik.
            for (int i = 0; i < sayilar.Length; i++)//for dongusu dizinin uzunlugu kadar donucek ve deger atiyip ekrana basacak.
            {
                sayilar[i] = i + 5;
                Console.WriteLine("indeks" + i + "=" + sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
