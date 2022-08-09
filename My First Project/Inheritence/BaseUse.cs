using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{  //               Base Keyboard in inheritenceb ....>
    class Animal                      //using heirarchical class ....>
    {
        public int legs = 4;              //base class i.e parent class ...!
    }
    class Frog : Animal
    {
        public int legs = 2;
        public void Show()
        {
            Console.WriteLine("Legs = "+legs+"\t"+"Animal Legs ="+base.legs);
        }
    }
      class dog : Animal
      {
          public void Display()
          {
             Console.WriteLine("Dog legs = " + base.legs);
          } 
      }


    class BaseUse
    {
        static void Main(String[] args)
        {
            Frog f = new Frog();
            f.Show();
            dog d = new dog();
            d.Display();

        }
    }
}


