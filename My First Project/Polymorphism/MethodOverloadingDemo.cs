using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class MethodOverloadingDemo
    {
         void show()
        {
            Console.WriteLine("show method");
        }
        void show(string str , int x)
        {
            Console.WriteLine(str + " " + x);
        }
        int show(int a , int b)
        {
            return a - b;
        }
        void show(float x)
        {
            Console.WriteLine(x);
        }

        static void Main(String[] args)
        {
            MethodOverloadingDemo m = new MethodOverloadingDemo();
            int diff = m.show(3, 4);
            Console.WriteLine(diff);             //3

            Console.WriteLine(m.show(6, 7));           //3
            m.show();                       //1

            m.show("jignesh",34);          //2
            m.show(36.15f);



        }
    }
}
