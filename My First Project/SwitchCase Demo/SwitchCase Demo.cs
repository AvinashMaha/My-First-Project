using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class SwitchCase_Demo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number between 1 to 5");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default: Console.WriteLine("Invalid input");
                    break;


            }
        }
    }
}