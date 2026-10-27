using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("101011", "Krushna");

            BankAccount account1 = new BankAccount("101012", "Krushna","Personal",30);
            account.Display();


            //output
            //System Log: Account 101011 initialized successfully.
            //Account Id: 101011
            //Holder Name: Krushna
            //Account Type: Savings
            //Balance: 0.0
        }
    }
}
