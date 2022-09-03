using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    // Create an array of integer and count the number of even and odd element form array..
    class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int even = 0;
            int odd = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {                 
                    even++;
                }
                else
                {
                  odd++;
                 
                }
            }           
            Console.WriteLine("Even count=" + even);
            Console.WriteLine("Odd count=" + odd);
        }
    }
}
