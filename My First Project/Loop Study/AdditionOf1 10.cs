using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class AdditionOf1_10
    {
        static void Main(String[] args)
        {
            int sum = 0;
            for(int i=1; i<=10; i++)
            {
                sum = sum + i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
