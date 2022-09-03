using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Name_Validation
    {
        static void numvalid(string s)
        {
            bool isvalid = true;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    isvalid = false;
                    break;
                }
                else if (char.IsSymbol(c))
                {
                    isvalid = false;
                    break;
                }
            }
            if(isvalid == true)
            {
                Console.WriteLine("name is valid");
            }
            else
            {
                Console.WriteLine("name is invalid");
            }
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  name ");
            string name = Console.ReadLine();
            numvalid(name);

        }
    }
}
