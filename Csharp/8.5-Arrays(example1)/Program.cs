using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5_Arrays_example1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicinin girdigi sayi dizide varmi varsa kac tane, yoksa dizide yoktur yazan programi kodlayiniz.

            int[] sayilar = { 1, 2, 3, 3, 3, 4, 5, 5, 6, 6, 6, 6, 7, 8, 10, 11, 12, 15, 15, 15, 15, 15, 27, 6, 7, 3 };
            Console.WriteLine("Bir sayi giriniz:");
            int deger = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == deger)
                    sayac++;
            }
            if (sayac == 0)
                Console.WriteLine("Dizide yoktur.");
            else            
                Console.WriteLine("Kullanicinin girdigi deger dizide " + sayac + " kere kullanilmistir.");
            
            Console.ReadLine();
        }
    }
}
