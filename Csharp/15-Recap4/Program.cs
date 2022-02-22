using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Recap4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Logger = new FileLogger(); //CustomerManager classindaki ILogger tipindeki propertiye nesne olusturduk.
            customerManager.Add();

            Console.ReadLine();

        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log(); //kaydedilmesini istedigimiz yere gore loglama yaptik
            Console.WriteLine("Customer Added");
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

            Console.WriteLine("Logged to Database ");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}
