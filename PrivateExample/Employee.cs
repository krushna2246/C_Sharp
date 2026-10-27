using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateExample
{

    internal class Employee
    {
        private int GetSalaray()
        {
            return 1000;
        }
        public string EmployeeDetails()
        {
            Console.WriteLine(GetSalaray());
            
            return "Krushna";
        }
    }
}
