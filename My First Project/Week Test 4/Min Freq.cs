using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{ //minimum freq of char of an array -------------->
    class Q3
    {
        public static char minimumfrequency(char[] a)
        {
            char min = a[0];
            int freq = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    freq = 1;
                }
                else if (a[i] == min)
                {
                    freq++;
                }
                Console.WriteLine(freq);
            }
           
            return min;

        }
        static void Main(String[] args)
        {

            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };
            Q3.minimumfrequency(arr);
        }
    }
}
