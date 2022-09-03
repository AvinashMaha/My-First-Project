using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Prorigo_Practice
{
    class Anagorium
    { //2.	Write a Program to check if two strings are anagrams of each other?
        static void Anagramstr(string s1, string s2)
        {
            // God ------Anagram------> Dog        
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool isanagram = true;
           
                foreach (char ch in s1)
                {
                    int idx = s2.IndexOf(ch);
                    if (idx != -1)
                    {

                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);
                    }
                    else
                    {
                        isanagram = false;
                        break;
                    }
                }
                if (isanagram && s2.Length == 0)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("not ");
                }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st word");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter 2nd word");
            string n2 = Console.ReadLine();
            Anagorium.Anagramstr(n1, n2);
        }
    }
}
