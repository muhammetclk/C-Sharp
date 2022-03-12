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
            List<Human> humen = new List<Human> {
                new Human() { FistName = "Burak", LastName = "Yilmaz", TelNumber = 12345678900 },
                new Human() { FistName = "Emre", LastName = "Belozoglu", TelNumber = 12345678911 },
                new Human() { FistName = "Hakan", LastName = "Calhanoglu", TelNumber = 12345678922 },
                new Human() { FistName = "Mesut", LastName = "Ozil", TelNumber = 12345678933 },
                new Human() { FistName = "Ferdi", LastName = "Kadioglu", TelNumber = 12345678944 }
                
            };

            Console.WriteLine("Lutfen Yapmak istediginiz islemi seciniz:\n" + "1-Yeni Numara Kaydetmek\n" +
                "2-Varolan Numarayi Silmek\n" + "3-Varolan Numarayi Guncelleme\n" + "4-Rehberi Listelemek\n" + "5-Rehberde Arama Yapmak");
            Console.Write("Islem:");
            string Islem = Console.ReadLine();
            switch (Islem)
            {
                case "1":
                    NumberSave numberSave = new NumberSave();
                    humen.Add(numberSave);
                    break;
                case "2":
                    while (true)
                    {
                        NumberDelete numberDelete = new NumberDelete(humen);
                        bool result = true;
                        int count = 0;

                        foreach (var item in humen)
                        {
                            if (item.FistName == numberDelete.nameorsurname || item.LastName == numberDelete.nameorsurname)
                            {

                                break;
                            }
                            else
                            {
                                result = false;
                                count++;
                                continue;
                            }

                        }
                        if (result)
                        {
                            Console.WriteLine(humen[count].FistName + humen[count].LastName + " isimli kisi rehberden silinmek uzere, onayliyor musunuz?" +
                                "1-Yes\n" + "2=No");
                            string result2 = Console.ReadLine();
                            if (result2 == "1")
                            {
                                humen.Remove(humen[count]);
                                break;
                            }
                            else
                                break;
                        }
                        else
                        {
                            Console.WriteLine("Aradaginiz kriterlere uygun veri bulunamadi.Lutfen bir secim yapiniz:" + "Silmeyi sonlandirmak icin:(1)" +
                                "Yeniden denemek icin:(2)");
                            string result3 = Console.ReadLine();
                            if (result3 == "1")
                                break;

                        }
                    }


                    break;




            }
            Console.ReadLine();
        }
    }
    class Human
    {
        
        public string FistName { get; set; }
        public string LastName { get; set; }
        public long TelNumber { get; set; }

    }
    class NumberSave : Human
    {
        public NumberSave()
        {
            Console.Write("Lutfen isim giriniz:");
            FistName = Console.ReadLine();
            Console.Write("Lutfen soyisim giriniz:");
            LastName = Console.ReadLine();
            Console.Write("Lutfen Telefon mumarasini giriniz:");
            TelNumber = Convert.ToInt64(Console.ReadLine());
        }
    }
    class NumberDelete : Human
    {
        public string nameorsurname;
        public NumberDelete(List<Human> humen)
        {
            Console.WriteLine("Lutfen numarasini Silmek istediginiz kisinin adini veya soyadini giriniz:");
            nameorsurname = Console.ReadLine();

        }
    }
    
}
