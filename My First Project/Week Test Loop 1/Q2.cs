using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_Loop
{
    class Q2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1;i<=num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
