using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Company company1 = new Company("TCS","Hinjewadi");
            Company company2 = new Company(company1);
            company1.Display();
            company2.Display();

        }

    }
}
