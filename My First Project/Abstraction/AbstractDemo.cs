using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
    abstract class Animal       //if class name is abstract then mtd name should be abstract ...!
    {
        public abstract bool Eat();                //Abstract Method 
       
    }
     class Dog : Animal
    {
        bool isvalidate = true;
        public override bool Eat()  // non abstact method
        {
            Console.WriteLine("Dog is eating");
            return isvalidate;
           
        }
    }
    class monkey : Animal
    {
        bool isvalidate = true;
        public override bool Eat()
        {
            bool isvalidate = true;
            Console.WriteLine("Monkey jump very fast");
            return isvalidate;

        }
    }
    class donkey : Animal
    {
        public override bool Eat()
        {
            bool isvalidate = true;
            Console.WriteLine("Donkey is running");
            return isvalidate;
        }
    }
    class AbstractDemo
    {
       
        static void Main(String[] args)
        {
            Animal f = new Dog();
            f.Eat();                         // mtd calling

            Animal f1 = new monkey();
            f1.Eat();
            /* Dog d = new Dog();
             d.Eat();                           //mtd calling 2nd way*/

        }
    }
}
