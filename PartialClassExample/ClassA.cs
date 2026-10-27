using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    internal class ClassA
    {
    }
    internal partial class Employee
    {
       public void meth1()
        {
            Console.WriteLine("Hello Employee class Method");
        }
    }
}
