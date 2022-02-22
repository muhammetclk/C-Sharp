using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Interface
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();

    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlServer Added");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer Deleted");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class CustomerManager
    {

        public void Add(ICustomerDal customerDal) //ICustomer dal tipinde olusturarak hem oracle hem de sql kaydedebiliriz.
        {
            customerDal.Add();
        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    }
}
