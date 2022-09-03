using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.VIMP_pracrice_Prorigo
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int a = int.Parse(Console.ReadLine());
            int factorial = 1;
            for(int i = 1; i<=a ; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
