using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personmanager = new PersonManager();//personmanager nesnesini olusturduk.
            Customer customer = new Customer { FirstName = "Muhammet", LastName = "Celik", Id = 1, Address = "istanbul" };//customer nsenesini olusturduk ve degerleri atadik.
            personmanager.Add(customer);//customer nesnesini PersonManagerin Add metoduna parametre olarak yolladik.
            personmanager.Add(new Student { Id = 1, FirstName = "Enver", LastName = "Celik", Departmant = "Computer Sciences" });//nesneyi direk olusturup yolladik.

            Console.ReadLine();
        }
    }
    interface IPerson //interface olusturduk 
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson //interface icinde tanimladigimiz ozellikleri classlarda erisim belirtecleriyle birlikte implemente etmeliyiz.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } //class icinde exstra seyler tanimlayabiliriz.
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)//IPerson tipinde olusturdugumuz icin hem customer nesnesini hemde student nesnesini parametre olarak alabiliriz.
        {                                //IPerson tipinde oldugu icin sadece interfacin ozelliklerine erisebiliriz.
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Id);
        }
    }
}
