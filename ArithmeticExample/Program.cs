using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 1;
            Console.WriteLine("Enter Value");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Interest rate");
            decimal rate = Convert.ToDecimal(Console.ReadLine());
            decimal final = value * (rate / 100) * year;
            Console.WriteLine("Final Rate");
            Console.WriteLine(final);
            //String fname = "Krushna";
            //String lname = "Andhale";
            //String lname2 =fname+lname;
            //Console.WriteLine(lname2);
        }
    }
}
