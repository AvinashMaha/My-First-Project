using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Array_EvenPosition
    {
        public void Position(int[]b)
        {
            Console.WriteLine("Even Position : ");
            for (int i = 0; i<b.Length;i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(b[i]);
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
