using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_3
{
    class Q5
    {
        void Country()
        {
            while (true)
            {
                Console.WriteLine("Enter any country");
                Console.WriteLine("-----------------------------");
                string Country = Console.ReadLine();

                switch (Country)
                {
                    case "India":
                        Console.WriteLine("Hocky");
                        break;
                    case "China":
                        Console.WriteLine("Table-Tennis");
                        break;
                    case "Bangladeh":
                        Console.WriteLine("Kabaddi");
                        break;
                    case "Italy":
                        Console.WriteLine("Football");
                        break;
                    case "US":
                        Console.WriteLine("Baseball");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            
        }
        static void Main(String[] args)
        {
            Q5 q = new Q5();
            q.Country();
        }
    }
    
}   

