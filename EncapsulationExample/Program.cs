using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetName(" ");
            employee.SetSalary(0);
            Console.WriteLine("Employee Name :"+employee.GetName());
            Console.WriteLine("Employee Salary :" +employee.GetSalary());


        }
    }
}
