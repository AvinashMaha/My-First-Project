using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class MethodDemo
    {
        int y;
        //no return type no parameter
    public void show()             //method declaration
    {
        Console.WriteLine("Show Method");         //method body
            
        }
        //no return type with parameter 
        public void calculate(int x, string str)        //cube of the number
        {
           y = x * x * x;
        }

        public void Display()
        {
            Console.WriteLine(y);
        }
        //with return type no parameter :-
        public double AreaOfCircle()
        {
            double PI = 3.14;
            double area = PI * 4 * 4;
            return area;
        }
        public int Addition(int a , int b)
        {
            
            return (a + b);
        }

        static void Main(String[] args)
        {
        MethodDemo d = new MethodDemo();
        d.show();                  //method calling                 1]

            d.calculate(3, "Pune");      // method calling 
            d.Display();                                          //   2]

            double a = d.AreaOfCircle();
            Console.WriteLine("Area of circle" + a);               //  3]

            int result = d.Addition(6, 7);
            Console.WriteLine("Addition= " + result);
            Console.WriteLine("Addition is= " + d.Addition(19, 21));           // 4]

        }

    }
}