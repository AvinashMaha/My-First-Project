using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class Swapnum
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            num1 = 13;
            num2 = 12;
            Console.WriteLine(num1 + " " + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;
           Console.WriteLine(num1 + " " + num2);

           
        }
    }
}
