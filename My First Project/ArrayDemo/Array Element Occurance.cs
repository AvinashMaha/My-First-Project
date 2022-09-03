using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class Array_Occurance
    {
        public static void FindOccurance(int[]b)
        {
            
            for (int i = 0; i < b.Length; i++)
            {
                bool isvisited = false;
                int count = 1;               
                for (int k = i - 1; k >= 0; k--)
                {
                    if (b[i] == b[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < b.Length; j++)
                    {
                        if (b[i] == b[j])
                        {
                            count++;
                        }
                    }
                 //   if(count ==1)          //unique 
                    if (count > 1)  //duplicate element display
                    {
                        Console.WriteLine(b[i] + " - " + count);
                    }
                }
            }  
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter aarrat size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("array elements are");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Array_Occurance.FindOccurance(a);

        }
    }
}
