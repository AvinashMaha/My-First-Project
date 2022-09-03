using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Anagram
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entr 1st word");
            string s1 = Console.ReadLine();
            
            Console.WriteLine("Ente 2nd word");
            string s2 = Console.ReadLine();

            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

/*             char[] a1 = s1.ToCharArray(); //{'r','a','c','e',' ','g','o','d'}
             char[] a2 = s2.ToCharArray(); //{'c','a','r','e'}
*/
            //// string[] a3 = s1.Split(" ");  // {"race","god"} a[3]="" //it reverse the string in an array not a sentense

           /*  Array.Sort(a1);  //'a','c','e','r'
             Array.Sort(a2); // */
            // if(string.Join("",a1)==string.Join("",a2))
            // {
            //     Console.WriteLine("Annagram");
            // }
            // else
            // {
            //     Console.WriteLine("not");
            // }

            // Another Anagram ------------>
            // r a c e
            foreach (char ch in s1) //1
            {   
                //e
                //e index 0
                int idx = s2.IndexOf(ch); //2
                if(idx != -1)
                {
                    //""
                    s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);    
                }
                else
                {
                    break;
                }
            }
            if(s2.Length == 0)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }

            //Another way to anagram --->

           /* bool isanagram = true;
            foreach (char a1 in s1)
            {
                int c1 = 0, c2 = 0;
                foreach(char a1 in s1)
                {
                    if(a1 == ch)
                    {
                        c1++;
                    }
                }
                foreach(char a2 in s2)
                {
                    if(ch == a2)
                    {
                        c2++;
                    }                     
                }
                if(c1 != c2)
                {
                    isanagram = false;
                    break;
                }
            }*/


        }
        

    }
}
