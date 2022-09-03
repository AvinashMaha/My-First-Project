using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Unique_element
    {
        static void Main(String[] args)
        {
            int i, j , k;
            Console.WriteLine("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }       

            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                       for (k = j; k < size; k++)
                       {
                          arr[k] = arr[k + 1];
                       }
                       size--;

                    }
                }
            }
            Console.WriteLine("Array elements after deleting duplicates :");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

