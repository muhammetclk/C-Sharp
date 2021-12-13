using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7_Methods_refkeyword_
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodu ref keyword olmadan kullaninca,number1 degismedi. 
            int number1 = 20;
            int number2 = 30;
            int result = add(number1, number2);
            Console.WriteLine("result:" + result);
            Console.WriteLine("number1:" + number1);


            //Metodu ref keyword ile kullaninca number1 degisti.(ref keywordu hem metdodda hem de metodu cagirirken kullanmak zorundayiz.)
            //ref keywordu kullandigimiz degiskenin ilk deger atamasi yapilmis olmali.
            int result2 = add2(ref number1, number2);
            Console.WriteLine("result:" + result);
            Console.WriteLine("number1:" + number1); ;
            Console.ReadLine();
        }
        static int add(int number1, int number2)
        {
            number1 = 50;
            return (number1 + number2);
        }
        static int add2(ref int number1, int number2)
        {
            number1 = 50;
            return number1 + number2;
        }
    }
}
