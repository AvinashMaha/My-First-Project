using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Polymorphism
{
    class Area_Using_Overloading
    {
        double Area(int r)
        {
         Console.Write("Area of circle = ");
           return (3.14 * r * r);
            
        }
        int Area(int b , int c)
        {
            Console.Write("area of rectangle = ");
            return (b * c);
        }
        double Area(double b, int h)
        {
            Console.Write("Area of traingle = ");
            return (0.5 * b * h);
        }
        float Area(float a)
        {
            Console.Write("Area of Square = ");
            return (a * a);
        }

        static void Main(String[] args)
        {
            Area_Using_Overloading a1 = new Area_Using_Overloading();
            double ans1 = a1.Area(10);
            Console.WriteLine(ans1);

            int ans2 = a1.Area(13,11);
            Console.WriteLine(ans2);

            double ans3 = a1.Area(5.8,9);
            Console.WriteLine(ans3);

            float ans4 = a1.Area(12.4f);
            Console.WriteLine(ans4);

        }


        



    }
}
