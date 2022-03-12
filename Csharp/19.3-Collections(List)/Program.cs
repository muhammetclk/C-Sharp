using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._3_Collections_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer> //Customer type`inda Liste olusturduk.Ve ilk degerleri atadik.
            {
                new Customer() { Id=1,Name="Muhammet"},
                new Customer() { Id=2,Name="Ahmet"} };

            Customer customer2 = new Customer() { Id = 3, Name = "Mehmet" }; //yeni nesne olustruduk ve degerini atadik
            customers.Add(customer2);//Listemize ekledik.

            customers.AddRange(new Customer[2] //listemize Customer typinda dizi seklinde degerleri ekledik.
            {
            new Customer(){Id=4,Name="Ali"},
            new Customer(){Id=5,Name="Veli"}
            });

            var indexof = customers.IndexOf(customer2); //customer2 nin kacinci indexte tutuldugunu bulduk.
            Console.WriteLine("indexof:" + indexof);

            var lastindexof = customers.LastIndexOf(customer2); //customer2 nin kacinci indexte oldugunu sondan arar.index bastan yazar.
            Console.WriteLine("lastindexof:" + lastindexof);

            var count = customers.Count;//listemizin eleman sayisini bulduk.
            Console.WriteLine("count: {0}", count);

            customers.Insert(5, new Customer() { Id = 5, Name = "efe" });//insert ile 5. indexe yeni deger ekledik.Add ile herzaman sona ekleme yapabilirdik.
            Console.WriteLine("index5:" + customers[5].Id + " " + customers[5].Name);
            customers.Insert(0, customer2);//0. indexe customer2 yi ekledik.
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            Console.WriteLine("******************");

            customers.Remove(customer2);//customer2 yi buldugunda direk siler.Baska customer2 varsa onlari silmez.onlari silmek icin birden fazla kullanabiliriz.
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id;
        public string Name;
    }
}
