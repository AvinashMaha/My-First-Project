using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{
    class Mobile    //parent class ....!
    {
        internal string memory_size = "64GB";
    }
    class Apple : Mobile      //child class ....!
    {
       public void show()
       {
            Console.WriteLine(memory_size);
       }
    }
    class Single_Demo
    {

        static void Main(String[] args)
        {
            Apple iphone = new Apple();
            iphone.show();
            //Console.WriteLine(iphone.memory_size);


        }
    }
}
