using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_6
{
    class Revese_a_string
    {
        static void Main(string[] args)
        {
            string str1 = "India is my country";
            Console.WriteLine("Original : "+str1);
            string str2 = "";
            for(int i = str1.Length - 1; i >= 0; i--)
            {
                if (str1[i] != ' ') 
                {
                    str2 = str2 + str1[i];
                }
            }
            //Console.WriteLine(str2);
            string str3 = "";
            int j = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i] != ' ')
                {
                    str3 = str3 + str2[j];
                    j++;
                }
                else
                {
                    str3 = str3 + ' ';
                }
            }
            Console.WriteLine(str3);
        }
    }
}
