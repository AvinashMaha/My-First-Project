using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Exception_Hnadling
{
    class Ex_Handling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("a = "+a);
            }
            catch(FormatException e)
            {
                Console.WriteLine("pl enter a valid number");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Number to big");
            }
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
