using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class SumOfEven
    {
       public int EvenSum(int[] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]%2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum; 
        } 
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the Array Elements");    // elementn loop
            for (int i = 0; i<arr.Length;i++ )
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            SumOfEven e = new SumOfEven(); //object creation
            int sum = e.EvenSum(arr);
            Console.WriteLine("Sum of even no is " + sum);

        }
    }
}
