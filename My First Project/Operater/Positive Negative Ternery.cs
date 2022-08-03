using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class Positive_Negative_Ternery
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

        string result = num > 0 ? "It is Positive number" : num < 0 ? "It is negative number " :"No is Neutral ";
        Console.WriteLine(result);

        }
    }
}
