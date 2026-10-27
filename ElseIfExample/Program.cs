using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Marks");
            float marks=Convert.ToSingle(Console.ReadLine());
            if (marks <= 30)
            {
                Console.WriteLine("You are Fail");
            }
            else if (marks >= 31 && marks <= 50)
            {
                Console.WriteLine("Pass");
            }
            else if (marks >= 51 && marks <= 70)
            {
                Console.WriteLine("Good");
            }
            else if(marks >=71 &&  marks <=90)
            {
                Console.WriteLine("Excelent");
            }
        }
    }
}
