using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Replace_Vowels
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
         
            for(int i = 0; i < s.Length; i++)
            {
                char ch = s[i];  
                if(ch == 'a'||ch=='e'||ch =='i'||ch=='o'||ch =='u'||ch=='A'||ch =='E'||ch == 'I')
                {
                    ch =(char)(ch + 1);
                }
                Console.Write(ch);
            }
           

        }
    }
}
