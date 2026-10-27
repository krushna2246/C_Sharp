using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample
{
    internal class SwitchCase
    {
        public void meth1()
        {
            Console.WriteLine("ENTER NUMBER BETWEEN 1-4 FOR LANGUAGE");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NUMBER BETWEEN 1 OR 2 PREPAID AND POSTPAID");
            int value2 = Convert.ToInt32(Console.ReadLine());
            const int abc=100;
            
            switch (value)
            {
                case 1:
                    Console.WriteLine("Tamil");
                    switch (value2)
                    {
                        case 1:
                            Console.WriteLine("Prepaid");
                            break;
                        case 2:
                            Console.WriteLine("Postpaid");
                            break;
                        case abc:
                            Console.WriteLine("You are using Constant Variable");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Hindi");
                    switch (value2)
                    {
                        case 1:
                            Console.WriteLine("Prepaid");
                            break;
                        case 2:
                            Console.WriteLine("Postpaid");
                            break;
                        case abc:
                            Console.WriteLine("You are using Constant Variable");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("English");
                    switch (value2)
                    {
                        case 1:
                            Console.WriteLine("Prepaid");
                            break;
                        case 2:
                            Console.WriteLine("Postpaid");
                            break;
                        case abc:
                            Console.WriteLine("You are using Constant Variable");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Marathi");
                    switch (value2)
                    {
                        case 1:
                            Console.WriteLine("Prepaid");
                            break;
                        case 2:
                            Console.WriteLine("Postpaid");
                            break;
                        case abc:
                            Console.WriteLine("You are using Constant Variable");
                            break;
                    }
                    break;
            }
        }
    }
}
