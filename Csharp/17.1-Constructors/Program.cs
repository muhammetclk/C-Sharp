using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(25);//(parametreli veya parametesiz olani burda direk cagiririz.)
            customerManager.List();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        int _count = 15;
        public CustomerManager(int count)//constructor class adiyla ayni olur.(Parametreli Constructor)
        {
            _count = count;
        }
        public CustomerManager()//Parametresiz Constructor (metot overloading yaptik)
        {

        }
        public void List()
        {
            Console.WriteLine("Listed items " + _count);
        }

    }
}
