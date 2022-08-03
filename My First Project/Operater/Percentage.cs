using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class Percentage
    {
        static void Main(String[] args)
        {
            int phy, chemistry, Science, History, Maths , total;
            double per;
            string name ;

            Console.WriteLine("Calculate Total , Percentage , Class Of the Student");
            Console.WriteLine(".........................................");

            Console.Write("Name of the student : ");
            name = Console.ReadLine();

            Console.Write("Enter Physics Marks : ");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemisry Marks : ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Science Marks : ");
            Science = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter History Marks : ");
            History = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths Marks : ");
            Maths = Convert.ToInt32(Console.ReadLine());

            total = phy + chemistry + Science + History + Maths;
            Console.Write("Total marks are : " + total);

            per = total / 5.0f;
            Console.WriteLine("Total percentage are : " + per);

            if (per > 70)
            {
                Console.WriteLine("Congrats,You are in Distintion");
            }
            else if(per >60 && per <= 70)
            {
                Console.WriteLine("Congrats,You are in fitst class");
            }
            else if(per >50 && per <= 60)
            {
                Console.WriteLine("Congrats,You are in seconnd class");
            }
            else if (per >35 && per <= 50)
            {
                Console.WriteLine("Okey , you are passed");
            }
            else
            {
                Console.WriteLine("Sorry You are Failed ");
            }
            

        }
    }
}

    

