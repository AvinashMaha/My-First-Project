using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class String_Bulider
    {
        static void Main(string[] args)
        {
          /*//  StringBuilder sb = new StringBuilder("om");
            sb.Append("rahul");
            sb[2] = 'P';  //replace that char in that perticuler char
            Console.WriteLine(sb);*/


            StringBuilder sb = new StringBuilder("omdiya");
            sb.Append("Keshav");
            sb.AppendLine("Maharaj");
            sb.Append("Riya");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb[8]);

            sb.Remove(2, 2);
            Console.WriteLine(sb);     // -------------->remove
            sb.Insert(2, "Ganesh");
            Console.WriteLine(sb);

            StringBuilder SB = new StringBuilder("Om");
            StringBuilder SB2 = new StringBuilder("Om");
            //Console.WriteLine(SB == SB2);
            Console.WriteLine(SB.Equals(SB2));

        }
    }
}
