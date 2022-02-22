using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._4_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Console.ReadLine();
        }
    }
    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {

            Console.WriteLine("{0} Message", _entity);//message metodu calisti ve  {0}`a _entity`nin degerini atadi.
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity) //bu constructora gelen mesaji inherit edilen base`e yolladik.
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }

    }
}
