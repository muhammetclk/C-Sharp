using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6_Arrays_example2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan 10 adet sayi alip kac tanesinin tek kac tanesinin cift oldugunu bulalim.
            //cift ve tek degerlerin toplamini ekrana yazdiralim.
            //toplami buyuk olani ekrana bastiralim.


            int[] sayilar = new int[10];
            int tektoplam = 0;
            int cifttoplam = 0;
            int teksayac = 0;
            int ciftsayac = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayiyi giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                if (sayilar[i] % 2 == 0)
                {
                    ciftsayac++;
                    cifttoplam += sayilar[i];
                }
                else
                {
                    teksayac++;
                    tektoplam += sayilar[i];
                }
            }
            Console.WriteLine("Cift degerlerin sayisi:" + ciftsayac);
            Console.WriteLine("Tek degerlerin sayisi:" + teksayac);
            Console.WriteLine("Cift degerlerin toplami:" + cifttoplam);
            Console.WriteLine("Tek degerlerin toplami:" + tektoplam);
            if (cifttoplam > tektoplam)
                Console.WriteLine("Cift toplam Daha buyuktur");
            else
                Console.WriteLine("Tek Toplam Daha buyuktur.");

            Console.ReadLine();
        }
    }
}
