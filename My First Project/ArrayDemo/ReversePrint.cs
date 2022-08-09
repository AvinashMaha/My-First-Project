using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class ReversePrint
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 33, 22, 55 };
            for(int i = a.Length-1; i >= 0; i--)    // indexing members
            {
                Console.Write(a[i]+ " ");
            }
        }
    }
}
