using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class Positive_Or_Negative
    {

        static void Main(String[] args)
        {
            Console.Write("Enter any number :  ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if(num > 0)
            {
                Console.WriteLine("It is Positive number");
            }
            else if(num == 0){
                Console.WriteLine("It is a 0 number");
            }
            else
            {
                Console.WriteLine("It is a negative number");
            }
        }

    }
}
