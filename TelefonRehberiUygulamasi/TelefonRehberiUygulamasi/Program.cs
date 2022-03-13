using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human> {
                new Human() { FirstName = "Burak", LastName = "Yilmaz", TelNumber = 12345678900 },
                new Human() { FirstName = "Emre", LastName = "Belozoglu", TelNumber = 12345678911 },
                new Human() { FirstName = "Hakan", LastName = "Calhanoglu", TelNumber = 12345678922 },
                new Human() { FirstName = "Mesut", LastName = "Ozil", TelNumber = 12345678933 },
                new Human() { FirstName = "Ferdi", LastName = "Kadioglu", TelNumber = 12345678944 }

            };

            Console.WriteLine("Lutfen Yapmak istediginiz islemi seciniz:\n" + "1-Yeni Numara Kaydetmek\n" +
                "2-Varolan Numarayi Silmek\n" + "3-Varolan Numarayi Guncelleme\n" + "4-Rehberi Listelemek\n" + "5-Rehberde Arama Yapmak");
            Console.Write("Islem:");
            string Islem = Console.ReadLine();
            switch (Islem)
            {
                case "1":
                    NumberSave numberSave = new NumberSave();
                    humans.Add(numberSave);
                    break;
                case "2":
                    NumberDelete numberDelete = new NumberDelete(humans);
                    break;
                case "3":
                    NumberUpdate numberUpdate = new NumberUpdate(humans);
                    break;





            }
            Console.ReadLine();
        }
    }

    class Human
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TelNumber { get; set; }

    }
    class NumberSave : Human
    {
        public NumberSave()
        {
            Console.Write("Lutfen isim giriniz:");
            FirstName = Console.ReadLine();
            Console.Write("Lutfen soyisim giriniz:");
            LastName = Console.ReadLine();
            Console.Write("Lutfen Telefon mumarasini giriniz:");
            TelNumber = Convert.ToInt64(Console.ReadLine());
        }
    }
    class NumberDelete : Human
    {
        public NumberDelete(List<Human> humans)
        {
            while (true)
            {
                Console.WriteLine("Lutfen numarasini Silmek istediginiz kisinin adini veya soyadini giriniz:");
                Console.Write("NameOrSurname:");
                string NameOrSurname = Console.ReadLine();
                bool IsThere = true;
                int count = 0;
                foreach (var human in humans)
                {
                    if (NameOrSurname == human.FirstName || NameOrSurname == human.LastName)
                    {
                        IsThere = true;
                        break;
                    }
                    else
                    {
                        IsThere = false;
                        count++;
                    }
                }
                if (IsThere)
                {
                    Console.WriteLine(humans[count].FirstName + " " + humans[count].LastName + " isimli kisi rehberden silinmek uzere onayliyormusunuz? (y/n)");
                    Console.WriteLine("1-Yes\n" + "2-No");
                    Console.Write("Islem:");
                    int Confirmation = Convert.ToInt32(Console.ReadLine());
                    if (Confirmation == 1)
                    {
                        humans.Remove(humans[count]);
                        Console.WriteLine("Siliniyor...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cikiliyor...");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aradaginiz kriterlere uygun veri bulunamadi.Lutfen bir secim yapiniz:" + "Silmeyi sonlandirmak icin:(1)" +
                                "Yeniden denemek icin:(2)");
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        Console.WriteLine("Cikiliyor...");
                        break;
                    }
                }
            }
        }
    }
    class NumberUpdate : Human
    {
        public NumberUpdate(List<Human> humans)
        {
            while (true)
            {
                Console.WriteLine("Lutfen Numarasini guncellemek istediginiz kisinin adini ya da soyadini giriniz:");
                Console.Write("NameOrSurname:");
                string NameOrSurname = Console.ReadLine();
                bool IsThere = true;
                int count = 0;
                foreach (var human in humans)
                {
                    if (NameOrSurname == human.FirstName || NameOrSurname == human.LastName)
                    {
                        IsThere = true;
                        break;
                    }
                    else
                    {
                        IsThere = false;
                        count++;
                    }
                }
                if (IsThere)
                {
                    Console.WriteLine(humans[count].FirstName + " " + humans[count].LastName + " isimli kisi bulundu");                    
                    Console.Write("Yeni Numarayi giriniz:");
                    humans[count].TelNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Guncelleniyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi.Lutfen bir secim yapiniz.");
                    Console.WriteLine("Guncellemeyi sonlandirmak icin:(1)\n" + "Yeniden denemek icin:(2)");
                    Console.Write("islem:");
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        Console.WriteLine("Cikiliyor...");
                        break;
                    }
                }
            }

        }
    }

}
