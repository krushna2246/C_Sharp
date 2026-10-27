using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    internal class School
    {new 
        private School() 
        {
            Console.WriteLine("private constructor");
        }
        public School(string name)
        {
            Console.WriteLine("public constructor");
        }
    }
}
