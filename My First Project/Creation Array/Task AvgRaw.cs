using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{           //calculating Avg of Each raw -------->
    class Task_AvgRaw
    {
        public static void AvgOfRaw(int[,] b )
        {
            for(int i = 0; i < b.GetLength(0); i++)   //outer loop
            {
                int sum = 0;
                int count = 0;
                for(int j = 0; j < b.GetLength(1); j++)  //inner loop
                {
                    sum = sum + b[i, j];
                    Console.Write(b[i, j] + " ");
                    count++;
                }
                Console.Write("Sum of Raw is " + sum);
                double Avg = sum / count;
                Console.WriteLine("Avg is " + Avg);
                Console.WriteLine();
            }
        }
        static void Main(String[] args)
        {
            int[,] a = new int[3, 3];
            for (int i = 0; i<a.GetLength(0);i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------------------");
            Task_AvgRaw.AvgOfRaw(a);


        }
    }
}
