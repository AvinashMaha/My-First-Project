using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Array_CharReverse
    {
       public void Reverse()
        {
            Console.WriteLine("Enter size of an array");
            int size = int.Parse(Console.ReadLine());
            char[] c = new char[size];
            Console.WriteLine("Enter the char elements");

            for(int i = 0; i<c.Length; i++)      // index loop -------->
            {
                  c[i]  = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("--------Using foreach Loop------------------");

            foreach(char b in c)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("---------------String Join----------------------");

            Console.WriteLine(string.Join(" \n" , c));
            
            Console.WriteLine("--------------Reversr Char -----------------");
            for (int i = c.Length-1; i >= 0; i--)
            {
                Console.WriteLine(c[i] + " ");
            }


        }

        static void Main(String[] args)
        {
            Array_CharReverse a = new Array_CharReverse();
            a.Reverse();


        }
    }
}
