using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Class4
    {
        public static void Op(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j<a[i]; j++)
                {
                    if(j*j == a[i])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine("expected op is -------------------!");
            Class4.Op(arr);


        }
    }
}
