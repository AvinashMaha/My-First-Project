using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_5
{
    class Q7
    { // print maximum in rowwise in 2D array. Means 
        // e.g.arr[][] {{22, 31, 9}, {12, 25, 16}        
       // output is: 31 and 25.

        public static void MaxRaw(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i,0];
                int min = a[i, 0];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if(max < a[i, j])
                    {
                        max = a[i, j]; 
                    }
                    Console.WriteLine(a[i, j] + " ");

                     if(min > a[i,j])
                    {
                        min = a[i, j];
                    }
                    Console.WriteLine(a[i, j] + " ");
                  
                }
                Console.WriteLine("Max from raw is " + max);
                
                Console.WriteLine("Min from raw is" + min);
            }
        }  
        static void Main(string[] args)
        {
            int[,] a = { { 22, 31, 9 },{ 12, 25, 16 } };
            Q7.MaxRaw(a);
        }
    }
}
