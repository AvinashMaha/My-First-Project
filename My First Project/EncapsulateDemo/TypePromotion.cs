using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class TypePromotion
    {
        void addition(int x , double t)         //formal parameter
        {
            Console.WriteLine(x + t);
        }
        static void Main(String[] args)
        {
            TypePromotion p = new TypePromotion();
            p.addition(4, 6.7);                    //actual parameter
           
        }      //formal parameter memory should be greater than actual parameter.....!
    }
}
