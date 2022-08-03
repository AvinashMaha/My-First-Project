using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Custructor
{
    class Person2
    {
        internal string name;
        internal string company;
        internal string location;
        internal int salary;
        internal long Bank_AccNo;

        public Person2(string name, string company, string location, int salary, long Bank_AccNo)
        {
            this.name = name;
            this.company = company;
            this.location = location;
            this.salary = salary;
            this.Bank_AccNo = Bank_AccNo;

        }
        public void display()
        {
            Console.WriteLine(name + "\t" + company + " \t" + location + "\t " + salary + " \t" + Bank_AccNo);
        }
    }

    class ThisUse
    {
        static void Main(String[] args)
        {
            Person2 p = new Person2("Avinash", "TATA", "Pune", 67474, 75757889);
            p.display();

            Mumbai m = new Mumbai(13127825,603,"India","Maharashtra");
           // m.display();

        }
    }


    class Mumbai
    {
         long population;
        int area;
        string country;
        string state; 

        public Mumbai(long population , int area , string country,string state)
        {
           this. population = population;
           this. area = area;
            this.country = country;
            this.state = state;
            this.show();
        }
        public void show()
        {
            Console.WriteLine(population + "\t" + area + "\t" + country + "\t" + state);
        }

    }
}
    















