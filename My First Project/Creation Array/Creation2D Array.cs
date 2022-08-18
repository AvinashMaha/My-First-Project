using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class Creation2D_Array
    {
        static void Main(String[] args)
        {
           /* int[,] arr = { { 4, 6, 2 },
                         {7,2,9},
                         {9,5,1}*/
          //  };
            int[,] a= new int[3, 3];
            /*  a[0, 0] = 3;
              a[0, 1] = 7;
              a[1, 0] = 4;
              a[1, 1] = 2;*/
            Console.WriteLine("Enter array elements");
            for(int i = 0; i<a.GetLength(0);i++)
            {
                for (int j =0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i<a.GetLength(0);i++)
            {
                for (int j = 0; j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
         for(int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j =0; j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i, j] + "\n ");
                }
            }
        }

    }
}
