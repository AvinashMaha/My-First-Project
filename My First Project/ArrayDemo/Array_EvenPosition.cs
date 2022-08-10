using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Array_EvenPosition
    {
        public void Position(int[]b)
        {
            int[] arr = new int[b.Length];
            for (int i = 0; i<b.Length; i=i+2)
            {
                arr[i] = b[i];
            }
            Console.WriteLine("Even position is");
            for(int j =0; j < arr.Length; j++)
            {
                if(arr[j] == 0)
                {
                    continue;
                }
                Console.WriteLine(arr[j]);
            }
        }
            
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array element");
            for(int i = 0; i <a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Array_EvenPosition e = new Array_EvenPosition();
            e.Position(a);

        }
    }
}
