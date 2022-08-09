using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
   
        abstract class Animl
        {
        internal int x = 10;             // We can declare any variable inside a class --->
        internal static int y = 20;
        internal const int z = 16;


            public abstract void Eat();       //abstract method
         
            public Animl(int legs)  //  paramatrised cunstructor method
            {
            
                Console.WriteLine($"Animal has {legs} legs");
            }
            public void Run()     //non abstract method
            {
                Console.WriteLine("Animal is running");
            }

        }
        class Cat : Animl
        {
            public Cat() : base(4) // access parent property in child property by using base keyword
            {

            }
            public override void Eat()
            {
                Console.WriteLine("Cat is Eating................!");
            }
        }
    class AbstractDemo2
    {

        static void Main(String[] args)
            {

            Cat d = new Cat();
            d.Eat();
            d.Run();

            }
        
    }
}
