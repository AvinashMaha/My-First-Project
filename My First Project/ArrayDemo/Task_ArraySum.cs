using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{ 
    class Task_ArraySum
    {
        public int SumNum(int[]b)
        {
            int sum = 0;
            for(int i = 0; i < b.Length; i++)       //condition loop
            {
                sum = sum + b[i];
            }

            Console.WriteLine($"Total Sum is {sum}");
            return sum;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of a array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());  //element loop
            }
            Task_ArraySum t = new Task_ArraySum();
            t.SumNum(a);
            //int sum = t.SumNum(a);
           
        }
    }
}
