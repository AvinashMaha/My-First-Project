using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Task_Freq
    {
        static void Freq(string s)
        {

             s = s.ToLower();
            for (int i = 0; i<s.Length; i++)
            {
                int counter = 1;
                bool isvisited = false;
                for(int k = i-1; k >=0; k--)
                {
                    if(s[i] == s[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            counter++;
                        }

                    }
                    Console.WriteLine(s[i] + "-" + counter);
                }
               
            }                   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            string n = Console.ReadLine();
           
           
            Freq(n);
           
            

        }
    }
}
