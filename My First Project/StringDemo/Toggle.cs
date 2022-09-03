using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class ToggleDemo
    {
        static string Toggle(string str)
        {
            string t = " ";
            foreach(char c in str)
            {
                if (char.IsUpper(c))
                {
                    char ch = char.ToLower(c);
                    t = t + ch;

                }
                if (char.IsLower(c))
                {
                   char ch = char.ToUpper(c);
                    t = t + ch;
                }
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
         //   string s = "Avinash Mahadevkar ";
            string togglestr = Toggle(name);
            Console.WriteLine(togglestr);
        }
    }
}
