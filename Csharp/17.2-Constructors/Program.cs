using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { Id = 5, name = "Laptop" };//degerleri bu sekildede atayabiliriz.
            Product product1 = new Product(1, "Computer");//Constructor yardimiylada degerleri atayabiliriz.
            Console.ReadLine();
        }
    }
    class Product
    {
        public int Id;
        public string name;
        int _id;
        string _name;
        public Product()
        {

        }
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
            Console.WriteLine(_id + name);
        }
    }
}
