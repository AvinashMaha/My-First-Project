using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_5
{
    class Q5
    { //	Write a program to separate zeros from non-zeros
       
        static void Main(string[] args)
        {
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            Console.WriteLine(string.Join(" ", a));
            int j = 0; 
            for(int i = 0; i < a.Length; i++)
            {
            if(a[i] !=0)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j++;
                }
            }
            Console.WriteLine("----------------------");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}
