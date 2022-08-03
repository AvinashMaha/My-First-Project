using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_2
{
    
    class Q5
    {
        // print series 0 , 3, 8 , 15 , 24 ------------n !
        int n , a;
        void series()
        {
            
            for (int i = 1; i <= n; i++)
            {
                 a = (i * i) - 1;
                Console.Write(a + " , ");
            }
        }
        static void Main(String[] args)
        {
            Q5 q = new Q5();
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            q.series();

        }
    }
}
