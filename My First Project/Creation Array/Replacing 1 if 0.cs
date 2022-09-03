using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Creation_Array
{
    class Q10
    {
        public static void Replace(int[] b)
        {
            int j = 1;
            foreach(int c in b)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("After replacing 0 is :-");

            for(int i = 0; i<b.Length; i++)
            {
                if (b[i] == 0)
                {
                    b[i] = j;
                }
                Console.Write(b[i] + "     ");
            }
            

          
        }
        static void Main(String[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Q10.Replace(a);
        }
    }
}
