using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class Display_Odd_Numbers_1to20
    {
        static void Main(String[] args)
        {
            Console.WriteLine("List of odd numbers are :-");
            Console.WriteLine("-----------------------");
            for(int i =1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            
        }
    }
}
