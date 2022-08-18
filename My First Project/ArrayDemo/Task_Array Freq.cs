using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Task_Array_Freq
    {
        public static void FreqElement(int[]b)
        {
            int num = 2;
            int count = 0;
            for (int i=0;i<b.Length;i++)
            {
               
                if (num == b[i])
                {
                    count++;
                }
               

            }
            Console.WriteLine("frequmcy is" + count);
            /*  for(int i= 0; i<b.Length; i++)
              {
                 bool islocated = true;


                 if (islocated == false)
                 {
                     for (int j = i + 1; j < b.Length; j++)
                     {
                         if(b[i] == b[j])
                         {
                             count++;
                         }
                     }
                     if (count == 1)
                     {
                         Console.WriteLine(b[i] + " - " + count);
                     }
                 }*/

            // }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Task_Array_Freq.FreqElement(a);


        }
    }
}
