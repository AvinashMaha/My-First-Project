using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_6
{
    class Max_Array
    { //3.	WAP to print maximum in rowwise in 2D array. Means
      //e.g. arr[][] {{22, 31, 9}, {12, 25, 16}} output is: 31 and 25.
       static void maxraw(int[,] b)
       {
            for (int i = 0; i < b.GetLength(0); i++)        //outer loop
            {
                int max = b[i, 0];
                for (int j = 0; j < b.GetLength(1); j++)     //iner loop
                {
                    if (max < b[i, j])
                    {
                        max = b[i, j];
                    }
                    Console.Write(b[i, j] + "  ");
                }
                Console.Write("Max Element From Raw is " + max);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = { { 22, 31, 9 }, { 12, 25, 16 } };
            maxraw(a);
        }
    }
}
