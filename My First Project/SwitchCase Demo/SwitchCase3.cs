using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.SwitchCase_Demo
{
    class SwitchCase3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the char");
            Char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                   
                case 'E':

                case 'I':

                case 'O':

                case 'U':
                Console.WriteLine("Vowel");
             
                break;
                default:
                    Console.WriteLine("Consonent");
                    break;





            }
        }
    }
}
