using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine(number);

            string name = "     Krushna..!!      ";
            //Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.TrimEnd());
            Console.WriteLine(name.TrimStart());

            //Console.WriteLine(name.Reverse().ToArray());




            Console.WriteLine(name.TrimStart());

            //Console.WriteLine(name.Length);

            //float pi = 3.17f;
            //Console.WriteLine(pi);

            //char grade = 'A';
            //Console.WriteLine(grade);

            //double salary = 500000.01;
            //Console.WriteLine(salary);
        }
    }
}
