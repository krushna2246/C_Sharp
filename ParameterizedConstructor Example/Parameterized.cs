using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor_Example
{
    public static class Parameterized
    {
        //public Parameterized(string name) {
        //    Console.WriteLine(name);
        //}
        //public Parameterized(int value1,int value2) 
        //{
        //    Console.WriteLine(value1+value2);
        //}
        static Parameterized()
        {
            Console.WriteLine("Static Constuctor");
        }

        public static void Display()
        {
            Console.WriteLine("Display Method");
        }
        public static void Show() { 


            Console.WriteLine("Show Method");
        }
    //static Parameterized()
    //{
    //    Console.WriteLine("Krushna");
    //}
}
}
