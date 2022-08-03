using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class SwitchDemo4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();

            switch (city)
            {
                case "pune": Console.WriteLine("IT city");
                    break;
                case "mumbai":
                    Console.WriteLine("IT city");
                    break;
                case "benglore":
                    Console.WriteLine("IT city");
                    break;
                case "chennai":
                    Console.WriteLine("IT city");
                    break;
                default:Console.WriteLine("no IT city");
                    break;
            }
        }
    }
}
