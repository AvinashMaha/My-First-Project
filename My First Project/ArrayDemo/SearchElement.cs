using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class SearchElement
    {
        public static bool FindElement(int[]a,int n )
        {
            bool ispresent = false;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == n)
                {
                    ispresent = true;
                    break;
                }
            }
            return ispresent;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter array element");
            for (int i = 0; i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter element to search");
            int num = int.Parse(Console.ReadLine());

            bool iselementFound = SearchElement.FindElement(a, num);
            if (iselementFound ==true)
            {
                Console.WriteLine("Element present");
            }
            else
            {
                Console.WriteLine("element not present");
            }

        } 

    }
}
