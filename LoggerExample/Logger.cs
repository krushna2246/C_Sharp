using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{
    internal static class Logger
    {
        public static void Information(string message)
        {
            Console.WriteLine($"info : {message}");
        }
        public static void Warning(string message)
        {
            Console.WriteLine($"Warning : {message}");
        }
        public static void Error(string message)
        {
            Console.WriteLine($"error: {message}");
        }
    }
}
