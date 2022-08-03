using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Polymorphism
{
    class InterestRate
    {
        float a, b;
        int c = 500000;
        int num = 4;
        void calculate(float d)
        {

            a = (c * num * d) / 100;
            Console.WriteLine(a);

        }
        void calculate(float d , float d2)
        {
            b = (c * d * 1 / 100) + (c * d2 * (num - 1) / 100);
            Console.WriteLine(b);
          //  if ()
            {

            }

        }

        static void Main(String[] args)
        {
            InterestRate i = new InterestRate();
            i.calculate(6.6f);

            i.calculate(5.8f, 9.5f);



        }
    }
}
