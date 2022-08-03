using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class Odd_Even_Tarnery
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number :");
            int num = Convert.ToInt32(Console.ReadLine());


            string result = num % 2 == 0 ? "It is even number" : "It is a odd number";
            Console.WriteLine(result);
         }   
    }
}
