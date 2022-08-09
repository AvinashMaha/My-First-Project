using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{       //        sealed keyword ----->         //Multilevel Inheritense Method
    class Flower
    {
        public virtual void Color()
        {
            {

                Console.WriteLine("Colourful Flowers");
            }
        }
    }
   
    class Rose : Flower          //can't inherit sealed class ...! 
    {
        public override void Color()
        {
            Console.WriteLine("Rose is colourful");
        }
    }
   /* class ReadRose : Rose
    {
        public sealed void Color()
        {
            Console.WriteLine("RedRose");
            base.Color();
        }
    }*/
    class SealDemo
    {
        static void Main(String[] args)   
        {
            Flower f = new Rose();
            f.Color();
           /* Flower f2 = new ReadRose();
            f2.Color();*/

        }
    }
}

