using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariable
{
    internal class Program
    {


        static void Main(string[] args)
        {
           const string name = "Sahil";
            Console.WriteLine(name);
            //name = "Krushna";
            Console.WriteLine(name);
            Console.WriteLine("Krushna");
        }
    }
}
