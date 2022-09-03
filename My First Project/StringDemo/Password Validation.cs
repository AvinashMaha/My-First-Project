using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Password_Validation
    {
        static void Password(string s)
        {

          if(s.Length >= 8)
            {
                int u = 0, l = 0, d = 0 , g = 0;
                for(int i = 0; i < s.Length; i++)
                {
                    if (char.IsDigit(s[i]))
                    {
                        d++;
                    }
                    else if (char.IsLower(s[i]))
                    {
                        l++;
                    }
                    else if (char.IsUpper(s[i]))
                    {
                        u++;
                    }
                    else if (! char.IsLetterOrDigit(s[i]))
                    {
                        g++;
                    }
                }
                if (d >= 1 && l >= 1  && u >= 1 && g==1)
                {
                    Console.WriteLine("Valid Password");
                }
                else
                {
                    Console.WriteLine( "Invalid Password");
                }
            } 

           
        }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a pasword");
        string name = Console.ReadLine();
            Password(name);
    




    }
}
}
