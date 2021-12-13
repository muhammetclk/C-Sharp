using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Recap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanici giris sayfasi uygulamasi.
            //kullanici adi ve sifresini dogru girerse giris yaptiniz yazsin
            //3`den fazla yanlis girerse hesabiniz bloke olmus yazsin.
            int hak = 3;
            string kullaniciadi = "Muhammet";
            string sifre = "123456";
            while (true)
            {

                Console.Write("Lutfen Kullanici Adini Giriniz:");
                string giriskullaniciadi = Console.ReadLine();
                Console.Write("Lutfen Sifrenizi Giriniz:");
                string girissifre = Console.ReadLine();
                if (kullaniciadi == giriskullaniciadi && sifre == girissifre)
                {
                    Console.WriteLine("Giris Yaptiniz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanici adi veya Sifreniz yanlis ");
                    if (hak == 0)
                    {
                        Console.WriteLine("Hesabiniz Bloke olmustur.");
                        break;
                    }
                    else
                        hak--;
                }
            }

            Console.ReadLine();
        }
    }
}
