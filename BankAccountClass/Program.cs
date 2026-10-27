using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount= new BankAccount();
            bankAccount.DisplayName();
            bankAccount.Credit(5);
            bankAccount.CheckBalance();
            bankAccount.Debit(500);
            bankAccount.CheckBalance();

        }
    }
}
