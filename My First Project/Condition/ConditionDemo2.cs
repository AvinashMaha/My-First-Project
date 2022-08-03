using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class ConditionDemo2
    {
        static void Main(String[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = int.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                Console.WriteLine(num1 + "is greater");
            }
            else
            {
                Console.WriteLine(num2 + "is greater");
            }
        }
    }
}
