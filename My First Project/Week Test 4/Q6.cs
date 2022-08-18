using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    class Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the Array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < arr.Length; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        size--;
                        j--;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Newdelete
    {
        static void Main(string[] arg)
        {
            int[] arr = new int[10];
            int num;
            int i, j, k;
            Console.WriteLine("Enter size of the array: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (k = j; k < num; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        num--;
                        j--;
                    }
                }
            }
            Console.WriteLine("Array elements after deleting duplicates :");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
