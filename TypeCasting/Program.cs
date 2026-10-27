using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            //short value2 = value;
            //Cannot implicitly convert type 'type1' to 'type2'. An explicit conversion exists (are you missing a cast?)
            short value2 = Convert.ToSByte(value);
            Console.WriteLine(value2);

        }
    }
}
