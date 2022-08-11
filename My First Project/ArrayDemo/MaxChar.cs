using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class MaxChar
    {
        public static char MaxValue(char[]ch) 
        {
            char max = ch[0];
            foreach (int x in ch)
            {
                Console.WriteLine((char)(x) + " = "+x);
            }
            for (int i = 0; i<ch.Length; i++)
            {
                if(max < ch[i])
                {
                    max = ch[i];
                }
            }
            return max;
        }
        static void Main(String[] args)
        {
            char[] c = { 'q', 'e', 'r', 'g', 'A' };

            char maxvalue = MaxChar.MaxValue(c);
            Console.WriteLine("Max values are " + maxvalue);
        }
    }
}
