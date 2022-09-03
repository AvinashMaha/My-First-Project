using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_5
{
    class Q3
    {
        public static void Frequency(int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                bool isvisited = false;
                int counter =1 ;
                for (int k = i - 1; k >= 0; k--)        //loop for not repeating values ...
                {
                    if (b[k] == b[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                    if(isvisited == false)
                    {
                        for (int j = i + 1; j < b.Length; j++)
                        {
                            if(b[i] == b[j])
                            counter++;
                        }
                       
                       
                      Console.WriteLine(b[i] + "-"+counter);
                       


                    }
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array element");
            for(int i = 0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Q3.Frequency(a);





        }
    }
}
