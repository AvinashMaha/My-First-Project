using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class NegativeNumber
    {

        void number()
        {
            while (true)
            {
            Console.WriteLine("Enter any no");
            int a = int.Parse(Console.ReadLine());
           
                if (a < 0)
                {
                    int c = a + a;
                    Console.WriteLine("Negativs ans is = "+c);

                }
                else if (a > 0)
                {
                    Console.WriteLine("Positive ans is "+a);
                   
                }
                else
                {
                    Console.WriteLine("Invalid I/P");
                    break;
                    
                }
            }
        }
        static void Main(String[] args)
        {
            NegativeNumber b = new NegativeNumber();
            b.number();
        }
    }
}
            
            
            







        
