using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logger logger = new Logger();
            Logger.Information("Start Main Method");
            Logger.Warning("10");
            Logger.Error("Error Occured");
        }
    }
}
