using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte Type");
            //byte veri tipi 0-255 arasi tamsayilari tutar.1 byte yer kaplar.
            byte number1 = 5;
            byte number2 = 16;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            //byte number3 = 256;    hata verir.
            //max ve min degerlerini bu sekilde gorebiliriz.
            byte maxnumber1 = byte.MaxValue;
            byte minnumber1 = byte.MinValue;
            Console.WriteLine(maxnumber1);
            Console.WriteLine(minnumber1);
            Console.WriteLine("**************");


            Console.WriteLine("short Type");
            //short veri tipi -32768-32767 arasi  tam sayi degerlerini tutar.2 byte yer kaplar.
            short number3 = -50;
            short number4 = 2500;
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            short maxnumber2 = short.MaxValue;
            short minnumber2 = short.MinValue;
            Console.WriteLine(maxnumber2);
            Console.WriteLine(minnumber2);
            Console.WriteLine("***********");


            Console.WriteLine("int Type");
            //int veri tipi 10 basamakli sayilara kadar olan tamsayilari tutar.4 byte yer kaplar.
            int number5 = 500000;
            int maxnumber3 = int.MaxValue;
            int minnumber3 = int.MinValue;
            Console.WriteLine(number5);
            Console.WriteLine(maxnumber3);
            Console.WriteLine(minnumber3);
            Console.WriteLine("*********");


            Console.WriteLine("long Type");
            //long veri tipi 19 basamakli tam sayilari tutar.8 byte yer kaplar.
            long number6 = 5600000000000;
            Console.WriteLine(number6);
            long maxnumber6 = long.MaxValue;
            long minnumber6 = long.MinValue;
            Console.WriteLine(maxnumber6);
            Console.WriteLine(minnumber6);
            Console.WriteLine("*********");


            Console.WriteLine("float Type");
            /*float veri tipi ondalikli sayilari tutar.7 basamakli ondalik sayilara kadar tutar.
              4 byte yer kaplar. vs default olarak double kabul ettigi icin yazdigimiz degerin
            sonuna f harfini koymaliyiz yoksa hata verir.*/
            float number7 = 12.56f;
            Console.WriteLine(number7);
            Console.WriteLine("*******");


            Console.WriteLine("double Type");
            //double ondalikli sayi tutar. 15 basamakli ondalik sayilara kadar tutar.8 byte yer kaplar.
            double number8 = 45.56;
            Console.WriteLine(number8);
            Console.WriteLine("******");


            Console.WriteLine("decimal Type");
            //decimal veri tipi ondalikli sayi tutar.(double gore virgulden sonra daha cok deger tutar.)
            //decimalde ondalikli bir sayi yazarken sonuna m harfini koymaliyiz.
            decimal number9 = 24.47895645m;
            Console.WriteLine(number9);
            Console.WriteLine("***********");


            Console.WriteLine("char Type");
            //char veri tipi karakterleri tutmak icin kullanilir.tek tirnak icerisinde tek deger olarak tanimlariz.2 byte yer kaplar.
            char number10 = 'M';
            Console.WriteLine(number10);
            //char number="a" cift tirnak kullanidigindan hata verir.
            //char number='ab' tek deger olmadigindan hata verir.
            Console.WriteLine("*********");


            Console.WriteLine("string Type");
            //string veri tipi, metin tutmak icin kullanilir.Cift tirnak icinde yazilir.Uzunluga gore kapladigi alan degisir.
            string name = "Muhammet";
            string surname = "Celik";
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.Write(name);
            Console.WriteLine(surname);
            Console.WriteLine("********");


            Console.WriteLine("bool Type");
            //bool veri tipi true yada false dondurur.
            bool number11 = true;
            bool number12 = false;
            Console.WriteLine(number11);
            Console.WriteLine(number12);
            bool number13 = 10 > 3;  //10 3`ten buyuk oldugundan true dondurur.
            Console.WriteLine(number13);
            Console.WriteLine("**********");


            Console.WriteLine("object Type");
            //object veri tipi tum tipleri tutar.
            object number14 = 10;
            object number15 = 10.2;
            object number16 = 'a';
            object number17 = "merhaba";
            Console.WriteLine(number14);
            Console.WriteLine(number15);
            Console.WriteLine(number16);
            Console.WriteLine(number17);
            Console.WriteLine("**********");
            Console.ReadLine();


            Console.ReadLine();


        }
    }
}
