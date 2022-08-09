using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Class1
    {
        void Sum()
        {
            int Sum = 0 ,count = 0;
            for(int i = 1; i<=20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                   
                    Sum = Sum + i;
                    count++;

                }           
            }
            Console.WriteLine("Total count ="+ count);
            Console.WriteLine("Total sum is = "+Sum);
            int avg = Sum / count;
            Console.WriteLine("Avg is " + avg);
        }
        static void Main(String[] args)
        {
            Class1 c = new Class1();
            c.Sum();
        }
    }
}
