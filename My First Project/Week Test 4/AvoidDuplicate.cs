using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    class AvoidDuplicate
    {
        static void Main(string[] arg)
        {
            int i, j ;
            Console.WriteLine("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] temp = new int[size];


            Console.WriteLine("Array elements after deleting duplicates :");

            int counter = 0;

            for (i = 0; i < size; i++)
            {
                bool availalable = false;
                for (j = 0; j< temp.Length; j++)
                {
                    if (arr[i] == temp[j])
                    {
                        availalable = true;
                        break;
                    }
                }

                if (!availalable)
                {
                    temp[counter++] = arr[i];
                    //Console.WriteLine(temp[i]);
                }
            }

            //for (i = 0; i < num; i++)
            //{
            //    for (j = i + 1; j < num; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            for (k = j; k < num; k++)
            //            {
            //                arr[k] = arr[k + 1];
            //            }
            //            num--;

            //        }
            //    }
            //}


            for (i = 0; i < counter; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}
