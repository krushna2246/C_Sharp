using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainingExample
{
    class Parent
    {
        public Parent(int a)
        {
            Console.WriteLine("Parent Constructor :"+a);
        }
    }

    class Child : Parent
    {
        public Child():base(10)
        {
            Console.WriteLine("Child Constructor");
        }
    }
    internal class Program
    {
       static void Main(string[] args)
        {
            Child obj = new Child();
        }
    }
}
