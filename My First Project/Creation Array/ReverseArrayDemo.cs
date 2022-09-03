using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.WhatsUp_Array
{
    //   Reverse array elements ---------->
    class ReverseArrayDemo
    {
        public static int[] Reverse(int[]b)
        {
            int j = b.Length - 1;
            for(int i = 0; i < b.Length/2; i++)
            {
                int temp = b[i];
                b[i] = b[j];
                b[j] = temp;
                j--;
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(string.Join(" \n", b));

            return b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Array elements ");
            for(int i =0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", a));
            ReverseArrayDemo.Reverse(a);
          
        }
    }
}
