using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Custructor
{
    class Person1
    {
        internal string name;
        internal string company;
        internal string location;
        internal int salary;
        internal long Bank_AccNo;

        public Person1(string name, string company, string location, int salary, long Bank_AccNo)
        {
            this.name = name;
            this.company = company;
            this.location = location;
            this.salary = salary;
            this.Bank_AccNo = Bank_AccNo;

        }

        Person1() : this("Avinash", "TATA", "Pune", 67474, 75757889)
        {
            this.display();
        }

        public void display()
        {
            Console.WriteLine(name + "\t" + company + " \t" + location + "\t " + salary + " \t" + Bank_AccNo);
        }

       
        static void Main(string[] args)
        {
            Person1 p = new Person1();
        }
    }





}
