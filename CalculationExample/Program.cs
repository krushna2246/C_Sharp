using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationExample
{
    internal class Program
    {
        public void Cal(int value1, int value2, char Operator)
        {
            if (Operator == '+')
            {
                Console.WriteLine(value1 +value2 );
            }
            else if (Operator == '-')
            {
                Console.WriteLine(value1 - value2);
            }
            else if (Operator == '*')
            {
                Console.WriteLine(value1 * value2);
            }
            else if (Operator == '/')
            {
                Console.WriteLine(value1 / value2);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Cal(10, 20, '*');
        }
    }
}
