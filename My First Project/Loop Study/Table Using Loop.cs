using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class Table_Using_Loop
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "X" + i+"=" + n * i);
            }
           
            
        }
    }
}
