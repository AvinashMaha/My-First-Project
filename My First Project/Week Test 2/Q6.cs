using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_2
{
    class Q6
    {
        //   1
        //   2 2 
        //   3 3 3 
         //  4 4 4 4
        //   5 5 5 5 5
     void Loop()
        {
      for(int i =1; i <= 5; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }


        }


        static void Main(String[] args)
        {
            Q6 q = new Q6();
            q.Loop();
        }
    }
}
