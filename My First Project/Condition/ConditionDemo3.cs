using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class ConditionDemo3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Even number");
 }
            else
            {
                Console.WriteLine("odd number");
            }
        }
    }
}
