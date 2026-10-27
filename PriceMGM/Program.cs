using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceManagement1;
namespace PriceMGM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("Enter Principle Amount :");
            int amount = Convert.ToInt32(Console.ReadLine());

            decimal result1=bank.CityBank(amount);

            decimal result=bank.Hdfc(amount);

            Console.WriteLine("HDFC Bank Interest : " +result);
            Console.WriteLine("CityBank Interest : " +result1);
        }
    }
}
