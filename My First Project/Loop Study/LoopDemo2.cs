using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class LoopDemo2
    {
        static void Main(String[] args)
        {
            //sum of all even numbers 1 - 10 
            int sum = 0;
            for(int i =1; i<=10; i++)
            {
                if(i % 2 == 0)
                {
                    sum =sum+i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
