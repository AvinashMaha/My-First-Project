using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.StringDemo
{
    class Class
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Entr string"  );
            string str = Console.ReadLine();*/

            string str = "Red ball Red bat Red rose";
           string s1 = str.Replace('a', 'v');           // replace with v insted of a
            string s2 = str.Replace("Red", "Blue");           // emplty space where a "_"
            Console.WriteLine(str);
            Console.WriteLine(s1);
            Console.WriteLine(s2);           // print another string insted of old(Red)

            string s3 = "Thinkquotient";
            string s4 = s3.Substring(2);     // start printing from 2
            string s5 = s3.Substring(2, 3);       //2nd element as first and walk till third element
            Console.WriteLine(s5);


            string d1 = "om";
            string d2 = "omprakash";
            Console.WriteLine(d1.Equals(d2));     // It returns bool ! result will be false


             Console.WriteLine(d1 == d2);
            d1 = " Avinash Rahul ";
            d1 = d1.Trim();
            Console.WriteLine(d1);           //it removes white spaces    

            d1 = "Avinash Rahul";
            Console.WriteLine(d1.StartsWith("Av")); //It returns Bool !check that it is starts with given string or not  
            Console.WriteLine(d1.EndsWith("ul"));    //It also returns Bool !check that it is ends with given string or not.

            d1 = "Rahul";
            d2 = "Amit";
            //if d1 > d2 ---> +1
            // d1 < d2 ----> -1
            // d1 == d2 ----> 0
            Console.WriteLine(d1.CompareTo(d2)); //it returns bool
            //Console.WriteLine(d1.Equals(d2));
            Console.WriteLine(d1.CompareTo("Rahul"));    // it is exact equal so returns 0



        }
    }
}
