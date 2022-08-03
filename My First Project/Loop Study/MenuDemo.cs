using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class MenuDemo
    {
        static void Main(String[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("enter the first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("1.Add\n2.Sub\n3.Multiplication\n4Div");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("sub" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multi" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Div" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue.........");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');

            
        }
    }
}
