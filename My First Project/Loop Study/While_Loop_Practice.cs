using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class While_Loop_Practice
    {
        static void Main(string[] args)
        {
            //display number between 15 to 40 -->

            /* int i = 15;
             while (i <= 40)
             {
                 i++;
                 if(i == 21 )
                 {
                     // break;
                     continue;
                 }
                 Console.WriteLine(i);*/




            //display between 150 to 101 --->
            /* int k = 150;
             while (k >= 101)
             {
                 Console.WriteLine(k);
                 k--;
             }*/



            /* int sum = 0;
             int i = 1;
             while (i <= 10)
             {
                 i++;
                 sum = sum + i;
             }
             Console.WriteLine(sum);
 */

            // display first 20 numbres and count also ...>
            /*  int i = 0;
              int count;
              while (i < 20)
              {
                  i++;
                  if (i % 2 != 0)
                  {
                      Console.WriteLine(i);
                  }

              }*/


            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i < 10)
            {
               
                Console.WriteLine(num + "X" + i + "=" + (num * i));
                i++;
            }










        }
    }
}
