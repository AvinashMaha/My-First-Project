using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_6
{
    class spliting_demo
    {
        static void Main(string[] args)
        {
            string str1 = "i love UK country";
            string[] arr = str1.Split(" ");
            Console.WriteLine(string.Join(" ",str1));

            for(int i = 0; i<arr.Length-1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i].Length > arr[j].Length)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",arr));


        }
    }
}
