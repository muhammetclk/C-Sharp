using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1; //number2 ye number1`in degerini atadik
            number1 = 30;
            Console.WriteLine("Number2:" + number2); //

            string[] cities1 = new string[] { "Adana", "Antalya", "artvin" };
            string[] cities2 = new string[] { "Bolu", "Bitlis", "Bilecik" };

            cities2 = cities1; //cities2`ye cities1`in referancini atadik.(artik Bolu bitlis bilecik degerleri yok.)
            cities1[0] = "Istanbul"; //cities1`i degistirmemizle cities2`de degisti.
            Console.WriteLine("cities2[0]:" + cities2[0]);
            Console.ReadLine();
        }
    }
}
