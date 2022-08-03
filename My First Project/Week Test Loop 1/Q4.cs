using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_Loop
{
    class Q4
    {
        static void Main(string[] args)
        {
            //printing fibbo series :---->
            int num1 = 0, num2 = 1, num3 ;
            num3 = num1 + num2;
            Console.Write("\t"+num1);
            Console.Write(" \t"+num2);

            for(int i = 3; i<= 20; i++)
            {
                Console.Write("   "+num3);
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
            }
        }
    }
}
