using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class Array_Addition
    {
        public static void ArrayAddition(int[,] a, int[,] b, int[,] sum)
        {

            Console.WriteLine("Enter 1st array element");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {  
                    Console.WriteLine(a[i, j] );
                }               
            }
            Console.WriteLine("Enter 2nd Array element");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {               
                    Console.WriteLine(b[i, j] );
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("Addition of 2 2D arrays are");
            for(int i = 0; i < sum.GetLength(0); i++)
            {
                for(int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + " ");                
                }             
                Console.WriteLine();
            }


        }
            static void Main(String[] args)
            {
                int[,] a = new int[2, 2];
                int[,] b = new int[2, 2];
                int[,] sum = new int[2, 2];

            Array_Addition.ArrayAddition(a,b,sum);
            }
        
    }
}

