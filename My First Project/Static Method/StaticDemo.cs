using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Static_Method
{
    class StaticDemo
    {
        int r;
        static double Area(int r)
        {
            Console.Write("Area of Circle = ");
             return 3.14 *r * r ;
        
        }
        //static void Area()
       
        static void Main(String[] args)
        {
            StaticDemo s = new StaticDemo();
            double ans = StaticDemo.Area(10); ;
            Console.WriteLine(ans);
        }
    }
}
