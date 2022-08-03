using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class Prime_Number_Using_While_Loop
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            int i = 2;
            while (i <= num)
                
            { if(num % i == 0)
                {
                    isprime = false;
                    
                }
                i++;

            }
            if(isprime == true)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("not prime");
            }
               
            }
        }
    
}
