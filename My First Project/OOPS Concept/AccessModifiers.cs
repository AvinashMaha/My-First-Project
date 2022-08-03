using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class AccessModifiers
    {
         int roll_no = 30;
        internal string name = "Jay";
        protected double per = 76.87;
        public string s_name = "XYZA";

         void PrintRoll()          //private accessmodifier method , it is inbuilt mtd
        {
            Console.WriteLine("My roll number is :" + roll_no);
        }
        //------------------------------------------------------
        internal void Print_name()     //inernal access modifier method. (suits in another class but in same namespace)
        {
            Console.WriteLine("Name=" + name);
        }
        //---------------------------------------------------------
       protected void Print_per()        // protected accessmodifier mtd 
        {
            Console.WriteLine("percentage is =" + per);
        }
        //-----------------------------------------------------------
        public void Print_myname()        //public accessmodifier mtd
        {
            Console.WriteLine("my name is " + s_name);
        }
        //-----------------------------------------------------------

        static void Main(String[] args)
        {
            AccessModifiers a = new AccessModifiers();
           // a.roll_no = 200;
              Console.WriteLine(a.roll_no);
            a.PrintRoll();                           // private access mtd calling

          //  Console.WriteLine(a.name);
            a.Print_name();                        //internal access mtd calling

          //  Console.WriteLine(a.per);
            a.Print_per();                           //protected access mtd calling

          //  Console.WriteLine(a.s_name);           
            a.Print_myname();                            //public access mtd calling




        }
    }
}
