using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Coprime
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Enter 1st num");
            int n = int.Parse(Console.ReadLine());*/
           /* Console.WriteLine("Enter 2nd num");
            int m = int.Parse(Console.ReadLine());*/
            
            int m = 12;
            int n = 24;
            int counter = 0;
            for(int i = 1; i<=n; i++)
            {
              if(n % i == 0 && m%i ==0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
               
            }
            if(counter == 1)
            {
                Console.WriteLine("coprime");
            }
            else
            {
                Console.WriteLine("not ");
            }
        }
    }
}