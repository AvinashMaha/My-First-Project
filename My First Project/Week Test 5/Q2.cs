using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_5
{
    class Q2
    { //array of 10 elements and swap first two elements with last two elements.
       

        static void Main(String[] args)
        {
            int[] arr = { 70, 60, 30, 40, 50, 20, 10 };
            Console.WriteLine("Before Swapping");

            Console.WriteLine(string.Join(" ", arr));

            int temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;


            temp = arr[1];
            arr[1] = arr[arr.Length - 2];
            arr[arr.Length - 2] = temp;
           
            Console.WriteLine("After Swapping 2 numers");
            Console.WriteLine(string.Join(" ", arr));

           
        }
    }
}
