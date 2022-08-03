using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class AssignmentOperater
    {
        static void Main(String[] args)
        {
            int x, y, z, a, b;
             
            x = 10;
            x *= 3;
            Console.WriteLine(x);

            y = 10;
            y /= 3;
            Console.WriteLine(y);

            z = 10;
            z %= 3;
            Console.WriteLine(z);

            a = 10;
            a += 3;
            Console.WriteLine(a);

            b = 10;
            b += 5;
            Console.WriteLine(b);
        }
    }
}
