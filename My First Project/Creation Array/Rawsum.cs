using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    //summation of raws
    class Rawsum
    {
        public static void SumOfRaw(int[,]a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("   sum _ "+sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 6, 7, 3 }, { 2, 8, 1 }, { 5, 4, 9 } };
            Rawsum.SumOfRaw(arr);
        }
    }
}
