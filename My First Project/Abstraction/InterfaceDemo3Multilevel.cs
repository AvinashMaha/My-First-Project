using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
    class InterfaceDemo3Multilevel
    {
        interface IDrawable
        {
            void Draw();   
        }
        abstract class Circle 
        {
            public abstract void DrawCircle();    //Abstract method
        }
        class Shape : Circle , IDrawable
        {
            public  void Draw()
            {
                Console.WriteLine("Draw shape");
            }
            public override void DrawCircle()
            {
                Console.WriteLine("Circle");
            }
        }
        static void Main(String[] args)
        {
            shape s = new shape();
            shape s2 = new shape();
            s.Draw();
           
        }
    }
}
