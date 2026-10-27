using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 5; i++)
            //{
            //    for(int k = 0; k < i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 5; j > i; j--)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}

            for(int i = 0; i < 5; i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
