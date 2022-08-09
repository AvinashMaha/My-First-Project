using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
    abstract class Animal       //if class name is abstract then mtd name should be abstract ...!
    {
        public abstract void Eat();                //Abstract Method 
    }
     class Dog : Animal
    {
        public override void Eat()  // non abstact method
        {
            Console.WriteLine("Dog is eating");
        }
    }
    class AbstractDemo
    { 
        static void Main(String[] args)
        {
           /* Animal f = new Dog();
            f.Eat();           */              // mtd calling

            Dog d = new Dog();
            d.Eat();                           //mtd calling 2nd way

        }
    }
}
