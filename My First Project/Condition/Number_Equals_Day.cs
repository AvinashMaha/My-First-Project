using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class Number_Equals_Day
    {
        static void Main(String[] args)
        {
            int num;
            Console.Write("Enter any no : ");
            num = int.Parse(Console.ReadLine());
          //  num = Convert.ToInt32(Console.ReadLine());
          if(num ==1)
            {
                Console.WriteLine("It is a Sunday");

            }
            else if (num == 2)
            {
                Console.WriteLine("It is a Monday");

            }
            else if (num == 3)
            {
                Console.WriteLine("It is a Tuesday");

            }
            else if (num == 4)
            {
                Console.WriteLine("It is a Wenesday");

            }
            else if (num == 5)
            {
                Console.WriteLine("It is a Thursday");

            }
            else if(num == 6)
            {
                Console.WriteLine("It is a Friday");
            }
            else if(num == 7)
            {
                Console.WriteLine("It is a Saturday");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
