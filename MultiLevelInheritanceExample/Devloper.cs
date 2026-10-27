using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceExample
{
    internal class Developer:Employee
    {
        public Developer()
        {
            Console.WriteLine("This is the default constructor of Developer class ");
        }
        public void WriteCode()
        {
            Console.WriteLine("Developer Writing a code");
        }
    }
}
