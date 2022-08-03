using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class PrimeSum
    {
        
        int sumofprime(int n)
        {
            int sum = 0;
            for(int i =1; i<=n; i++)
            {
                int num = i;
                bool isPrime = true;
                for(int j = 2;j<=num; j++)
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime == true)
                {
                    sum = sum + i;
                }

            }
            return sum;
        }


        static void Main(String[] args)
        {
            PrimeSum p = new PrimeSum();
            int ans = p.sumofprime(10);
            Console.WriteLine(ans);

        }
    }
}
