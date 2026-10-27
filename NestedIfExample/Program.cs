using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10th Marks ");
            float tenth = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter 12th Marks");
            float twelfth = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Graduation Marks");
            float graduation_marks = Convert.ToSingle(Console.ReadLine());

            if (tenth >= 60)
            {
                if (twelfth >= 60)
                {
                    if (graduation_marks >= 60)
                    {
                        Console.WriteLine("You are Eligible for Placement");
                    }
                    else
                    {
                        Console.WriteLine("You are not eligible");
                    }
                }
                else
                {
                    Console.WriteLine("You are Not Eligible");
                }

            }
            else
            {
                Console.WriteLine("You are Not Eligible for Placements");
            }
         }
    }
    }
