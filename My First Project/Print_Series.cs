using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Print_Series
    { //0,3,8,15,24,35 ________________! 

        static int Series(int n)
        {
            for(int i = 1; i<=n; i++)
            {
                int a = (i * i) - 1;
                Console.Write(a +" , ");
            }
            return n;
        }

        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Series(n);
         

        }
    }
}
