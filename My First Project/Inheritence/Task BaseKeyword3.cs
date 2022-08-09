using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{  // Base Keyword Use ------>
    class No            //Heirarchical Inheritent ....! 
    {
        public int x;
        public int y;
        public int z; 
        public int no = 11;
        public No(int x , int y , int z)
        {
           this. x = x;
           this. y = y;
           this.z = z;

           Console.WriteLine("My ans is = "+(x+y));
        }
    }
    class Seven : No
    {
        public int number = 5;
        public Seven():base(13,7,12)
        {
            Console.WriteLine("My number is = "+number+"\nOriginal no is = "+base.no);
        }
    }
    class Task_BaseKeyword3
    {
        static void Main(String[] args)
        {
            Seven s = new Seven();
            


        }
    }
}
