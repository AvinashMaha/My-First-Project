using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class Nested_weight_age
    {
       static void Main(String[] args)
        {
            int age, weight;
            Console.WriteLine("Enter the age of a person :");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Weight of a person :");
            weight = Convert.ToInt32(Console.ReadLine());

            if(age > 18)
            {
              if(weight > 50)
                {
                    Console.WriteLine("You are eligible for blood donation ");
                }
                else
                {
                    Console.WriteLine("You are not eligible");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible ");
            }
        }
        

        }
    }

