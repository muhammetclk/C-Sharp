using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//kolseksiyonlari kullanabilmek icin kutuphanesini ekledik.

namespace _19._1_Collections_ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList ile dizilerde yaptigimiz gibi degerler tutariz.
            //ArrayList in dizilere gore ozel fonksiyonlari vardir.

            ArrayList isimler = new ArrayList(); //arraylist classindan isimler adinda bir nesne olusturduk.
            isimler.Add("Muhammet");    //add metodu ile ilk yazdigimiz ilk index olacak sekilde degerlerimizi ekledik.
            isimler.Add("Ali");         //ekledigimiz degerler object veri tipindedir her tipte degeri alir.
            isimler.Add("Ahmet");
            isimler.Add("Mehmet");
            foreach (var a in isimler)
                Console.WriteLine(a);
            Console.WriteLine("*******************");


            isimler.Remove("Mehmet"); //Remove fonksiyonu ile mehmet degerini sildik.
            foreach (var a in isimler)
                Console.WriteLine(a);
            Console.WriteLine("*******************");


            int _Count = isimler.Count;
            Console.WriteLine("Kac Tane Deger Var:" + _Count);
            Console.WriteLine("*******************");


            isimler.Clear(); //ArrayList icindeki degerleri siler.
            foreach (var a in isimler)
                Console.WriteLine(a);
            Console.WriteLine("Degerler silindi.");
            Console.WriteLine("*******************");


            ArrayList sayilar = new ArrayList();
            sayilar.Add(5);
            sayilar.Add(1);
            sayilar.Add(116);
            sayilar.Add(72);
            sayilar.Add(56);
            bool varmi = sayilar.Contains(5);  //Contains 5 degeri olup olmadigini kontrol eder varsa bool tipinde true atar yoksa false atar.
            Console.WriteLine("5 degeri varmi?" + varmi);
            Console.WriteLine("*******************");


            int index = sayilar.IndexOf(116);   //IndexOf ile girdigimiz degerin index numarasini verir.
            Console.WriteLine("index 116 :" + index);
            Console.WriteLine("*******************");


            sayilar.Insert(3, 46);  //3.indexe 46 degerini atar, ordaki deger ise birs onraki indexe gecer.
            foreach (var a in sayilar)
                Console.WriteLine(a);
            Console.WriteLine("*******************");


            sayilar.Reverse(); //diziyi ters cevirir.
            foreach (var a in sayilar)
                Console.WriteLine(a);
            Console.WriteLine("*******************");


            sayilar.Sort(); //diziyi kucukten buyuge siralar.
            foreach (var a in sayilar)
                Console.WriteLine(a);
            Console.WriteLine("*******************");


            sayilar.Reverse();  //reverse metodunu birdaha kullanarak buyukten kucuge siralayabiliriz.
            foreach (var a in sayilar)
                Console.WriteLine(a);
            Console.WriteLine("*******************");


            Console.ReadLine();
        }
    }
}
