using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class Class2
    {
        void IPUser()
        {
            bool flag = true;
            while (true)
            {
                Console.WriteLine("Enter any number");
                int num = int.Parse(Console.ReadLine());
                int num2 = num;

                while (num > 0)
                {
                    int r = num % 10;                  
                    if(r==0)
                    {
                        flag = false;                      
                        break;
                    }
                    num = num / 10;
                }
               if(flag == false)
                {
                    Console.WriteLine("invalid o/p");
                    break;
                }
                else
                {
                    Console.WriteLine(" your num is"+num2);
                }
            }
        }
        static void Main(String[] args)
        {         
            Class2 c = new Class2();
            c.IPUser();
        }
    }
}





 




