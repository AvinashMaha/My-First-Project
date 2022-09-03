using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.VIMP_pracrice_Prorigo
{
    class Multi_Without_OP
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i = 1; i<=n; i++)
            {
                sum = sum + m;
            }
            Console.WriteLine(sum);
        }
    }
}
