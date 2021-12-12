using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator(=)");
            //atama operatoru  = 
            int number1 = 56; //56 degerini number1 degiskenine atadik.     
            Console.WriteLine(number1);
            //ek atama operatoru sekilleri
            //+=   -=    *=    /=
            int number2 = 6;
            number2 += 5;
            Console.WriteLine(number2);
            number2 = number2 + 5;//ikiside ayni anlama gelir.
            Console.WriteLine(number2);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(+,-)");
            //toplama operatoru + 
            //cikarma operatoru -
            int number3 = 5;
            int number4 = 6;
            int number5 = 3;
            string name = "Muhammet";
            string surname = "Celik";
            //islemi bir degiskene atayip yazdirma ornegi.
            int result1 = (number3 + number4) - number5;
            string result2 = name + surname;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            //degerleri fonksiyonun icinde isleme sokma ornegi.
            Console.WriteLine(number3 + number4);
            Console.WriteLine(name + surname);
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(*,/)");
            //carpma operatoru *
            //bolme operatoru /
            int number6 = 10;
            int number7 = 5;
            int result3 = number6 * number7;
            int result4 = number6 / number7;
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(%)");
            //mod alma operatoru % isaretidir.Bir sayinin baska bir sayiya bolumunden kalan degeri verir.
            int number8 = 10;
            int number9 = 3;
            Console.WriteLine(number8 % number9);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(++,--)");
            //arttirma operatoru  ++ 
            //azaltma operatoru --
            //degiskenin sagina kullanirsan bir sonraki satirda islem gerceklesir.Soluna kullanirsan direk gerceklesir.
            int number10 = 10;
            Console.WriteLine(number10);
            number10++; //bir sonraki satira gecince arttirma gerceklesir.
            Console.WriteLine(number10);
            Console.WriteLine(number10++);//degiskenin sagina kullandik ve alt satira gecmedigimiz icin arttirma gerceklesmedi
            Console.WriteLine(number10); //alt satira gecince arttirma gerceklesti          
            int number11 = 5;
            Console.WriteLine(++number11); //soluna yazinca arttirma islemini direk yapar.
            Console.WriteLine(--number11); //soluna yazdik ve azatlma islemini ayni satirda yapti.
            Console.WriteLine(number11--);//sagina yazdik azaltma islemini bir sonraki satirda yapar.
            Console.WriteLine(number11);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(==)");
            //esittir operatoru ==
            int number12 = 4;
            int number13 = 4;
            bool result5 = number12 == number13;//number12 esitmidir number13 e.
            Console.WriteLine(result5);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(!=)");
            //esit degildir operatoru !=
            int number14 = 5;
            int number15 = 6;
            bool result6 = number14 != number15; //number14 esit degildir number15 e.True dondurur.
            Console.WriteLine(result6);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(>,>=,<,<=)");
            //buyuktur operatoru >
            //buyuk esittir operatoru >=
            //kucuktur operatoru <
            //kucuk esittir operatoru <=
            int number16 = 7;
            int number17 = 9;
            int number18 = 10;
            int number19 = 7;
            bool result7 = number16 > number17;  // false dondurur.
            bool result8 = number16 >= number19; //true dondurur. 
            bool result9 = number18 < number16;  //false dondurur.
            bool result10 = number19 <= number16; //true dondurur.
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine("*************************");



            Console.WriteLine("Operator(&&,||,!)");
            // ve operatoru &&       kosullrin hepsi saglanmasi durumunda true dondurur.   
            //veya operatoru ||      kosullardan birinin saglanmasi durumunda true dondurur.
            //degil operatoru !      tersini alir.
            int number20 = 4;
            int number21 = 5;
            int number22 = 6;
            bool result11 = number20 > number21 && number21 < number22; // kosullardan bir tanesi sagliyor false dondurur.
            bool result12 = number20 < number21 && number21 < number22; //kosullarin ikiside sagliyor true dondurur True dondurur.
            bool result13 = number20 > number21 || number21 < number22; //kosullrdan birinin saglamasi yeterli true dondurur.
            bool result14 = number20 > number21 || number21 < number22; //true dondurur !(degili) false olur.
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(!result14);


            Console.ReadLine();
        }
    }
}
