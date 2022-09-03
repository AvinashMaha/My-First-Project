using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_Loop
{
    class Q6
    {
        static void Main(String[] args)
        {
            for(int i = 1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Redblue");
                    

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("red");
                   
                }

               else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                   
                }

               
                else
                {
                    Console.WriteLine(i);
                }

              

                
             
            }
        }
    }
}
