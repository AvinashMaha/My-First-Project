using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ContentMent
{ // Prperty contenment writing writing .....!
    class Addresss
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
    class Person2
    {
        int id;
        string name;
         Addresss adr;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Addresss Adr
        {
            get { return adr; }
            set { adr = value; }
        }
    }
    class Person_info
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            p.Id = 123;
            p.Name ="Avinash Mahadevkar";
            p.Adr = new Addresss();
            p.Adr.Type = "Kolhapur";

            Console.WriteLine(p.Id + "\t" + p.Name + "\t" + p.Adr.Type);
        }
    }
}

