using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Identify_Prime
    {
        public static void Prime(int[] n)
        {
           /* foreach (int x in n)
            {
                Console.WriteLine(x);
            }*/
            for (int i = 0; i < n.Length; i++)
            {
                int count = 0;
                for (int j = 2; j < n[i]; j++)
                {
                    if (n[i] % j == 0)
                    {
                        count++;
                    }
                    
                }
                Console.WriteLine(count);
                if (count == 0)
                {
                    Console.WriteLine(n[i]);
                }
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
            {
                int[] a = { 11, 13, 15, 16 };
                Prime(a);
            }    
    }
}

