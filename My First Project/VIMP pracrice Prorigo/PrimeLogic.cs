using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class PrimeLogic
    {
        // identify number is prime or not
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }

            }
            if (isprime == true)
            {
                Console.WriteLine("prime");
            }
            else if (isprime == false)
            {
                Console.WriteLine("not");
            }

            //////////////////print from 1 to 100////////////////////
            static void Main(string[] args)
            {
                //printing prime numbers from 1 to 100
                for (int i = 1; i <= 100; i++)
                {
                    bool isprime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }
    }
}

