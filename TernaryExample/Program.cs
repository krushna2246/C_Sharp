using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = (number % 2 == 0) ? "Number is Even" : "Number is Odd";
            Console.WriteLine(result);
        }
    } 
}
