using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class Swapping
    {

       // public void swap( int num1 , int num2)
        public void swap(ref int num1 ,ref int num2)          //in swapping ref is necessory
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static void Main(String[] args)
        {
            Swapping s = new Swapping();

            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine("------------------------------------");
            //s.swap( num1,  num2);                   //passby value .....!
            s.swap(ref num1, ref num2);           //pass by reference ......!
            Console.WriteLine(num1+" "+num2);
        }
    }
}
