using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;
        public string address;

        public void acceptdetails(int eid, string ename, double sal, string adr)
        {
            id = eid;
            name = ename;
            salary = sal;
            address = adr;
        }
        public void display()
        {
            System.Console.WriteLine(id + "\t" + name + "\t " + salary + "\t" + address);
        }

        static void Main(String[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Enter the employee ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name");
            string nam = Console.ReadLine();
            Console.WriteLine("Enter the employee salary");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee address");
            string addr = Console.ReadLine();


           e.acceptdetails(id,nam,sal,addr);
            e.display();

        }
          /*  e.acceptdetails(1, "amit", 56000.987, "pune");
            e.display(*/

        }
    }




