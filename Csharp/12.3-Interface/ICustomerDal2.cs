using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3_Interface
{
    interface ICustomerDal2
    {
        void Add();
        void Delete();
        void Update();
    }

    class SqlServerCustomerDal : ICustomerDal2
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
    class OracleCustomerDal : ICustomerDal2
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
        public void Add(ICustomerDal2 customerDal)
        {
            customerDal.Add();
        }
    }
}
