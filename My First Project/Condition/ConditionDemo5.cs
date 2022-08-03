using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class ConditionDemo5
    {
        static void Main(String[] arg)
        {
            Console.Write("Enter any Character = ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Alfabet");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Alfabet");
            }
            else if(ch >= '0' && ch <= '9')
            {
                Console.WriteLine("It is a Digit");
            }
            else
            {
                Console.WriteLine("It is a symbol");
            }



        }
    }
}
