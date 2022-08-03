using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Custructor
{
    class Student
    {
        int id;
        string name;
        double per;

        public Student()                 //default or no parameter
        {
            /*  id = 300;
              name = "Sonal";
              per = 65.32;*/
            Console.WriteLine("Default");
        }
        public Student(int sid,string ename,double perc)
        {
            id = sid;                               //parametriezed custructor
            name = ename;
            per = perc;
        }

        static void Main(String[] args)
        {
            /*Student s = new Student();
            Console.WriteLine(s.id +" "+ s.name+" " + s.per);

            Student s1 = new Student();
            Console.WriteLine(s1.id + " " + s1.name + " " + s1.per);*/

            Student s2 = new Student(10, "Avibhay", 56.76);
            Console.WriteLine(s2.id+" " + s2.name+" " + s2.per);
        }
    }
}
