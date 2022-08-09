using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_3
{ // write a code to perform custructor chaining ....!
    class MysampleClass
    {
        public MysampleClass() : this(10)
            
        {
            //custructor having no parameter
        }
        public MysampleClass(int y):this(10,"Avi")
        {
            Console.WriteLine(y);
            //custructor having one parameter 
        }
        public MysampleClass(int y,string name):this(10,"Avi",7.14f)
        {
            Console.WriteLine(y+"\t"+name);
            // custructor having 2 parameters

        }
        public MysampleClass(int y , string name , float c )
        {
            Console.WriteLine(y + "\t" + name + "\t" + c);
            //custructor having 3 parameters
        }
        static void Main(String[] args)
        {
            MysampleClass m = new MysampleClass();
            
            
        }
    }
}
