using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class No_Is_Armstrong_Or_Not
    {
        static void Main(String[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r* r);          //if user digit is 4 then type r 4 times 
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");


            // int n = int.Parse(Console.ReadLine());



            /*   bool display = false;
               while (n > 0)
               {
                   int r = n % 10;
                   if (r % 2 == 0)
                   {
                       display = false;
                       break;
                   }
                   n = n / 10;
               }
               if (display == true)
               {
                   Console.WriteLine("Happy");
               }
               else
               {
                   Console.WriteLine("Not Happy");
               }



   */
           /* int num = int.Parse(Console.ReadLine());
            
            int rev = 0;
            while( num > 0)
            {
                int r = num % 10;
                rev = rev * 10 + r;
                num = num / 10;

                

            }
            Console.WriteLine(rev);*/


        }
    }
}
