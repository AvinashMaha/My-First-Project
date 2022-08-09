using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
    interface ICalculable
    {
        void Calculate();
    }
    class Child : ICalculable
    {
        public static int sum = 0, count = 0;

        public void Calculate()
        {
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine("Total sum is "+sum);
            Console.WriteLine("Total count is "+count);
        }
    }

    class Task_Interface
    {
       static void Main(String[] args)
        {
            Child c = new Child();
            c.Calculate();

        }
    }
}
