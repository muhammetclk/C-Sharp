using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8_Methods_outkeyword_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 50;
            int result = add(out number1, number2);  //Out ,ref ile ayni sekilde davranir.Farkli olarak ilk basta deger atamasina gerek yoktur.
                                                     //Metodun icinde deger degisikligi yapmak zorundayiz.
            Console.WriteLine("result:" + result);
            Console.WriteLine("number1:" + number1);

            Console.ReadLine();
        }
        static int add(out int number1, int number2)
        {
            number1 = 5;
            return number1 + number2;
        }
    }
}
