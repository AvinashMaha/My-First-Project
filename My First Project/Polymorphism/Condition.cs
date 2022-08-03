using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Polymorphism
{
    class Condition
    {
        int show(int a , int b)
        {
            Console.Write("Addition = ");
            return a + b;
        }
        float show(float b, int a)
        {
            Console.Write("Substraction = ");
            return b - a;
        }
        float show(int a ,float b)
        {
            Console.Write("Multiplication = ");
            return a*b;
        }
        float show(float a , float b)
        {
            Console.Write("Division = ");
            return a/b;
        }

        static void Main(String[] args)
        {
            Condition c = new Condition();
            int ans1 = c.show(4, 5);
            Console.WriteLine(ans1);

            float ans2 = c.show(7.5f, 3);
            Console.WriteLine(ans2);
            

           float ans3= c.show(10, 4.5f);
            Console.WriteLine(ans3);


           float ans4 =  c.show(9.3f, 4.7f);
            Console.WriteLine(ans4);


        }

            
       
        


    }
}
