using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._9_Methods_stringMethods_
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "istanbul";
            string city2 = "duzce";

            Console.WriteLine(String.Format("{0} {1}", city, city2)); //yanyana yazdirir.
            Console.WriteLine("**********");



            var sentence = "My name is Muhammet Celik";
            Console.WriteLine("Length:" + sentence.Length); //karakter sayisini verir.(Bosluk da bir karakterdir.)
            Console.WriteLine("**********");



            var result = sentence.Clone();//cumleyi cloneladik.
            sentence = "Muhammet Celik"; //cumle degistirildi.
            Console.WriteLine("result:" + result); //clonelanan cumleyi yazdi.
            Console.WriteLine("**********");



            bool result2 = sentence.EndsWith("k"); //cumle k ilemi bitiyor.
            bool result3 = sentence.StartsWith("Muhammet");//cumle Muhammet ilemi basliyor.
            Console.WriteLine("Endswith:" + result2);
            Console.WriteLine("StartWith:" + result3);
            Console.WriteLine("**********");



            var result4 = sentence.IndexOf("met");//met kelimesi varmi kacinci indexte basliyor.(indexler 0 dan baslar. )
            var result5 = sentence.IndexOf(" ");//bosluk karakteri varmi kacinci indexte basliyor
            Console.WriteLine("result4:" + result4);
            Console.WriteLine("result5:" + result5);
            var result6 = sentence.LastIndexOf("li");//aramaya sondan baslar.indexi bastan sayarak bulur.
            Console.WriteLine("result6:" + result6);
            Console.WriteLine("**********");



            var result7 = sentence.Insert(0, "My name is "); //0. indexten itibaren My name is  ekler.
            Console.WriteLine("result7:" + result7);
            Console.WriteLine("**********");



            var result8 = sentence.Substring(3, 8);//3. indexten itibaren 8 karakter yazdirir.
            Console.WriteLine("result8:" + result8);
            Console.WriteLine("**********");



            var result9 = sentence.ToLower(); //tum kelimeleri kucuk harf yapar.
            Console.WriteLine("result9" + result9);
            var result10 = sentence.ToUpper();//tum kelimeleri buyuk yapar.
            Console.WriteLine("result10:" + result10);
            Console.WriteLine("**********");



            var result11 = sentence.Replace(" ", "-");//bosluk karakterinin yerine - karakterini koyar.
            Console.WriteLine("result11:" + result11);
            Console.WriteLine("**********");



            var result12 = sentence.Remove(2);//2. indexten itibaren siler.
            Console.WriteLine("result12:" + result12);
            var result13 = sentence.Remove(8, 3);//8. indexten itibaren 3 karakter siler.
            Console.WriteLine("result13:" + result13);

            Console.ReadLine();
        }
    }
}
