using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{                 //Heirarchical inheritence mtd -------------->
    class Laptop
    {
        public Laptop(int y ,int x)
        {
            Console.WriteLine($"Laptop\t{y+x} ");
        }
    }
    class Dell : Laptop
    {
        public Dell() : base(64,78)
        {
            Console.WriteLine("Dell ......!");
        }
    }
    
    class BaseUse3
    {
        static void Main(String[] args)
        {
            Dell d = new Dell();
            
        }
    }
}
