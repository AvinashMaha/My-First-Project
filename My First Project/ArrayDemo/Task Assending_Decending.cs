using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Task_Assending_Decending
    {
        public static int[] AssenDessen(int[]a)
        {
            for (int i = 0; i<a.Length;i++)
            {
                for(int j = 0; j<(a.Length)/2; j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }              
                for (int x = ((a.Length)/2); x <(a.Length); x++)
                {
                    if (a[i] > a[x])
                    {
                        int temp = a[i];
                        a[i] = a[x];
                        a[x] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", a));
                
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array element");
            for (int i = 0; i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Task_Assending_Decending.AssenDessen(a);
            
        }
    }
}
