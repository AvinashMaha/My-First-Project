using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class CheckPrime
    {
        bool IsPrime(int n)
        {
            bool isprime = true;
        for(int i = 2; i <n; i++)
            {
                if(n%i == 0)
                {
                    isprime = false;      //  not prime number
                    break;
                }
            }
            return isprime;
        }



     static void Main(String[] args)
        {
            CheckPrime p = new CheckPrime();
            bool b = p.IsPrime(5);
            if (b==true)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("Not prime");
            }


        }
       
       


    }
}
