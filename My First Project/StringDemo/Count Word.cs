using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Count_Word
    {
        public static int Occurance(string b , char c)
        {
            int counter = 0;
            for (int i = 0; i<b.Length; i++)
            {
                
              if(b[i] == c)
                {
                    counter++;
                }

                
            }
            //Console.WriteLine(c + " - " + counter);
            return counter;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word :-");
            string name = Console.ReadLine();
            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            int a = Occurance(name, ch);
            Console.WriteLine(a);
           // Count_Word.Occurance(name, ch);

        }
    }
}
