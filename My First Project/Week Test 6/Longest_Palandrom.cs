using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_6
{  //1.	Write a Program to find out longest palindrome in a given string?
    class Longest_Palandrom
    {

        static bool isPalandrome(string s)
        {
            string s1 = " ";
            s.ToUpper();
            s.ToLower();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
            if (s == s1)
                return true;
            else
                return false;
        }
            
        static void Main(string[] args)
        {
            string str1 = "Nitin learns Malayalam and  says May I come in Madam";
            string[] arr = str1.Split(" ");
            string smax = "";
            for(int i =0; i<arr.Length; i++)
            {
               if(isPalandrome(arr[i]))
                {
                    if(smax.Length<arr[i].Length)
                    {
                        smax = arr[i];
                    }
                }
                
            }
            Console.WriteLine("Longest Palindrome :"+smax);
        }
    }
}



