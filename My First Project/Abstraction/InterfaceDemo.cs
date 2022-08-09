using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Abstraction
{
 interface IMovable
    {
        // int x = 45;              //error not allowed non static members ....!
        static int y = 90;
         void Move();
       
        static void Show()          //static method
        {
            Console.WriteLine("show method");
        }
         int add()
        {
            return 2 +3 ;
        }

    }
    class Bus : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bus is runnig....."+"\t"+IMovable.y);
        }
        public void Stop()
        {
            Console.WriteLine("Bus is stop");
        }
    }
    class InterfaceDemo
    {
        static void Main(String[] args)
        {
            /* Bus b = new Bus();
             b.Move();*/

            IMovable m = new Bus();
            m.Move();

            Console.WriteLine(m.add());         //Accessing static varibles --->   

            IMovable.Show();             //Accessing inheritence class

            Bus b = new Bus();
            b.Stop();            //Accessing Child Class 
        }
    }
}
