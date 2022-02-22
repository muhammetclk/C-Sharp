using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new DatabaseLogger());//nereye loglayacagimizi seciyoruz
            customerManager.Add();
            Console.ReadLine();
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged File");
        }
    }
    class CustomerManager
    {
        ILogger _logger;
        public CustomerManager(ILogger logger) //burda loglama islemini cagiriyoruz.
        {
            _logger = logger;
            _logger.Log();
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }

    }
}
