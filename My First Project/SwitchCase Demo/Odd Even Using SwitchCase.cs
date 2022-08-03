using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class Odd_Even_Using_SwitchCase
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num %2 )
            {
                case 0: Console.WriteLine(num + " is even number");
                    break;
                default: Console.WriteLine(num + " is odd number");
                    break;
            }

           /* switch (num % 2 == 0)
            {
                case true: Console.WriteLine("even");
                    break;
                default: Console.WriteLine("odd");
                    break;
            }*/

        }

    }
}
