using System;

namespace My_First_Project.Week_Test_2
{
    class Q4
    {
        void Loop()
        {
          /*  1
              2 1
              3 2 1 
              4 3 2 1
              5 4 3 2 1            */


        for(int i = 1; i<=5; i++)
            {
               for(int j =i; j>=1; j--)
               { 
                    Console.Write(j);
               }
                Console.WriteLine();
            }
            


        Console.WriteLine("--------------------------------------");

           /*             1
                        1 0
                      1 0 1
                    1 0 1 0
                  1 0 1 0 1     */

            for(int i = 1;i<=5; i++)       //outer loop
            {
                for (int j = 1;j<=5-i;j++)        //inner loop
                {
                    Console.Write(" ");          //for space ---
                    
                }
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j % 2);            //for printing j
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
