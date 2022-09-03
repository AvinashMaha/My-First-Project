using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Animal
    {
        int no_of_legs = 4;
        public virtual void Legs()
        {
            Console.WriteLine("Legs of animal are" + no_of_legs);
        }
    }

    class Kangaroo : Animal
    {
        int no_of_legs = 2;
        public override void Legs()
        {
            Console.WriteLine("Legs of Kangaroo  are " + no_of_legs);

        }
    }

        class OverrideDemo
        {
            static void Main(String[] args)
            {
                Animal a = new Kangaroo();
                a.Legs();
            }
        }

        
    
}

