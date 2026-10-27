using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value=Convert.ToInt32(Console.ReadLine());
            //char Char=Convert.ToString(Console.ReadLine());
            const int value2 = 100;
            switch (value)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case value2:
                    Console.WriteLine("Another service");
                    break;
            }
        }
    }
}
