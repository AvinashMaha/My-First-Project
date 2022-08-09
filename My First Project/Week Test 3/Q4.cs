using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_3
{
    class Q4
    {
        void Loop()
        {
            /*       1
                   1 2 3
                 1 2 3 4 5
               1 2 3 4 5 6 7   */

            for (int i = 1; i<=4; i++)
            {
                int j = 1; 
                for (int k = 1; k<=7; k++)
                {
                    if (k >= 5 - i && k <= 3 + i)
                    {
                        Console.Write(j);
                        j++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }       
                }
                Console.WriteLine();
            }
        }
        static void Main(String[] args)
        {
            Q4 q = new Q4();
            q.Loop();

        }
    }
}
