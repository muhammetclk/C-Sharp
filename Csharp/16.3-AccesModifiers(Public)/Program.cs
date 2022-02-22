using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1; //buraya ekledik.

namespace _16._3_AccesModifiers_Public_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1  class`a  farkli projelerden ersismek icin
            //1-class`i public tanimlamaliyiz.
            //2-References lerden kullanmak istedigimiz classin projesini ekleriz .
            //3-using ile projenin adini eklerriz.

            Deneme deneme = new Deneme(); //ConsoleApp1 deki classi public tanimladigimiz icin erisebildik.
        }
    }
}
