using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class CalculaterSwitchCase_Homework
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.+\n2.-\n3./\n4.*\n5.%");
            Console.WriteLine("Enter your choice ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '+': Console.WriteLine("Addition Of two number is " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substration Of two number is " + (num1 - num2));
                    break;
                case '/':
                    Console.WriteLine("Division Of two number is " + (num1 / num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication Of two number is " + (num1 * num2));
                    break;
                case '%':
                    Console.WriteLine("Modulus Of two number is " + (num1 % num2));
                    break;
                default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
    
        
    
}
