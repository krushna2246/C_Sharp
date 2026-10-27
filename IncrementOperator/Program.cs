using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //a++;
            int b = 100;
            //Console.WriteLine(a++); //postIncrement
            //Console.WriteLine(++a); //preIncrement
            Console.WriteLine(++b); //101
            Console.WriteLine(b++); //101
            Console.WriteLine(b); //102
            Console.WriteLine(b--);
        }   
    }
}
