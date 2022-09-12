using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{       //base keyword second use .....>
        class Bird
        {
            public void Fly()
            {
                Console.WriteLine("Bird is flying");      //base class means parent class ...!
            }
        }
        class Sparrow : Bird
        {
            public void dry()
            {
                Console.WriteLine("Sparrow is ready to fly");
                base.Fly();
            }
        }
    class BaseUse2
    {
        static void Main(String[] args)
        {
            Sparrow s = new Sparrow();
            s.Fly();
            s.dry();
        }
    }
}
