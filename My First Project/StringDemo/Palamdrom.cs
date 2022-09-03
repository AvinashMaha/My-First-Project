using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Palandrom
    { 
        //Madam ---------> Madam
        //Nitin -----------> Nitin
        public static string Reverse(string s)
        {
            s = s.ToLower();
            s = s.ToUpper();
            string s1 = "";      //set a temporory string having 0 space
            for (int i = s.Length-1; i>=0; i--)
            {
                s1 = s1 + s[i];            //accessing in an empty space in reverse manner
            }
            return s1;
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string name");
            string name = Console.ReadLine();
            
            string s2 = Reverse(name);
          
            if (name == s2)
            {
                Console.WriteLine("it is palandrom");
            }
            else
            {
                Console.WriteLine("it is not palandrom");
            }
        }
    }
}
