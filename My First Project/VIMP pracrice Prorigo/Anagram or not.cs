using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.VIMP_pracrice_Prorigo
{
    class Anagram_or_not
    {
        static void Main(string[] args)
        {
            string s1 = "Silent";
            string s2 = "Listen";

            s1 = s1.ToLower();
            s2 = s2.ToLower();

            foreach(char c in s1)
            {
                int idx = s2.IndexOf(c);
                if(idx != -1)
                {
                    s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);
                }
                else
                {
                    break;
                }
            }
            if(s2.Length ==0)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }

        }
    }
}
