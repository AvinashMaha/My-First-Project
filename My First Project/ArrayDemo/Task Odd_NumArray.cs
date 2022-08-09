using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Task_Odd_NumArray
    {
        public int OddSum(int[]b)
        {
            int count = 0 ,  sum = 0;
            for(int i = 0; i<b.Length; i++)
            {
               
                if (b[i] % 2 != 0)
                {
                    
                    Console.WriteLine("Odd number is "+b[i]);
                    sum = sum + b[i];
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total numbers are "+count);
            Console.WriteLine("Sum of odd numbers are " + sum);
            
            return count;   
        }



        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Task_Odd_NumArray t = new Task_Odd_NumArray();
            t.OddSum(a);
        }

    }
}

