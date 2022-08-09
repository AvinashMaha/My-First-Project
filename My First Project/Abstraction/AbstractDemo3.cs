using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
   abstract class Vehicle         //abstract class 
   {
        public abstract void Run(); // abstract method
   }
    abstract class Car :Vehicle
    {

    }
    class BMW : Car
    {
       public override void Run()     // non abstaract mtd
        {
            Console.WriteLine("My BMW is running");
        }
    }

    class AbstractDemo3
    {
        static void Main(String[] args)
        {
            Vehicle b = new BMW(); //object creation 
            b.Run();

           /* BMW b1 = new BMW();
            b1.Run();*/
            
        }
      
    }
}
