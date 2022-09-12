using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class TypeCasting
    {
        static void Main(string[] args)
        {

            //it is automatic casting
            int a = 8;   //int = 4 byte
            double d = a;   //doublr = 8 byte
            Console.WriteLine(d);          
            Console.WriteLine(a);

            //manual casting 
            double d1 = 9.76;
            int a1 = (int)d1;
            Console.WriteLine(a1);
            Console.WriteLine(d1);

        }
    }
}
