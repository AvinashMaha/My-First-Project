using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_2
{
    class Q2
    {
      void index_base(int a , int b )
        {
            
                int power = 1;
                int i = 1;
                while (i <= b)
                {
                    power = power * a;
                    i++;
                }

            Console.WriteLine(power);
        }
      
        static void Main(String[] args)
        {
            Q2 q = new Q2();

            Console.WriteLine("Enter the base number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Power number");
            int b = int.Parse(Console.ReadLine());

            q.index_base(a,b);
            



        }
    }
}
