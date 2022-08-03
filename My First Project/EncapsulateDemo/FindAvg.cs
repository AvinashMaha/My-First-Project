using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class Avg_No
    {
        double FindAvg(int n)
        {
            double sum = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine(sum + " " + count);
            double avg = sum / count;

            return avg;
        }


        static void Main(String[] args)
        {
            Avg_No a = new Avg_No();
            Console.WriteLine(a.FindAvg(9));
        }
    }

}         
     
    

