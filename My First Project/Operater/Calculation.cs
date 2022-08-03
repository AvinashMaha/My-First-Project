using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class Calculation
    {
        static void Main(String[] args)
        {
            int a = 3, b = 2;

            int x = --a - ++b - a;   // -3 , 2 , 2
            int x1 = b++ + ++a + b; // 9 , 4 , 3
            int x2 = a++ + --b - a;
            int x3 = --a - --b - a;


            Console.WriteLine(x + " " + a + " " + b);
            Console.WriteLine(x1 + " " + a + " " + b);
            Console.WriteLine(x2 + " " + a + " " + b);
            Console.WriteLine(x3 + " " + a + " " + b);


        }

    }
}
