using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.WhatsUp_Array
{
    //Reverse the array itself ;
    class Q7
    {
        public static void Reverse(int[] b)
        {
            foreach (int c in b)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("-------------Reverse char is --------------");
            for(int i = b.Length-1;i>=0;i--)
            {
                Console.WriteLine(b[i] + " ");
            }
        }

        static void Main(String[] args)
        {
            int[] a = { 3, 90, 45, 29, 37, 78 };
            Q7.Reverse(a);
        }
    }
}
