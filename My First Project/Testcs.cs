using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Testcs
    {
        public static void Maxnum(int n)
        {
            int max = 0;
            int min = int.MaxValue;
            while (n > 0)
            {
                int r = n % 10;
                if(max < r)
                {
                    max = r;
                }
                if(min > r)
                {
                    min = r;
                }
                n = n / 10;
            }
            Console.WriteLine("max num is " + max);
            Console.WriteLine("min num is " + min);          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            Testcs.Maxnum(num);
        }
    }
}
