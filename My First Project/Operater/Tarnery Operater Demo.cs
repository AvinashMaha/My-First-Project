using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Operater
{
    class Tarnery_Operater_Demo
    {
        static void Main(String[] args)
        {
            /*Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
*/
            /*int result = num1 > num2 ? num1 : num2;
             Console.WriteLine(result);*/
            /*
                        string str = num1 > num2 ? "Num 1 is gr" : "Num 2 is gr";
                        Console.WriteLine(str);*/



            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 4th number");
            int num4 = int.Parse(Console.ReadLine());

            /*int temp = num1 > num2 ? num1 : num2;
            int max = temp > num3 ? temp : num3;
            Console.WriteLine(max);*/

            /* int max = num1 > num2 ? num1 > num3 ? num1 : num3 : num2 > num3 ? num2 : num3;
             Console.WriteLine(max);*/

            /* */
            int[] nos = { num1, num2, num3, num4 };
            int max = getMax(nos);
            for (int i = 0; i < nos.Length; i++)
            {
                if (max < nos[i])
                {
                    max = nos[i];
                }
            }

            //int max = num1 > num2 ? num1 > num3 ? num1 > num4 ? num1 : num4 : num3 > num2 ? num3 > num4 ? num3 : num4;
            /*   Console.WriteLine(max);
            }*/

            static int getMax(int[] nos)
            {
                int max = 0;
                for (int i = 0; i < nos.Length; i++)
                {
                    if (max < nos[i])
                    {
                        max = nos[i];
                    }
                }

                return max;




            }
        }
    }

}