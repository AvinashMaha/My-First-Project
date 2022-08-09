using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{        //overiding methpod ---->   hierarchical inheritence 
    class Fruit       
    {
        public virtual void Taste()
        {
            Console.WriteLine("Taste is Sweet");
        }
    }
    class Mango : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Mango is Sweetest");
            base.Taste();
        }
    }
    class Banana : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Banana is Sweet");
            
        }
    }
    class OverridingDemo
    {
        static void Main(String[] args)
        {
            Fruit f = new Mango();           //object is dynamic binding in overriding.
            f.Taste();

            Fruit f2 = new Banana();
            f2.Taste();
        }
    }
}
