using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class Loop_1_15
    {
        static void Main(String[] args)
        {
            int i = 1;
            while (i <= 15)
            {
                i++;
                if(i % 3 ==0 && i % 9 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
