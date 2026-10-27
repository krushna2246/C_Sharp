using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter your age");
            //int age=Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("You are Eligible for voting");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for voting");
            //}

            //comparision operator 
            //real life examples

            Console.WriteLine("enter marks");
            int marks=Convert.ToInt32(Console.ReadLine());
            if(marks>=35 && marks <= 50)
            {
                Console.WriteLine("you are passed");
            }
            else if(marks >= 51 && marks <= 70)
            {
                Console.WriteLine("You are passed with A Grade");

            }
            else if(marks>=71 && marks <=90)
            {
                Console.WriteLine("You are pass with A+ Grade");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
        }
    }
}
