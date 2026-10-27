using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Company
    {

        public string companyName;
        public string companyAddress;

        public Company(string CompanyName, string CompanyAddress)
        {
            companyName = CompanyName;
            companyAddress = CompanyAddress;
        }
        public Company(Company obj) 
        {
            companyName=obj.companyName;
            companyAddress=obj.companyAddress;
        }
        public void Display()
        {
            Console.WriteLine("Company Name :"+companyName);
            Console.WriteLine("Company Address :"+companyAddress);
        }
    }
}
