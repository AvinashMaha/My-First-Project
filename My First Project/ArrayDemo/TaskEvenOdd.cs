using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class TaskEvenOdd
    {
        public static void EvenOdd(int[]b)
        {
            int j=0,k=0;
            int[] Even = new int[b.Length];
            int[] Odd = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 ==0)
                {
                    Even[j] = b[i];
                    j++;
                }
                else
                {
                    Odd[k] = b[i];              
                    k++;                    
                }
            }
            Console.WriteLine("Even no : ");
            for (int i = 0; i<j; i++)
            {
                Console.WriteLine(" " + Even[i]);       
            }
            Console.WriteLine("Odd no : ");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(" " + Odd[i]);
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Array element");
            int[] a = new int[size];
            for (int i = 0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            TaskEvenOdd.EvenOdd(a);
        }
    }
}
