using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            int fees = 5000;
            student.PayFees(fees);
            Console.WriteLine("students have total Fees "+fees);
        }
        
    }
}
