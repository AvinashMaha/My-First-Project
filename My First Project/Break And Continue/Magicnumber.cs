using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Break_And_Continue
{
    class Magicnumber
    {
        static void Main(String[] args)
        {
            int mymagicnumber = 56;
            Console.WriteLine(mymagicnumber);
            while (true)
            {


                Console.WriteLine("enter the number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > mymagicnumber)
                {
                    Console.WriteLine("Entered number is greater , Pl try again");
                }
                else if (num < mymagicnumber)
                {
                    Console.WriteLine("Entered number is smaller");
                }
                else
                {
                    Console.WriteLine("Yes , You guess correct");
                    break;
                }
            }
        }
    }
}
