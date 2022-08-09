using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{ //Base Keyword Use no 2
    class Num
    {
        public int number = 4;    //base class - parent classs
        public void ShowNumber()
        {
            Console.WriteLine("My number is = " + number);
        }
    }
    class Five : Num
    {
        public int number = 5;
        public void ShowNumber()
        {
            Console.WriteLine("My number is =" + number);
        }
    }
    class Ten : Num
    {
        public int number = 10;
        public void ShowNumber()
        {
            Console.WriteLine("My number is = " + number);
            base.ShowNumber();

        }
    }
    class TaskBaseKeyword2
    {
        static void Main(String[] args)
        {
            Ten t = new Ten();
            t.ShowNumber();

            Five f = new Five();
            f.ShowNumber();


        }





    }
}
