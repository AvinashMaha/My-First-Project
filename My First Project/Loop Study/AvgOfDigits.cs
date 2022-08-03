using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class AvgOfDigits
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            float avg ;
            int count = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                count++;
                num = num / 10;
               
            }
            Console.WriteLine(sum);

            avg = sum / count;
            Console.WriteLine(avg);






        }
    }
}
