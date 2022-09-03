using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Touple
{
    class Calculater
    {
        /* static Tuple<int, int> calculate(int a, int b)
         {
             int sum = a + b;
             int prod = a * b;
             return Tuple.Create(sum, prod);
         }*/
        static (int, int, string) Calculate(int a, int b)
        {
            int sum = a + b;
            int prod = a * b;
            return (sum, prod, "Heloo");
        }
        static void Main(string[] args)
        {
            // Tuple<int, int> t = Calculate(12, 3,"Heloo");
            var (Add, Multipl, msg) = Calculate(8, 3);
            Console.WriteLine(Add);
            Console.WriteLine(Multipl);

            /* Console.WriteLine(t.Item1);
             Console.WriteLine(t.Item2);*/
        }
    }

    class Arithmetic
    {
        public static void Arithmetic_Progression(int t2, int t3, int n)
        {
            int diff = t3 - t2;
            int t4 = t3;

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

    class LargestSubarray
    {//arr={1,1,0,0,0,0,1,1,0,1}
     //{1,1}
     //{1,1,0}
     //{1,1,0,0}
     //{1,1,0,0,0,0,1}
        static public int largestSubarray(int[] arr)
        {

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int z = 0, one = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 1)
                        one++;
                    else
                        z++;

                    if (z == one)
                    {
                        if (max < (j - i + 1))
                            max = j - i + 1;
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int max = largestSubarray(new int[] { 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 });
            Console.WriteLine(max);
        }
    }
}


