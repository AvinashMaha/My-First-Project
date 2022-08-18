using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class MergeArray
    {
        public static void JoinArray(int[] a, int[] b, int[] merge)
        {
            int m = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool ispresent = false;
                for (int k = m-1; k >= 0; k--)
                {
                    if (merge[k] == a[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    merge[m] = a[i];
                    m++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool ispresent = false;
                for (int k = m - 1; k >= 0; k--)
                {
                    if (merge[k] == b[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    merge[m] = b[i];
                    m++;
                }
            }
            Console.WriteLine(string.Join("  ", a));
            Console.WriteLine(string.Join("  ", b));
            for (int i = 0; i < m; i++)
            {
                Console.Write(merge[i] + "  ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 4, 5, 8 };
            int[] b = { 7, 8, 4, 9, 2 };
            int[] c = new int[a.Length + b.Length];
            JoinArray(a, b, c);
        }
    }
}
