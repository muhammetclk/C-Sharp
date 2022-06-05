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
                    NumberSave numberSave = new NumberSave(humans);
                    humans.Add(numberSave);
                    break;
                case "2":
                    NumberDelete numberDelete = new NumberDelete(humans);
                    break;
                case "3":
                    NumberUpdate numberUpdate = new NumberUpdate(humans);
                    break;
                case "4":
                    TelDirectory telDirectory = new TelDirectory(humans);
                    break;
                case "5":
                    TelDirectorySearch telDirectorySearch = new TelDirectorySearch(humans);
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
        public NumberSave(List<Human> humans)
        {
            Console.Write("Lutfen isim giriniz:");
            FirstName = Console.ReadLine();
            Console.Write("Lutfen soyisim giriniz:");
            LastName = Console.ReadLine();
            Console.Write("Lutfen Telefon numarasini giriniz:");
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
                    if (NameOrSurname.ToLower() == human.FirstName.ToLower() || NameOrSurname.ToLower() == human.LastName.ToLower())
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
                    if (NameOrSurname.ToLower() == human.FirstName.ToLower() || NameOrSurname.ToLower() == human.LastName.ToLower())
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
    class TelDirectory : Human
    {
        public TelDirectory(List<Human> humans)
        {
            Console.WriteLine("Telefon Rehberi");
            humans.OrderBy(a => a).ToArray();
            foreach (var human in humans)
            {
                
                Console.WriteLine("FirstName:" + human.FirstName);
                Console.WriteLine("LastName:" + human.LastName);
                Console.WriteLine("TelNumber:" + human.TelNumber);
            }
        }
    }
    class TelDirectorySearch : Human
    {
        public TelDirectorySearch(List<Human> humans)
        {
            Console.WriteLine("Arama yapmak istediginiz tipi seciniz:");
            Console.WriteLine("Isim veya soyisime gore arama yapmak icin:(1)");
            Console.WriteLine("Telefon numarasina gore arama yapmak icin:(2)");
            Console.Write("Islem:");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == 1)
            {
                Console.Write("NameOrSurname:");
                string NameOrSurname = Console.ReadLine();
                int count = 0;
                foreach (var human in humans)
                {
                    if (NameOrSurname.ToLower() == human.FirstName.ToLower() || NameOrSurname.ToLower() == human.LastName.ToLower())
                    {
                        for (;count<humans.Count;count++)
                        {
                            Console.WriteLine("FirstName: " + humans[count].FirstName + "\nLastName:" + humans[count].LastName + "\nTelNumber:" + humans[count].TelNumber);   
                        }
                        break;
                    }
                    else
                        count++;                        
                }
            }
            else if (result == 2)
            {
                Console.Write("TelNumber:");
                long _TelNumber = Convert.ToInt64(Console.ReadLine());
                int count = 0;
                foreach (var human in humans)
                {
                    if(human.TelNumber==_TelNumber)
                    {
                        for (; count < humans.Count; count++)
                        {
                            Console.WriteLine("FirstName: " + humans[count].FirstName + "\nLastName:" + humans[count].LastName + "\nTelNumber:" + humans[count].TelNumber);
                        }
                        break;
                    }
                    else
                        count++;
                }
            }
        }
    }
}
