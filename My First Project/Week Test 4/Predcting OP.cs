using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    class Q2
    {
        //predicting Output ------------>
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
       static void main(String[]args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }

    }
}
