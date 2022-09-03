using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_5
{
    class Q6
    {
        public static void Reverse(int[ ] a,int[ ]b)
        {
            int k = a.Length - 1;
            for(int i = 0; i<a.Length/2; i++)
            {
                    int temp = a[i];
                    a[i] = a[k];
                    a[k] = temp;
                    k--;
            }
            Console.WriteLine(string.Join(" ", a));

            int j = b.Length - 1;
            for (int i = 0; i < b.Length / 2; i++)
            {
                int temp = b[i];
                b[i] = b[j];
                b[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", b));
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8 };
            Q6.Reverse(a,b);
        }

    }
 }

