using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1_AccesModifiers_Private_Protected_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Customer
    {
        private int Id;
        protected int Age;//protected pr'vate ozellikleri gecerlidir.Diger ozelligi   miras alinan classta kullanabiliriz.

        public void Save()
        {
            string Name;  //default olarak private tanimli.
                          //Id ye burdan erisebiliriz. Private erisim belirteciyle tanimlanmis bir ozellige sadece tanimlandigi blokta erisebiliriz.
        }
        public void Delete()
        {
            //name ye burdan erisemeyiz cunku class seviyesinde tanimlanmamis(tanimlandigi blok save metodu)
        }

    }
    class Student : Customer
    {
        public void Save2()
        {

            //Id    Id private tanimlandigindan erisemiyoruz
            // Age = 4;   Age protected tanimlandigindan erisebiliriz.
        }


    }
}
