using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class NestedDemo1
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Enter the passsing year");
            int yr = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percentage");
            int per = int.Parse(Console.ReadLine());

            if (yr == 2021)
            {
                if (per > 60)
                {
                    Console.WriteLine("Student is allowed for Interview ");
                }
                else
                {
                    Console.WriteLine("Not allowed");
                }
            }
            else
            {
                Console.WriteLine("Student is not allowed ");
            }
        }
    }
}
