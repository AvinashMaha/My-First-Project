using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.VIMP_pracrice_Prorigo
{
    class Max_from_array
    {
        static int Max(int[]b)
        {
            foreach(int x in b)
            {
                Console.WriteLine(x);
            }
            int max = 0;
            for(int i = 0; i<b.Length; i++)
            {
                if(max < b[i])
                {
                    max = b[i];
                }
            }
           
            return max;
        }
        static void Main(string[] args)
        {
            int[] a = { 12, 15, 11, 9, 19, 22, 43 };
            int ans = Max(a);
            Console.WriteLine($"max element is {ans}");
            
        }
    }
}
