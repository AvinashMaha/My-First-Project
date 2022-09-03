using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.VIMP_pracrice_Prorigo
{
    class Find_Duplicate_From_Array
    {
        static void Duplicate(int[]b)
        {
            Console.WriteLine("Duplicate nums are :-");
            for(int i= 0; i<b.Length; i++)
            {
                int counter = 1; 
                for(int j=i+1; j<b.Length; j++)
                {
                    if(b[i] == b[j])
                    {                      
                        counter++;
                       // continue;
                    }                   
                }   
                if(counter > 1)
                {
                    Console.WriteLine(b[i] +"-"+counter);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 12, 14, 15, 11, 13, 19, 11, 13,12 };
            Duplicate(a);

        }
    }
}
