using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class NestedDemo2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the first number ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third number ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("n1 is greater");
                }
                else
                {
                    Console.WriteLine("n3 is greater");
                }
                
            }
            else if(n2 >n3)
                  {
                  Console.WriteLine("n2 is greater");
                  }
            else
            {
                Console.WriteLine("n3 is  the greater");
            }

        }
    }
}
