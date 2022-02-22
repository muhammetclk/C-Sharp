using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2_Inheritance_Virtual_Method_
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            MySql mySql = new MySql();
            mySql.Add();
            mySql.Delete();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() //Metodu virtual tanimlayip miras alinan yerde override edersek oradaki kod calisir.
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by sql code");
            // base.Add();//Miras alinan yani default metodu calistirir.
        }
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql code");
            //base.Delete();
        }
    }
    class MySql : Database //override etmedigimiz icin temel kod calisir. temel kod calisir
    {

    }
}
