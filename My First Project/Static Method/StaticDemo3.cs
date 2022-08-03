using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Static_Method
{
    class StaticDemo3
    {
        int x = 10;
        static int y = 56;

        void show()
        {
            Console.WriteLine(x + " " + y);
        }
        static void Mymethod()
        {
            StaticDemo3 s = new StaticDemo3();
            Console.WriteLine(s.x + " " + y);

            int c = s.x + y;
        }
        static void Main(String[] args)
        {
            StaticDemo3 d = new StaticDemo3();
            d.show();
            StaticDemo3.Mymethod();
           



        }
    }
}
