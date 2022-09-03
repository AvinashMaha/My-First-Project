using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Remove_Duplicates
    {
        static void Main(string[] args)
        {
            string nm = "Avinash";
            string s2 = "";
           /* bool b = true;
            Console.WriteLine(!b)*/;
            foreach(char c in nm)
            {
                if (!s2.Contains(c))
                {
                    s2 = s2 + c;
                }
               
            }
            Console.WriteLine(s2);

        }
    }
}
