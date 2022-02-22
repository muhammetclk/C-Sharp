using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Database database = new Database(); //Interface de oldugu gibi abstracta newleme yapamazsin.
            Database database = new Oracle();
            Database database1 = new Mysql();
            Mysql mysql = new Mysql();
            mysql.add();
            mysql.delete();
            database.add();
            database1.add();
            database.delete();
            database1.delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("add by default"); //add metodu tumu icin ayni 
        }
        public abstract void delete(); //delete motodu tumu icin farkli.(ici dolu olmayan virtual gibi calisir.)
    }
    class Mysql : Database
    {
        public override void delete() //abstact metod tanimladiktan sonra kullanmak zorundayiz.(interface gibi)
        {
            Console.WriteLine("deleted by Mysql");
        }
    }
    class Oracle : Database
    {
        public override void delete()
        {
            Console.WriteLine("deleted by Oracle");
        }
    }
}
