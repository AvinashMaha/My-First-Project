using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{
    class Engineer         // Great grand Parent class
    {
        internal string type = "Engineer";
    }
    class Mechanical : Engineer       //Grand Perent Class
    {
        internal int course_fee = 23000;

        public void ShowMechanical()
        {
            Console.WriteLine(type+"\t"+course_fee);
        }
    }
    class Electrical : Mechanical      //Parent Class 
    {
        internal string exam_date = "1-Dec";
        public void ShowElectrical()
        {
            Console.WriteLine(type+"\t"+course_fee+"\t"+exam_date);
        }

    }
    class Computer : Electrical      //Child Class
    {
        internal int total_topics = 4;
        public void ShowComputer()
        {
            Console.WriteLine(type + "\t" + course_fee + "\t" + exam_date + "\t" + total_topics);
        }

    }
    class Task_MultiLevel           
    {
        static void Main(String[] args)
        {
            Computer c = new Computer();
            c.ShowMechanical();
            c.ShowElectrical();
            c.ShowComputer();
        }
    }
}
