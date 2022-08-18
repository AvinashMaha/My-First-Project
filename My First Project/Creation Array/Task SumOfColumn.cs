using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class SumOfColumn
    {
        public static void ColumnSum(int[,]b)
        {
            for(int i=0; i < b.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    sum = b[j, i]+sum;
                    Console.WriteLine(b[j,i]+" ");
                }
                Console.WriteLine("Sum of column is : " + sum);
                Console.WriteLine();
            }
        }

         static void Main(String[] args)
         {
            int[,] a = new int[4, 4];
            Console.WriteLine("Enter array element");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------");
            SumOfColumn.ColumnSum(a);
         }
    }
}
