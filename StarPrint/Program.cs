using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i <5; i++)
            //{
            //    for (int j = i; j>0;j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //************************************************

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine();
            //}

            //************************************************

            //for (int i = 0; i < 5; i++)
            //{

            //    for (int k = i; k < 5; k++)
            //    {

            //        Console.Write(" ");
            //    for (int j = 5; j >0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    }
            //    Console.WriteLine();
            //}

            //********************************************



            //for (int i = 0; i < 5; i++)
            //{
            //    for (int k = i; k > 0; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //o/p
            //*****
            // ****
            //  ***
            //   **
            //    *


            //for (int i = 0; i < 4; i++)
            //{
            //    for (int k = i; k > 0; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 7; j > 0;j--)
            //    {
            //        Console.Write("*");
            //        j = j - 2;
            //    }
                

                //for (int k = i; k > 0; k--)
                //{
                //    Console.Write(" ");
                //}
            //    Console.WriteLine();
            //}


            //********************************************


            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 5; k > i; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }










        }
    }
}
