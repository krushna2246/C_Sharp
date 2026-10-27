using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParentExample;

namespace ChildExample
{
    internal class Student:Teacher
    {
       public void meth1()
        {
            Console.WriteLine(name);

            Console.WriteLine(age);
        }
    }
}
