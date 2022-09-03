using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Class8
    {

        static void NearrestElement(int[] n)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i<n.Length; i++)
            {
                num = n[i] - num;

                if(n[i] > num)
                {

                }
            }
            
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 43, 56, 34, 78, 21 };
           
            NearrestElement(a);
        }
    }
}
