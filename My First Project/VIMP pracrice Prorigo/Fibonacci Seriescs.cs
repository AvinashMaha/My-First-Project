using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.VIMP_pracrice_Prorigo
{
    class Fibonacci_Seriescs
    { // 0,1, 1, 2, 3, 5,8
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3 = 1, n4 = 2;
            Console.WriteLine("Enter the counter");
            int num = int.Parse(Console.ReadLine());
            for(int i = 2; i<num; i++)
            {
                n3 = n2 + n1;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine(n3);

        }
    }
}
