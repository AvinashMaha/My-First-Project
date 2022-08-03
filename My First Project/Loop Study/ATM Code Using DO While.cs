using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Loop_Study
{
    class ATM_Code_Using_DO_While
    {
        static void Main(String[] args)
        {
            int atm_code = 1243;
            int pin =0;
            int count = 0;
            Console.WriteLine("My atm code is " + atm_code);

            do
            {
                count++;

            } while (pin == atm_code && count <= 3);

            if (pin == atm_code)
            {

                Console.WriteLine("WELCOME SIR");
            }
            else
            {

                Console.WriteLine("Account Blocked,");
            }
        }
    }
}
