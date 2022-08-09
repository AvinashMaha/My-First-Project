using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{          // Multilevel-inheritence - is the relation ....!
    class Person             // Grand-Parent class ....!
    {
        internal string p_name = "avinash";
        public void Showperson()
        {
            Console.Write(p_name);
        }
    }
    class Employee : Person    // Parent class ....!
    {
        internal int salary = 97776667;
        public void Showsalary()
        {
            Console.Write(p_name + "\t" + salary);
        }
    }
    class Manager : Employee    //Grand-Parent Class
    {
        internal int commition = 765575;
        public void Showmanager()
        {
            Console.Write(p_name +"\t"+salary+"\t"+commition);
        }
    }
    class MultilevelDemo
    {

        static void Main(String[] args)
        {
            Manager m = new Manager();
            m.Showperson();
            m.Showsalary();
            m.Showmanager();
        }
    }
}
