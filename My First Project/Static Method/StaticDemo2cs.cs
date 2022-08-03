using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Static_Method
{
    class StaticDemo2cs
    {
        static int x = 0;

        StaticDemo2cs()
        {
            x++;
            Console.WriteLine(x);
            
        }
        void display()
        {
            Console.WriteLine(x);
        }
        static int addition()
        {
            return 2 + 5;
        }

        static void Main(String[] args)
        {
            Console.WriteLine(x);
            StaticDemo d = new StaticDemo();
            StaticDemo d1 = new StaticDemo();
            StaticDemo d2 = new StaticDemo();
            Console.WriteLine(StaticDemo2cs.x);

            int ans = StaticDemo2cs.addition();
            Console.WriteLine("Addition" + ans);

        }
    }
}
