using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Employee
    {
        protected int age = 10;
        private void meth1()
        {
            Console.WriteLine("Private Method of outer class");
        }
       public class Emp1
        {
            public void meth2()
            {
                new Employee().meth1();
            }
        }
    }
}
