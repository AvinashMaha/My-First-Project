using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Class0
    {
        static string ReverseMtd(string s)
        {
            string rev = " ";
          
            for (int i = s.Length-1; i>=0; i--)
            {
                rev = rev + s[i];
            }           
            return rev;
        }
        //expected output is - ayanahS seog ot pohsib loohcs
        static void Main(string[] args)
        {
            string s = "Shanaya";       
            string[] sarr = s.Split(" ");
            Console.WriteLine("My split words are");
            for (int i =0; i<sarr.Length; i++)
            {            
                string n = ReverseMtd(sarr[i]);
                Console.WriteLine(n);
            }


            
        }
    }
}
