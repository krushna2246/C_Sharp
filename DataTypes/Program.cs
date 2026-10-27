using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        int age;
        Program(int age)
        {
            this.age = age;
        }
        static void Main(string[] args)
        {
            //value type data;
            int a = 10;
            int b = a;
            b++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // Reference type data;
            Program obj1 = new Program(23);
            Program obj2 = obj1;

            obj1 = null;

            obj2.age++;

            //Console.WriteLine(obj1.age);
            Console.WriteLine(obj2.age);
        }
    }
}
