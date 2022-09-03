using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_6
{
    class Remove_Perticu_Str
    {    //removing in and display
        static void Main(string[] args)
        {
            string str1 = "india is great nation";
            string str2 = "in";
            string str3 = " ";
            for(int i = 0; i<str1.Length; i++)
            {
                if(str1[i]!= 'i'&& str1[i] != 'n')
                {
                    str3 = str3 + str1[i];
                }
            }
            Console.WriteLine(str3);
        }
    }
}
