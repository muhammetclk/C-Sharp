using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4_Conditionals_if_else_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            //beden kitle indeksi= kilo/boy*boy
            //beden kitle indeksi 18`e esit veya kucukse zayif
            //18 ile 25 arasindaysa normal
            //25 ten buyuk ise obez yazdiran programi kodlayiniz.

            Console.Write("Lutfen kilonuzu giriniz:");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lutfen boyunuzu   giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double indeks = kilo / (boy * boy);
            Console.WriteLine("Beden Kitle Indeksiniz:" + indeks);
            if (indeks <= 18)
                Console.WriteLine("zayif");
            else if (indeks > 18 && indeks < 25)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("obez");

            Console.ReadLine();
        }
    }
}
