using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Demo1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            long n = long.Parse(Console.ReadLine());
            long r, sum = 0;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            if (sum % 10 == 0)
            {
                Console.WriteLine("Currect IMET number");
            }
            else
            {
                Console.WriteLine("Invalid IMET number");
            }
        
        }
    }
}
