using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Static_Method
{
    class StaticDemo4
    {
        static StaticDemo4()
        {
            Console.WriteLine("HIIIIIIIIIII");
        }
        StaticDemo4(int n , float b)
        {
            Console.WriteLine(n+ " "+b);
        }
        static void Main(String[] args)
        {
            StaticDemo4 s = new StaticDemo4(4,5.6f);       
           // StaticDemo4 s1 = new StaticDemo4();
           // StaticDemo4 s2 = new StaticDemo4();
            
        }
    }
}
