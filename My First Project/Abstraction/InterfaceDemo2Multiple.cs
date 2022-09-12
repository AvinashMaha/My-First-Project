using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
    interface IDrawable
    {
        static int y = 14;
        void Draw();
    }
    interface Iprintable
    {
        void Draw();
    }
  
    class shape : IDrawable , Iprintable
    {
         void IDrawable.Draw()
        {
            Console.WriteLine("Draw Shape" + IDrawable.y);
        }
         void Iprintable.Draw()
        {
            Console.WriteLine("Print Shape"+ IDrawable.y);
        }
       
    }

     class InterfaceDemo2Multiple
    {
        static void Main(String[]args) {
          //  shape s = new shape();
            IDrawable s1 = new shape();
            Iprintable s2 = new shape();
            

            s1.Draw();
            s2.Draw();
          
        }
    }
}
