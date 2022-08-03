using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Condition
{
    class ConditionDemo1
    {
        static void Main(String[] args)
        {
            int num ;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + 2);

            Console.WriteLine("Enter the percentage");
            double per = double.Parse(Console.ReadLine());
            Console.WriteLine(per + 2);

            Console.WriteLine("Enter bool Value");
            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine(b );

            Console.WriteLine("Enter any City Name ");
            String city = Console.ReadLine();
            Console.WriteLine(city);

            Console.WriteLine("Enter The char");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("ch"+ch);
        }
    }
}
