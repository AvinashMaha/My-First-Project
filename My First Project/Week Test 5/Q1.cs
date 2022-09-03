using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_5
{ //1.	Merging elements of two different arrays alternatively in third array
    class Q1
    {
        public static void Merging(int[]a , int[]b , int[] merge)
        {
            int counter = 0;
            for (int i = 0; i < merge.Length; )
            {
                if(counter < a.Length)
                {
                    merge[i] = a[counter];
                    i++;
                }
                if (counter < b.Length)
                {
                    merge[i++] = b[counter];

                }
                counter++;
            }
            Console.WriteLine(string.Join("  ", a));
            Console.WriteLine("-----------------");
            Console.WriteLine(string.Join("  ", b));
            Console.WriteLine("-----------------");
            for (int i = 0; i < merge.Length; i++)
            {
                Console.Write(merge[i] + "  ");
            }
        }
        static void Main(String[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] b = { 11, 22, 33, 44 };
            //   1,11,2,22,3,33,4,44,5,6,7,8 ...!
            int[] c = new int [a.Length + b.Length];
            Q1.Merging(a, b, c);
        }
    }
}
