using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Customer
    {
        string name;
        int account_number;
        string branch;
        float balance;
        public Customer(string name, int account_number, string branch)
        {
            this.name = name;
            this.account_number = account_number;
            this.branch = branch;
            this.balance = 0;
        }
        public void GetDetails()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Account Number:" + account_number);
            Console.WriteLine("Branch:" + branch);
        }
        public float CheckBalance()
        {
            return balance;
        }
        public void Debit(float amount)
        {
            balance -= amount;
        }
        public void Credit(float amount)
        {
            balance += amount;
        }


    }
}
