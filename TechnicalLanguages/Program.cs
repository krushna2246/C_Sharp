using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] technical_skill = { "C++":{ "c++"}, "C#","Java" };
            foreach(string skill in technical_skill) 
            { 
                Console.WriteLine(skill); 
            }
        }
    }
}
