using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2_Collections_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>(); //string tipinde degerleri tutar(type degistirebilirsin).Array formatindadir.
            cities.Add("Muhammet");//Add metodu ile deger atamalarini yaptik.
            cities.Add("Ahmet");//ArrayListte yapmis oldugumuz diger fonksiyonlarda Listlerde kullanilabilir.
            cities.Add("Mehmet");

            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }
            List<Customer> customers = new List<Customer>(); //list`i bir nesne tipindede tanimlayabiliriz.
            customers.Add(new Customer() { Id = 1, Name = "Muhammet", surname = "Celik" });//yeni nesne olusturup deger atamalarini yapabiliriz.
            customers.Add(new Customer() { Id = 2, Name = "ahmet", surname = "mehmet" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id); //foreach dongusuyle istedigimiz degerini bastirabiliriz.
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.surname);


            }
            List<Customer2> customers2 = new List<Customer2> { new Customer2() { Id = 3, Name = "veli", surname = "asd" } };//listeyi bu sekildede olusturabiliriz.
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id;
        public string Name;
        public string surname;
    }
    class Customer2
    {
        public int Id;
        public string Name;
        public string surname;
    }
}
