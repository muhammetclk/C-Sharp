using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            byte number2 = (byte)number1;                      //int olan number1 degiskenini byte tipine donusturup number2 degiskenine atadik.
            Console.WriteLine(number2);
            Console.WriteLine(number2.GetType());            // GetType() metodu ile degisken tipini gorebiliriz.            
            int number3 = 400;
            byte number4 = (byte)number3;                //eger number3 un degeri byte tipinin deger araliginda(0-255) yoksa deger kaybina ugrar.
            Console.WriteLine(number4);
            Console.WriteLine(number4.GetType());
            Console.WriteLine("**********************************");



            string number5 = "5";
            string number6 = "7";
            Console.WriteLine(number5 + number6);  //string tipinde oldugu icin 5 ve 7 `yi yan yana yazar.
            int number7 = Convert.ToInt32(number5); // string degerden int degere donusum bu sekilde olur.
            int number8 = Convert.ToInt32(number6);
            Console.WriteLine(number7 + number8); //  number5  ve number6 `yi int tipine donusturup number7 ve number8 e atadigimiz icin 12 yazar.
            Console.WriteLine(number7.GetType());
            Console.WriteLine(number5.GetType());  //number5 ve number6 nin hala string tipinde oldugunu unutmayalim.            
            int number9 = int.Parse(number5);  //ikinci string tipinden int tipine donusum sekli.
            int number10 = int.Parse(number6);
            Console.WriteLine(number9 + number10);
            Console.WriteLine(number9.GetType());
            Console.WriteLine("**********************************");



            int number11 = 5;
            int number12 = 6;
            string a = number11.ToString();   //int tipini string tipine bu sekilde donustururuz.
            string b = number12.ToString();
            Console.WriteLine(a + b);
            Console.WriteLine(a.GetType());
            Console.WriteLine("**********************************");



            double number13 = 2.51;                                //double tipini int tipine donusturduk.Bu ornek icin virgulden sonnraki kisim
            int number14 = Convert.ToInt32(number13);              // 50 den buyuk ise sayiyi yukari yuvarlar.             
            Console.WriteLine(number14);
            Console.WriteLine(number14.GetType());
            Console.WriteLine("**********************************");



            Console.WriteLine("Lutfen yasinizi  iki kere giriniz:");
            string age1 = Console.ReadLine();   //kullanicidan girilen degerler string tipindedir bu yuzden string bir degiskene  atama yapabiliriz
            string age2 = Console.ReadLine();
            Console.WriteLine("Kullanici yas toplami:" + (age1 + age2)); //girilen degerleri string tipinde oldugu icin yan yana yazar.
            int age1int = Convert.ToInt32(age1); //degerleri int `e cevirdigimiz icin toplayabildik.
            int age2int = Convert.ToInt32(age2);
            Console.WriteLine("kullanici yas toplami:" + (age1int + age2int));


            //Not:convert. ile tum tiplere donusum saglayabiliriz.


            Console.ReadLine();




        }
    }
}
