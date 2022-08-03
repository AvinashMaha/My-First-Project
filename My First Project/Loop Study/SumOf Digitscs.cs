using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class SumOf_Digitscs
    {
        static void Main(String[] str)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
