using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class PowerCalculationcs
    {
        static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the base number");
                int base_number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the exponent number");
                int exponent = int.Parse(Console.ReadLine());

                int power = 1;
                int i = 1;
                while (i <= exponent)
                {
                    power = power * base_number;
                    i++;
                }
                Console.WriteLine(power);
            }
        }
    }
}
