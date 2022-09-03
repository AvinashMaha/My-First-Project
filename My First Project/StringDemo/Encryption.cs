using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Encryption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string n = Console.ReadLine();
            Console.WriteLine("Enter move ");
            int m = int.Parse(Console.ReadLine());
            n = n.ToUpper();
           // n = n.ToLower();
            //for uppercase
           /* foreach (char c in n)
            {
                int nextchar = c + m;
                if (c > 122)
                {
                    nextchar = nextchar - 26;
                }
                Console.Write((char)(nextchar));
            }*/

            //for lowercase

          /*  foreach (char ch in n)
            {
                //YASH
                //Y = 89+5 = 94-26= 68 
                int newchar = ch + m; //AVINASH ------> A + 4;
                if (newchar > 90)
                {
                    newchar = newchar - 26;
                }

                Console.Write((char)newchar);
            }
            Console.WriteLine();*/

            //Another way to encryption ------------->
            /* foreach (char ch in n)
             {
                 int newchar = ch + m;
                 if ((char.IsUpper(ch)) && newchar > 90 || char.IsLower(ch) && newchar < 122)
                 {
                     newchar = newchar - 26;
                 }
                 Console.Write((char)(newchar));
             }*/


        }
    }
}
