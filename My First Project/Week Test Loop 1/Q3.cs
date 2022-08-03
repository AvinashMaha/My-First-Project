using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_Loop
{
    class Q3
    {
        static void Main(String[] args)
        {
         for(int i = 1;i<=50; i++)
            {
                int f;
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                else 
                {
                     f = i * i;
                    Console.WriteLine(f);
                }
            }

        }
    }
}
