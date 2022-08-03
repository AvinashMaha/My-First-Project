using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class Switch_Day_Number
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the no");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
