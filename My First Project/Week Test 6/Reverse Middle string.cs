using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_6
{
    class Reverse_Middle_string
    { //5.	Reverse middle words of a string 
      // Input: Hi how are you students 
      //Output: Hi woh era uoy students
        static string ReverseMtd(string s)
        {
            string rev = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
                
                
            }
            return rev;
        }

        static void m1(string n)
        {
            int i1 = n.IndexOf(' ');
            int i2 = n.LastIndexOf(' ');
            string mid = n.Substring(i1, i2 - i1);
            string[] a = mid.Split(" ");
            string s = n.Substring(0, i1);
            for(int i=0;i<a.Length;i++)
            {
                s = s + ReverseMtd(a[i])+" ";
            }

            s = s + n.Substring(i2);
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            string str1 = "My name is Avinash and i live in Pune";
            m1(str1);
            string []ar = str1.Split(" ");

           /* Console.WriteLine("My split words are");
            string n = ar[0] + " ";*/
            /*for (int i = 1; i < str1.Length-1; i++)
            {
               // n =n+ ReverseMtd(ar[i])+"";
               
            }*/
           // n = n + ar[ar.Length - 1];
          //  Console.WriteLine(n);
        }
    }
}
