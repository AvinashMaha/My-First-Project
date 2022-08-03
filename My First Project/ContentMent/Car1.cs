using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ContentMent
{
    //               Property Writing ConteneMent ----->/*

    class Enginee             //for making non primitive data type ,make another class....!
    {
        string type;
        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Car1
    {
        int model_no;
        string cname;
        int price;
        Enginee en;

        public int Model_no
        {
            get { return model_no; }
            set { model_no = value; }
        }
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Enginee En
        {
            get { return en; }
            set { en = value; }
        }
    }
    class Carinfo
    {
        static void Main(String[] args)
        {
            Car1 c = new Car1();
            c.Model_no = 123;
            c.Cname = "Ferrari";
            c.Price = 546567676;
            c.En = new Enginee();
            c.En.Type = "Petrol";

            Console.WriteLine(c.Model_no + "\t" + c.Cname + "\t" + c.Price + "\t" + c.En.Type);
        }
    }
}



            