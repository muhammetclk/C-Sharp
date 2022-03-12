using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._2_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string> { "Ahmet", "Mehmet", "Ali" }; //liste olustrduk ve degerleri atadik
            try
            {
                if (!students.Contains("Veli")) //veli varmi diye kontrol ettik.  yoksa hata firlattik.
                {
                    throw new RecordNotFoundException("Record not found");//kendi mesajimiz constructorda calisti ve message nin yerine gecti.

                }
                else
                    Console.WriteLine("Record Found");
            }
            catch (RecordNotFoundException exceptions)
            {
                Console.WriteLine(exceptions.Message);
            }
            Console.ReadLine();
        }
    }
    class RecordNotFoundException : Exception//kendi hata sinifimizi olusturduk.
    {
        public RecordNotFoundException(string message) : base(message) //contructor kullanarak kendi mesajimizi base yolladik.
        {

        }
    }
}
