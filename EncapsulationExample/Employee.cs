using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    //best example of Encapsulation is ATM Machine
    //customer details must be protected or private from unauthorized access
    public class Employee
    {
        string employeeName = "Krushna";
        float salary = 100000;
        public void SetName(string name)
        {
            if(name!=" ")
            {
                employeeName = name;
            }
            else
            {
                Console.WriteLine("Enter valid Name");
            }
}
        public void SetSalary(float sal)
        {
            if (sal > 0)
            {
                salary = sal;
            }
            else
            {
                Console.WriteLine("Enter valid Salary");
            }
        }
        public string GetName()
        {
            return employeeName;
        }
        public float GetSalary()
        {
            return salary;
        }
    }
}
