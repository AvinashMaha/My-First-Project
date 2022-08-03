using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ContentMent
{
    class Department
    {
       public int id;
       public string name; 

        public Department(int id, string name)
        {
           this. id = id;
            this.name = name;
        }
        public void ShowDepartment()
        {
            Console.Write("\t"+id +"\t"+name);
        }
    }
    class Employee
    {
        int id;
        string salary;
        Department dep;

        Employee(int id , string salary,Department dep)
        {
            this.id = id;
            this.salary = salary;
            this.dep = dep;
        }
        void EmployeeDisplay()
        {
            Console.Write(id+"\t"+salary);
            dep.ShowDepartment();

        }
       static void Main(String[]args)
       {
            Employee e = new Employee(12,"544446",new Department(15,"Mechanical_Department"));
            e.EmployeeDisplay();

       }

    }
}
