using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //amac elimizdeki veriyi tum database lere eklemek.Daha sonra yeni bir databesede eklemek istersek kolay bir sekilde yapabiliriz.
            ICustomerDal2[] customerDals = new ICustomerDal2[2]//diziyi new liyoruz.
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (var item in customerDals)
            {
                item.Add();
            }


            Console.ReadLine();
        }
    }
}
