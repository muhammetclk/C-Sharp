using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3_Classes_Property_
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Muhammet";
            Console.WriteLine("FirstName:" + customer.FirstName);
            Console.ReadLine();
        }
    }
    class Customer
    {
        private string _FirstName;

        public string FirstName //property tanimladik ve set bloguyla private degiskenimize deger atadik. get bloguyla atadigimiz degeri dondurduk.
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        public string LastName { get; set; }


    }
}
