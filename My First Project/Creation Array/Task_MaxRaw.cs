using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class Task_MaxRaw
    {
        public static void MaxfFromRaw(int[,]b)
        {
            for(int i = 0; i < b.GetLength(0); i++)        //outer loop
            {
                int max = b[i, 0];
               for(int j = 0; j < b.GetLength(1); j++)     //iner loop
               {
                    if(max < b[i, j])
                    {
                        max = b[i, j];
                    }
                    Console.Write(b[i, j]+"  ");
               }
                Console.Write("Max Element From Raw is " + max);
                Console.WriteLine();
            }
        }       
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------------------------------");
            Task_MaxRaw.MaxfFromRaw(a);

        }
    }
}
