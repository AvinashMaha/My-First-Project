using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class ArrayCreation
    {
        static void Main(String[] args)
        {
          //  int x = 10;
            //1.way

            int[] arr = { 5, 34, 78, 1 };
            // arr[4] = 88;


            //2 using new keyword : --->
            int[] a = new int[5];

            /*  a[0] = 23;
              a[1] = 3;
              a[2] = 13;
              a[3] = 30;
              a[4] = 53;*/

            Console.WriteLine("Enter the array element");         // for loop array element 
            for(int i = 0; i <= a.Length-1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------Display Array----------------------------");
            //way 1 
            for(int i = 0; i < a[i]; i++)                        // array element
            {
                Console.WriteLine(a[i]+" ");
            }
            //way 2
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }
            //way 3 
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
