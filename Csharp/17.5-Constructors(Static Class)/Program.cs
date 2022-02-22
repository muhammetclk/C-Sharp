using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._5_Constructors_Static_Class_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manager manager = new Manager(); static classtan nesne olusturamayiz.
            Manager.Id = 1; //class adiyla kullanip erisiriz.
            Manager.Add();
            Student student = new Student();//static olmayan classta static tanimladigimiz constructor ilk once calisir.
            Student student1 = new Student();//static constructor kac nesne olusturulursa olusturulsun sadece 1 kere calisir.
            Console.ReadLine();
        }
    }
    static class Manager //static bir classta her sey static tanimlanmali.
    {
        public static int Id { get; set; }

        public static void Add()
        {
            Console.WriteLine("Id:" + Id);
        }


    }
    class Student
    {
        public Student()
        {
            Console.WriteLine("Public Constructor worked");
        }
        static Student()//static constructor parametre almaz.Erisim belirteci kullanmaz. 1 classta 1 tane static contructor olur.
        {
            Console.WriteLine("Static Cunstructor worked ");
        }
    }
}
