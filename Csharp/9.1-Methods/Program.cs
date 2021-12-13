using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            adiniyazdir(); //adiniyazdir fonksiyonunu cagirdik.
            selamver();//selamver fonksiyonunu cagirdik.

            Console.ReadLine();
        }
        static void adiniyazdir() //paramatresiz deger dondurmeyen fonksiyon
        {
            Console.WriteLine("Muhammet Celik");
        }
        static void selamver()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
