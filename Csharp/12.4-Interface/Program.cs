using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //birden fazla interface tanimladik ve ozelliklerine gore kullandik.(Robot yemek yemeyecegi ve maas almayacagi icin onda sadece bir tane kullandik.)
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
               new Manager(),
               new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager GetSalary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Worked");
        }
    }
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker GetSalary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Worked");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
