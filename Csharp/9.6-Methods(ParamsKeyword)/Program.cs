using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6_Methods_ParamsKeyword_
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodlari overloading yapmak yerine params kullanarak birden fazla sekilde kullanabiliriz.

            int result = add(2, 3, 4, 5);
            int result2 = add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("result:" + result);
            Console.WriteLine("result2:" + result2);
            Console.ReadLine();
        }

        static int add(params int[] numbers)  //eger birden fazla parametre kullanilirsa params metodun son parametresi olmali.
        {
            return numbers.Sum(); //sum metodunu kullanarak  gelen degerleri topladik.
        }
    }
}
