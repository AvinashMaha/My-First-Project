using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.NestedLoop
{
    class NestedLoopDemo
    {
        static void Main(String[] args)
        {
           /* for (int i = 1; i <= 4; i++)    //row
            {
                for (int j = 1; j <= 4; j++)    //column
                {
                   // Console.Write(i);
                     Console.Write(j);
                }
                Console.WriteLine();
            }*/

            /*  for(int i = 1; i <= 4; i++)          //row
              {
                  for(int j =1; j<=i; j++)        //column
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }*/

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            /* for(int i = 1; i<=5; i++)                    //row
             {
                 for(int j = 1; j<=i; j++)                //column
                 {
                     if(j == 1 || i == 5 || i == j)
                     {
                         Console.WriteLine("*");
                     }
                     else
                     {
                         Console.Write(" ");
                     }

                 }
                 Console.WriteLine();
             }*/


            /* for (char i = 'A'; i <= 'D'; i++)
             {
                 for (char j = 'D'; j >= i; j--)
                 {
                     Console.Write(i);

                 }
                 Console.WriteLine();
             }*/

            // my practice :----->
            /* for (int i = 1; i <= 4; i++)
             {
                 for(int j = 1; j<=5; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             */

            /* for(int i = 1; i <= 5; i++)
             {
                 for(int j = 1; j <= 5; j++)
                 {
                     if( i == 1 || j == 1 || i== 5 || j == 5)
                     {
                         Console.Write("*");
                     }
                     else
                     {
                         Console.Write(" ");
                     }

                 }
                 Console.WriteLine();
             }*/

            /*  for(int i = 4; i>=1; i--)
              {
                  for (int j = 1; j <= i ; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }*/


            /* for (int i = 1; i <= 4; i++)
             {
                 // for spaces
                 for( int j = 1; j<=4-i; j++)
                 {
                     Console.Write(" ");
                 }
                 // for stars 
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
 */







        }
    }
}
