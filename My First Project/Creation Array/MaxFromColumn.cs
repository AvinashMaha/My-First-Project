using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{           //max element from column
    class MaxFromColumn
    {
        public static void ColumnMax(int[,]a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for(int j =0; j < a.GetLength(1); j++)
                {
                    if (max<a[j,i])
                    {
                        max = a[j, i];
                    }
                    Console.WriteLine(a[j,i]+" ");                  
                }
                Console.WriteLine("Col Max = " + max);
                Console.WriteLine();
            }
            
        }


        static void Main(String[] args)
        {
            int[,]arr = { { 5, 6, 2 }, { 8, 7, 3 }, { 2, 56, 12 } };
            MaxFromColumn.ColumnMax(arr);
        }
    }
}
