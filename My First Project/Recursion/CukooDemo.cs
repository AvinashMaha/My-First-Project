using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Recursion
{//recursion
    class CukooDemo
    {
        static int cukoo(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
            {
                return 1;
            }
            else
                return 1 * cukoo(n - 1) + 2 * cukoo(n - 2) + 3 * 1;
        }
        static void Main(string[] args)
        {
            int result = cukoo(5);
            Console.WriteLine(result);
        }
    }
}