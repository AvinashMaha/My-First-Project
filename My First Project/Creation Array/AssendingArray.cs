using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class AssendingArray
    {
        // Array elements in asending order ---------->
        public static int[] Mysort(int[] b)
        {
            for (int i = 0; i<b.Length;i++)
            {
               for(int j = i+1; j < b.Length; j++)
                {
                    if (b[i] > b[j])
                    {
                        int temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
              
                }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine(string.Join("\n", b));
            return b;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Array element");
            for (int i = 0;i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            AssendingArray.Mysort(a);

        }
    }
}
