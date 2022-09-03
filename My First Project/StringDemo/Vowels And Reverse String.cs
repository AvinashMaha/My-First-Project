using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s1 = "Thinkquotient";
           /* string s2 = s1.ToLower();
            string s3 = s1.ToLower();*/
            Console.WriteLine("Total length are "+s1.Length); //13
                                          
            int vowel = 0;
            int consonent = 0;
            s1 = s1.ToLower();
            for (int i = 0; i<s1.Length;i++)
            {
                if(s1[i] =='a'|| s1[i] =='e'||s1[i] =='i' ||s1[i] =='o' ||s1[i] == 'u')
                {
                    vowel++;
                }
                else
                {
                    consonent++;
                }
            }
            Console.WriteLine("Vowels are" + vowel);
            Console.WriteLine("Consonent" + consonent);

            for(int i = s1.Length-1; i >= 0; i--)
            {
                Console.Write(s1[i] +" ");
            }

        }
    }
}
