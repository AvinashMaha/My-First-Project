using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.NestedLoop
{
    class Prime_using_NestedLoop
    {
        static void Main(String[] args)
        {
            for (int num= 1; num <= 10; num++)
                {
                bool isprime = true;
                for(int i = 2; i < num; i++)
                {
                    if(num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime == true)
                {
                    if(num != 1)
                    {
                        Console.WriteLine(num);
                    }
                } 


            }
        }
    }
}
