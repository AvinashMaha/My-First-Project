using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    class Q12
    {
        //Write a  program that prints the numbers
        static void Main(String[] args)
        {
            static void Main(string[] args)
            {
                int countbuzz = 0;
                int countfizz = 0;
                int countbuzzfizz = 0;
                for (int i = 1; i <= 50; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("buzzfizz");
                        countbuzzfizz++;
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("buzz");
                        countbuzz++;
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("fizz");
                        countfizz++;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
                Console.WriteLine(countbuzzfizz + " " + countbuzz + " " + countfizz);
                Console.ReadLine();
            }
        }
    }
}
