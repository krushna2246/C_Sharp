using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceExample
{
    internal class Employee:Person
    {
        public Employee()
        {
            Console.WriteLine("This is default constructor of Employee class");
        }
        public void GetEmployeeId()
        {
            Console.WriteLine("Employee id : 101");
        }
    }
}
