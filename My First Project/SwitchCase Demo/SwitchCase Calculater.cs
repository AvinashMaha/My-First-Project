using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class SwitchCase_Calculater
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Write 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 Addition\n2.substract\n3.multiplication\n4.division");
                Console.WriteLine("Write your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("addition =" + (n1 + n2));
                    break;
                case 2:
                    Console.WriteLine("substraction =" + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("multiplication =" +( n1 *n2));
                    break;
                case 4:
                    Console.WriteLine("division =" + ( n1 / n2));
                    break;
                default: Console.WriteLine("invalid choice");
                    break;

            }

        }
    }
}
