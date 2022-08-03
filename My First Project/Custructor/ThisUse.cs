using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class Employee
    {
        internal int id;
        internal string name;
        internal int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
           
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }

    class ThisUse
    {
        static void Main(String[] args)
        {
            Employee emp = new Employee(1,"Yash",6700);
            emp.Display();

            Car c = new Car();
            c.Acceptdetails(123,"fortuner",5600000);

        }


    }
    class Car
    {
          int model;
         string name;
        int price;

        public void Acceptdetails(int model,string name , int price)
        {
            this.model = model;
            this.name = name;
            this.price = price;
            this.show();                       //show mtd
        }
        public void show()
        {
            Console.WriteLine(model + " " + name + " " + price);
        }


    }

}
    

