using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    internal class Student
    {
        static int age;
        static Student()
        {
            age = 10;
            Console.WriteLine(age);
        }
        public Student()
        {
            Console.WriteLine("Instance Constructor");
        }
        public void PayFees(int amount)
        {
            amount=amount + 500;
            Console.WriteLine(amount+ " Fees Paid Successfully");
        }
    }
}
