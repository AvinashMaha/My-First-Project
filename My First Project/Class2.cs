using System;
using System.Collections.Generic;
using System.Text;

//namespace My_First_Project
//{
class Class2
{
    void IPUser()
    {
        int r;
        while (true)
        {

            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                r = num % 10;
                break;



            }
            /*  if (r == 0)
              {
                  Console.WriteLine("sorry");
                  break;
              }*/





        }

    }
    static void Main(String[] args)
    {
        Class2 c = new Class2();
        c.IPUser();
    }
}

 




