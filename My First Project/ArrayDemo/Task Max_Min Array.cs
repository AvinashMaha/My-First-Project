using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Task_Max_Min_Array
    {
        public static void Min_Max(int[]a)
        {
            int max = a[0];
            int min =a[0];
            
            for(int i = 0; i<a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("max :" + max +"\n min : " + min);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elememnt");
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           
             Task_Max_Min_Array.Min_Max(arr);
           

        }
    }
}
