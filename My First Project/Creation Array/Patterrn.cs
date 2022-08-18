using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class Patterrn
    {
        public static void OuterElement(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(String[] args)
        {
            int[,] arr = new int[4, 4];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i<arr.GetLength(0);i++)
            {
                for (int j = 0; j<arr.GetLength(1);j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                   
                }
            }
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++) 
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();

                Patterrn.OuterElement(arr);
            }
        }
    }
}
