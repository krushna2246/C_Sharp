using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Krushna",1122334455,"Baner Road");
            c1.CheckBalance();
            c1.Credit(1000);
            c1.Debit(750);
            Console.WriteLine(c1.CheckBalance());
        }
    }
}
