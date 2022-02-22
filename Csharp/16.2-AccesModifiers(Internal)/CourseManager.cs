using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._2_AccesModifiers_Internal_
{
    class CourseManager
    {
        public void Add()
        {
            Course course = new Course(); //internal classa erisebiliyoruz.
            course.Id = 3; //internal tanimlanan Id ye erisebiliyoruz.
        }
    }
}
