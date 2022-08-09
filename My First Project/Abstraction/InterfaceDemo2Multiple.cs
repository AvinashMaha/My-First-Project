using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
    interface IDrawable
    {
        void Draw();
    }
    interface Iprintable
    {
        void Print();
    }
    class shape : IDrawable , Iprintable
    {
        public void Draw()
        {
            Console.WriteLine("Draw Shape");
        }
        public void Print()
        {
            Console.WriteLine("Print Shape");

        }
    }

    class InterfaceDemo2Multiple
    {
        static void Main(String[]args) {
            shape s = new shape();
            s.Draw();
            s.Print();
        }
    }
}
