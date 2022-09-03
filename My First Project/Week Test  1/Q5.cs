using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_Loop
{
    class Q5
    {
        static void Main(String[] args)
        {
            int num, num1, r, sum = 0;
            Console.WriteLine("Enter any number");
            num = int.Parse(Console.ReadLine());

            num1 = num;
            while (num > 0) 
            {
                r = num % 10;
                sum = sum + r;
                num = num / 10;

            }
            if( num1 % sum == 0)
            {
                Console.WriteLine("Harshad Number");

            }
            else
            {
                Console.WriteLine("not a harshad numbr");
            }

        }
    }
}
