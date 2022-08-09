using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{
    class vehicle                 //Parent class ...!
    {
        internal int wheels = 4; 
    }
    class Car : vehicle                //Child 1 ....!
    {
        internal string cname = "BMW";
     public void Showcar()
        {
            Console.WriteLine(cname + " = " +base.wheels);
        }

    }
    class Truck : vehicle                //child 2.....!
    {
        public void ShowRTruck()
        {
            wheels = 8;
            Console.WriteLine("Truck wheels = "+base.wheels);
        }
    }
    class Hierarchical
    {
        static void Main(String[] args)
        {
            Truck t = new Truck();
            t.ShowRTruck();
            Car c = new Car();
            c.Showcar();
        }
    }
}
