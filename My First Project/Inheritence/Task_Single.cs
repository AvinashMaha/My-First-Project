using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{
    class Bicycle             //Parent Class 
    {
        internal string type = "GearType";
    }
    class Giant :Bicycle    // Child Class
    {
        public void Show()
        {
            Console.WriteLine("My bicycle is : "+type);
        }
    }
    class Task_Single            //Single Inheritence (is the relation)
    {
        static void Main(String[] args)
        {
            Giant g = new Giant();
            g.Show();
        }
    }
}
