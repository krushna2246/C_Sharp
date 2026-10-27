using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class BankAccount
    {
        // Core auto-implemented or read-only properties
        public string AccountId { get; }
        public string AccountHolder { get; }
        public string AccountType { get; }
        public decimal Balance { get; private set; } // Using decimal for financial accuracy

        // 1. The "Master" Constructor: Holds the central initialization logic
        public BankAccount(string accountId, string accountHolder, string accountType, decimal initialBalance)
        {
            AccountId = accountId;
            AccountHolder = accountHolder;
            AccountType = accountType;
            Balance = initialBalance;

            // Centralized telemetry, auditing, or event tracking logs go here
            Console.WriteLine($"System Log: Account {AccountId} initialized successfully.");
        }

        // 2. Overloaded Constructor: Assumes a $0.0 starting balance
        public BankAccount(string accountId, string accountHolder, string accountType)
            : this(accountId, accountHolder, accountType, 0.0m) // Chains to Master
        {
        }

        // 3. Overloaded Constructor: Assumes standard "Savings" type and $0.0 balance
        public BankAccount(string accountId, string accountHolder)
            : this(accountId, accountHolder, "Savings", 0.0m) // Chains to Master
        {
        }

        // 4. Default Constructor: Used for placeholder/temporary system accounts
        public BankAccount()
            : this($"TEMP-{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}", "Guest User", "Standard", 0.0m) // Chains to Master
        {

        }
        public void Display()
        {
            Console.WriteLine("Account Id: "+AccountId+"\n Holder Name: "+AccountHolder+"\n Account Type: "+AccountType+"\n Balance: "+Balance);
        }
    }
}
