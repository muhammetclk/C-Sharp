using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_Classes_Property_
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;                              //deger atamalarini yaptik.
            customer1.FirstName = "Muhammet";
            customer1.LastName = "Celik";
            customer1.City = "Istanbul";
            Console.WriteLine("cutomer1:" + (customer1.FirstName + customer1.LastName));

            Customer customer2 = new Customer { Id = 2, FirstName = "Enver", LastName = "Celik", City = "Istanbul" };//deger atamasini bu sekildede yapabiliriz.
            Console.WriteLine("customer2:" + (customer2.FirstName + customer2.LastName));
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; } //get ve set bloklari kapali oldugu icin normal degisken gibi davranir.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
