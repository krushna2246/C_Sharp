using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] language = { };
            string[] language = new string [5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter language");
                //string value = Console.ReadLine();
                string value = Convert.ToString(Console.ReadLine());

                //language.Append(value);
                language[i] = value;
            }
            foreach (string value in language)
            {
                Console.WriteLine(value);
            }
        }
    }
}
