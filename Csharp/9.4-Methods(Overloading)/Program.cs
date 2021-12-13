using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4_Methods_Overloading_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 50;
            int number2 = 10;
            int result = add(number1, number2);
            Console.WriteLine("result:" + result);
            int result2 = add(number1, number2, 2); //ayni metodu parametresini degistirerek overloading yaptik.
            Console.WriteLine("result2:" + result2);
            Console.ReadLine();
        }

        static int add(int number1, int number2)
        {
            return number1 + number2;
        }
        static int add(int number1, int number2, int number3)
        {
            int result = number1 * number2 * number3;
            return result;
        }
    }
}
