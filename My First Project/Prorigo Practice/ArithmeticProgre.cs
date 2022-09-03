using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Prorigo_Practice
{
    class Arithmetic
    {
        public static void Arithmetic_Progression(int t1, int t2, int n)
        {
            int diff = t2 - t1;
            int t4 = t2;

            for (int i = 4; i <= n; i++)
            {
                t4 = t4 + diff;
            }
            Console.WriteLine(t4);
        }
        static void Main(string[] args)
        {
            Arithmetic_Progression(3, 7, 8);
        }


    }

        class Ari
        {
        static void AriPro(int t1  , int t2 ,int n)
        {
            int diff = t2 - t1;
            int t3 = t2;
            for(int i = 3; i <= n; i++)
            {
                t3 = t3 + diff;
            }
            Console.WriteLine(t3);
        }
        static void Main(string[] args)
        {
            AriPro(1, 3, 10);
        }
    }
    
}
