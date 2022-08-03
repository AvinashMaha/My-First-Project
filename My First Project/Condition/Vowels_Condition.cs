using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class Vowels_Condition
    {
        static void Main(String[] args)
        {
           /* Console.WriteLine("Consider a char");
            char ch = Convert.ToChar(Console.ReadLine());
*/
            /*  if(ch == 'A')
              {
                  Console.WriteLine("It is a Vowel");
              }
              else if (ch == 'E')
              {
                  Console.WriteLine("It is a Vowel");
              }
              else if(ch == 'I')
              {
                  Console.WriteLine("It is a Vowel");
              }
              else if (ch == 'O')
              {
                  Console.WriteLine("It is a Vowel");
              }
              else if (ch == 'U')
              {
                  Console.WriteLine("It is a Vowel");
              }
              else
              {
                  Console.WriteLine("It is a Consonent");
              }*/

            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' | ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }



        }
    }
}
