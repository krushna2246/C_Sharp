using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            developer.GetEmployeeId();
            developer.GetPersonName();
            developer.WriteCode();
        }
    }
}
