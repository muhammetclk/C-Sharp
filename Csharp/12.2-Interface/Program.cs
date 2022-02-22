using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //amacimiz herhangi bir veritabaninda islem yapmak.
            // ICustomerDal customer = new ICustomerDal(); interfaceden nesne oluturamayiz.
            CustomerManager customerManager = new CustomerManager();
            OracleCustomerDal oracleCustomer = new OracleCustomerDal();
            customerManager.Add(oracleCustomer);//ICustomerDal tipinde oldugu icin  ister oracle ister SqlServer`a kaydet.
            customerManager.Delete(oracleCustomer);
            customerManager.Add(new SqlServerCustomerDal());//nesneyi direk olusturduk.
            Console.ReadLine();
        }
    }
}
