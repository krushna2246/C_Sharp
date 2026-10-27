using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringExample
{
    internal class Program
    {
        static void Main(string[] args)
       {            //  main khiladi tu anadi
            String name = "Krushna";
            int length = name.Length;

            //it only printing in reverse order
            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            
        }
    }
}
