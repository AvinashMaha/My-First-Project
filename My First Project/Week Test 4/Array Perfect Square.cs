using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{//to display all perfect square number in array
    class Q9
    {
        public static void Square(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j<a[i];j++)
                {
                    if (j*j ==a[i])
                    {
                        Console.WriteLine(a[i]);
                        //break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            Console.WriteLine("Array is....................");
            Console.WriteLine(string.Join(" ", arr));
            Q9.Square(arr);
        }
    }
}
