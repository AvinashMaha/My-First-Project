using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Task_Minchar
    {
        public static char FindMinimum(char[] ch)
        {
            char min = ch[0];
            foreach(int x in  ch)
            {
                Console.WriteLine((char)(x)+" "+x);
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (min > ch[i])
                {
                    min = ch[i];
                }
            }
            return min; 
        }
        static void Main(String[] args)
        {
            char[] c = { 'a', 'g', 's', 'd', 'W', 'T' };
            char minvalue =Task_Minchar.FindMinimum(c);
            Console.WriteLine("Min char from array : " + minvalue);

        }
    }
}
