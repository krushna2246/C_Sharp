using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
     partial class Employee
    {
        int data = 10;
        //partial void Meth1();
        public void displayName()
        {
            Console.WriteLine("Krushna");

        }
    }
    partial class Employee
    {
        //char data;
        //partial void Meth1()
        //{
        //    Console.WriteLine("nothing");
        //}
        public void displayName(int a)
        {
            Console.WriteLine("Balram");
        }

    }
}
