using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5_Methods_DefaultParameters_
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = add(); //default olarak metodda tanimladigimiz degerleri kullandi.
            Console.WriteLine("result:" + result);
            int result2 = add(2);//birinci deger olarak 2 , ikinci deger olarak default olarak tanimladigimiz degeri kullandi.
            Console.WriteLine("result2:" + result2);
            int result3 = add(4, 5); //parametre olarak gonderdigimiz degerleri kullandi.
            Console.WriteLine("result3:" + result3);

            Console.ReadLine();
        }
        static int add(int number1 = 5, int number2 = 6) //default deger tanimlarken (int number1=3,int number2) seklinde tanimlayamayiz 
        {                                                //default deger sonda olmali.
        
            return number1 * number2;
        }
    }
}
