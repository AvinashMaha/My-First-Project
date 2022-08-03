using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class FactorialUsingLoop
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number  = ");
            int num = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for(int i = 1;i<=num; i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine(factorial);
        }
    }
}
