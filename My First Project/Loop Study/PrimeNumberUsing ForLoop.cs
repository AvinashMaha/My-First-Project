using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class PrimeNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Write a number");
            int num = int.Parse(Console.ReadLine());

            bool isprime = true;

            
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;         //not prime
                    break;            //if not a prime number then break it ....!
                }
               

            }
            if (isprime == true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

        }
    }
}
