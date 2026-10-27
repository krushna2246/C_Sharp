using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClass
{
    internal class BankAccount
    {
        int amount = 1000;

        public void DisplayName()
        {
            Console.WriteLine("Krushna");
        }
        public void Credit(int amt)
        {
            amount += amt;
            Console.WriteLine(amt + " Credited");
        }
        public void Debit(int amt)
        {
            amount -= amt;
            Console.WriteLine(amt + " Debited");
        }
        public void CheckBalance()
        {
            Console.WriteLine(amount);
        }
    }
}
