using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_3
{
    class car
    {
         string color;

        public void changeColor(car c2)
        {
            c2.color = color;
            color = "Red";
        }
    }
    class Demo
    {
        static void Main(String[] args)
        {
            car c1 = new car();
          //  c1.color = "Blue";
            car c2 = new car();
           // c2.changeColor(c1);
        //    c2.color = "Pink";
         // /*  Console.WriteLine(c1.color);
          //  Console.WriteLine(c2.color);
        }
    }
}
