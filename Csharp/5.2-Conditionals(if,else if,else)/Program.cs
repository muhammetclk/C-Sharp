using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Conditionals_if_else_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*kullanicidan 3 tane not alan ve bunlarin ortalamasini bulan,ortalamasi  80-100 arasinda ise A+
             60-80 arasinda ise A,40-60 arasinda ise B,40 dan kucuk ise f yazdiran programi kodlayiniz.*/
            //Ilk hangi kosul saglarsa onun kodu calisir ve cikar.

            Console.WriteLine("Birinci notu giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci notu giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucuncu notu giriniz:");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Not ortalamaniz" + ortalama);
            if (ortalama > 80 && ortalama < 100)
                Console.WriteLine("Not degeriniz:A+");
            else if (ortalama > 60 && ortalama < 80)
                Console.WriteLine("Not degeriniz:A");
            else if (ortalama > 40 && ortalama < 60)
                Console.WriteLine("Not degeriniz:B");
            else
                Console.WriteLine("Not degeriniz:F");

            Console.ReadLine();
        }
    }
}
