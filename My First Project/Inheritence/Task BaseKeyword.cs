using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{            // Heirarchical class --->
    //base keyword use no = 01
 class Number
    {
        public int number = 4;    //base class - parent classs
    }
    class One : Number
    {
        public int number = 1;
        public void ShowOne()
        {
            Console.WriteLine("Number is ="+number + "\t Origoinal Number = " +base.number );
        }
    }
    class Four : Number
    {
        public int number = 4;
        public void ShowFour()
        {
            Console.WriteLine("My number is = "+ base.number);
        }

    }

    class Task_BaseKeyword
    {

        static void Main(String[] args)
        {

            Four f = new Four();
            f.ShowFour();

            One o = new One();
            o.ShowOne();

        }
    }
}
