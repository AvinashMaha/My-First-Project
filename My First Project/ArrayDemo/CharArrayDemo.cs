using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the size off a array");
             int size = int.Parse(Console.ReadLine());    // about indexing
             char[] ch = new char[size];
             Console.WriteLine("Enter the char elements");   // about char elements
             for (int i = 0; i<=ch.Length;i++)
             {
                 ch[i] = Convert.ToChar(Console.ReadLine());

             }
             Console.WriteLine("--------------------------------");*/
            char[] ch = { 'a', 't', 'i', '#', '$' ,'f' };
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }

            //Console.WriteLine(string.Join(" "+ch));
        }
    }
}
