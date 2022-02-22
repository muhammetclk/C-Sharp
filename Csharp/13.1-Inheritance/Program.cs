using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]//Person classindan da nesne olusturabiliriz.
            {
                new Customer{FirstName="Muhammet",LastName="Celik",Id=3,City="Istanbul" },
                new Student{FirstName="Enver",LastName="Celik",Id=2,Department="Computer Sciences" },
                new Person{FirstName="Firat",LastName="Celik",Id=1}
            };
            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Id);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

    }
    class Customer : Person //Person classindan miras aliyor.(Personda tanimladigimiz ozellikleri icine yazmadan  kullanabiliriz.)
    {
        public string City { get; set; } //ekstra ozelliklerde tanimlayabiliriz.
    }
    class Student : Person //classlar sadece bir tane miras alir.
    {
        public string Department { get; set; }
    }
}
