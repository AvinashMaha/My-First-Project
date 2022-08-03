using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class Number_1_30_Loop
    {
        static void Main(String[] args)
        {
            int i = 1;

            while (i <= 30)
            {
                i++;
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }






           
          

        }
    }
}
