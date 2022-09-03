using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_Loop
{
    class Q8
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int r ,b=1 , sum  =0 , num2=num;
           
            while (num > 0)                   //145          14
            {
                r = num % 10;                 //5            14%10 = 4
               for(int i = 1; i<=r; i++)            //condition cheking 
                {
                    b = b * i;                       //1=2=6=24=120      //1=2=6=24   //1
                }
                sum = sum + b;            //120 +24+1
                b = 1;
                num = num / 10;            // 145/10 = 14            14/10 = 1

            }
            if(num2 == sum)
            {
                Console.WriteLine("no is krishnamurthy");
            }
            else
            {
                Console.WriteLine("not a krishnamurthy");
            }
           
        }
    }
}
