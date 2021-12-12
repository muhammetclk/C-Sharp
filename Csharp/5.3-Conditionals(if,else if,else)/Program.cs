using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Conditionals_if_else_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            //atm uygulamasi
            //kullaniciya hangi islemi yapmak istedigini soracagiz.
            //1-Bakiye goruntuleme.
            //2-para cekme 
            //3-para yatirma
            //q ya basarsa cikis yaptiracagiz.
            Console.WriteLine("Atm`ye Hosgeldiniz");
            Console.WriteLine("Yapmak istediginiz islemi seciniz:");
            Console.WriteLine("1-Bakiye Goruntuleme\n2-Para Cekme\n3-Para Yatirma\nq-Cikis yapma");
            int bakiye = 400;
            string islem = Console.ReadLine();
            if (islem == "1")
                Console.WriteLine("Bakiye:" + bakiye);
            else if (islem == "2")
            {
                Console.WriteLine("Cekmek Istediginiz Para Miktarini Giriniz:");
                int miktar = Convert.ToInt32(Console.ReadLine());
                if (miktar > bakiye)                
                    Console.WriteLine("Yeterli Bakiyeniz Bulunmamaktadir.");               
                else
                {
                    bakiye = bakiye - miktar;
                    Console.WriteLine("Yeni Bakiye:" + bakiye);
                    Console.WriteLine("Paranizi Alabilirsiniz:");
                }
            }
            else if (islem == "3")
            {
                Console.WriteLine("Yatirmak Istediginiz Para Miktarini Giriniz:");
                int yatirilanpara = Convert.ToInt32(Console.ReadLine());
                bakiye = bakiye + yatirilanpara;
                Console.WriteLine("Yeni Bakiye:" + bakiye);
            }
            else if (islem == "q")            
                Console.WriteLine("Hoscakalin");            
            else
                Console.WriteLine("Lutfen gecerli bir islem yapiniz!");





            Console.ReadLine();
        }
    }
}
