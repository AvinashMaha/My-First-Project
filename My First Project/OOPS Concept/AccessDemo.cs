using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept     
{
    class AccessDemo : AccessModifiers          //parent child relation
    {
        static void Main(String[] args)
        {
            AccessModifiers f = new AccessModifiers();
            //Console.WriteLine(f.roll_no);       //private access modifier failed .

            f.Print_name();        // internal access modifier
            f.Print_myname();             // public access modifier

            AccessDemo m = new AccessDemo();
           // Console.WriteLine(m.per);
            m.Print_per();                       //protected access modifier 

           
        }







    
    }
}

