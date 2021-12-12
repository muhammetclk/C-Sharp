using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_Conditionals_Switch_Case_
{
    class Program
    {
        static void Main(string[] args)
        {
            //mini atm uygulamasini switch case ile yapicaz.
            //1-bakiye goruntuleme
            //2-para cekme
            //3-para yatirma
            //4-cikis yap
            //1,2,3,4 disinda bir degerde hata versin

            Console.WriteLine("Atm`ye Hosgeldiniz...");
            Console.WriteLine("Yapicaginiz islemi seciniz...\n1-Bakiye Goruntuleme\n2-Para Cekme\n3-Para Yatirma\n4-Cikis Yap");
            int bakiye = 1000;
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "1":
                    Console.WriteLine("Bakiye:" + bakiye);
                    break;

                case "2":
                    Console.Write("Cekilecek Para Miktarini Giriniz:");
                    int miktar = Convert.ToInt32(Console.ReadLine());
                    if (miktar < bakiye)
                    {
                        bakiye = bakiye - miktar;
                        Console.WriteLine("Paranizi Alabilirsiniz");
                        Console.Write("Yeni Bakiye:" + bakiye);
                    }
                    else
                        Console.WriteLine("Yetersiz Bakiye...");
                    break;

                case "3":
                    Console.Write("Yatirilacak Parayi Giriniz:");
                    int yatirilacakpara = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye + yatirilacakpara;
                    Console.WriteLine("Yeni Bakiye:" + bakiye);
                    break;

                case "4":
                    Console.WriteLine("Cikis Yapiliyor...\n" + "Hoscakalin");
                    break;

                default:
                    Console.WriteLine("Islem Bulunmamaktadir...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
