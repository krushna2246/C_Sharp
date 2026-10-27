using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceExample
{
    internal class Person
    {
        //public Person(int age):this()
        //{
        //    Console.WriteLine("Age of Person"+age);
        //}
        public Person()
        {
            Console.WriteLine("This is default constructor of Person class");
        }
        public void GetPersonName()
        {
            Console.WriteLine("Person Name : Krushna");
        }
    }
}
