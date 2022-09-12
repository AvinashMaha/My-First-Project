using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class Missing_Num
    {
        static int MissingNo(int[] a, int n)
        {
            int i, total = 1;

            for (i = 2; i <= (n + 1); i++)
            {
                total = total+i;
                total = total -a[i - 2];
            }
            return total;

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 6, 7, };
            int n = arr.Length;
            int ans = MissingNo(arr, n);
            Console.WriteLine(ans);
        }
    }
}
