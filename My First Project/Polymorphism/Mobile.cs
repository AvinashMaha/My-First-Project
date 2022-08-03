using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Polymorphism
{
    class Mobile
    {
        int price;
        string name;
        string memory;

        public Mobile()
        {
            Console.WriteLine("I am a default");
        }
        public Mobile(string name)
        {
            this.name = name;
        }
        public Mobile(int price, string memory)
        {
            this.price = price;
            this.memory = memory;
        }
    }

    class Constructoverload : Mobile
    {
        Mobile m = new Mobile("Apple");
            Mobile m1 = new Mobile();
            Mobile m3 = new Mobile(30000, "64GB");
        static void Main(String[] args)
        {
            
            


        }

    }
}
