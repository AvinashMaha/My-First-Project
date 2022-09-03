using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Recursion
{
    class Recursion_Demo 
    {
        /* static public void m1(int x)
         {
             Console.WriteLine("in m1");
             if (x <= 3)
             {
                 m1(x + 1);
             }
             Console.WriteLine("m1 ends");

         }

         static void Main(string[] args)
         {
             m1(1);     
         }*/

        public static int fact(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                return n * fact(n - 1);
            }
        }
        static void Main(string[] args)
        {
           int result =  fact(3);
            Console.WriteLine(result);
        }
    }
}
