using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialVariable
{
  
    partial class Student
    {
        public void Display()
        {
            ValidateStudent();  // Calling partial method

            Console.WriteLine("Student details displayed.");
        }

        partial void ValidateStudent(); // Declaration
    }

    partial class Student
    {
        partial void ValidateStudent() // Implementation
        {
            Console.WriteLine("Validating student...");
        }
    }



}
