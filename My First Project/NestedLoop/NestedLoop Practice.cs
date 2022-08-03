using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.NestedLoop
{
    class NestedLoop_Practice
    {
        static void Main(String[] args)
        {
            //Homework 1 --->
            /*for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();

            }
*/

            //homework 3 ---->
            /* for (char i = 'D'; i >= 'A'; i--)
             {
                 for (char j = 'A'; j <= i; j++)
                 {
                     Console.Write(j);
                 }
                 Console.WriteLine();

             }*/



            // Homework 4--->
            /*  for (int i = 5; i >= 1; i--)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write(j);
                  }
                  Console.WriteLine();
              }
  */

            /*int num = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }*/



            /*  for (int i = 1; i <= 4; i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      int sum = i + j;
                      if (sum % 2 == 0)
                      {
                          Console.Write("0  ");
                      }
                      else
                      {
                          Console.Write("1  ");
                      }
                  }
                  Console.WriteLine();
              }*/


            // homework 2---->
            /*for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }

                }
                Console.WriteLine();
            }

*/





            // homework 5--->
            /*  for (int i = 1; i <= 4; i++)
              {
                  for (int j = 1; j <= 4;  j++)
                  {
                     if(j ==1 || j==4 || i == j)
                      {
                          Console.Write("* ");
                      }
                      else
                      {
                          Console.Write("  ");
                      }
                  }
                  Console.WriteLine();
              }
  */

            //Homework 6 ---->
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());

            
            for(int i =1; i<=num; i++)
            {
                char ch = 'A';
                for (int j = i ; j<=1; j++)
                {
                   
                    if (i % 2 == 0)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }


        }
    }
}

