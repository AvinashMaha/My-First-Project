using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class Nested_Even_Odd
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
               if (num >= 5 && num <= 10)
                {
                    Console.WriteLine("Hello Even");
                }
               else
                {
                    Console.WriteLine("Only even");
                }
            }
            else if (num % 2 != 0)
            {
                if (num >= 2 && num <= 6)
                {
                    Console.WriteLine("Hello odd");
                }
                else
                {
                   Console.WriteLine("Odd Number");
                }














            }
        }
    }
}