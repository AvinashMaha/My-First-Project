using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class UpperMatrix
    {
        static void Main(String[] args)
        {
            int[,] a = new int[5, 5];
           // char[,] a = new char[5, 5];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    if (i <= j)
                    {
                      //  Console.WriteLine("Enter element");
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                    Console.WriteLine();
                }
            }
                Console.WriteLine("--------------------------------------");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
