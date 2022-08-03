using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class Devisible_By_5_Or_Not
    {
        static void Main(String[] args)
        {
            int num;
            Console.Write("Enter any no : ");
            num = int.Parse(Console.ReadLine());
            //num = Convert.ToInt32(Console.ReadLine());

            if(num % 5 == 0)
            {
                Console.WriteLine("It is divisible by 5");
            }
            else
            {
                Console.WriteLine("It is not divisible by 5");
            }
        }
    }
}


