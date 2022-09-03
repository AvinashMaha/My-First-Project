using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Sorting_string
    {
        static void Main(string[] args)
        {
            string[] arr = { "Aditya", "Abi", "Siya", "Diya" };
            for(int i = 0; i<arr.Length; i++)
            {
                for(int j= i+1; j < arr.Length-1; j++)
                {
                    int r = arr[i].CompareTo(arr[j]);
                    if(r == 1)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        //swapping
                    }
                    
                }
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
