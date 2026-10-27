using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Student:Employee
    {
       public void meth3()
        {
            Student student = new Student();
            //Console.WriteLine(emp.age);
            Console.WriteLine(student.age);
            new Emp1().meth2();

        }
    }
}
