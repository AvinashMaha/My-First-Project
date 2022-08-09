using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ContentMent
{
    class pen
    {
       public string length;
       public string name;
       public string color;
       public string type;

        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Name
        {
            get { return name; }
            set { length = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Bag
    {
         string brand_name;
         int price;
         string color;
         pen p;

        public string Brand_name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public pen P
        {
            get { return p; }
            set { p = value; }
        }
    }
    class Baginfo
    {
        static void Main(String[] args)
        {
            Bag b = new Bag();
            b.Brand_name = "Nike";
            b.Price = 6555;
            b.Color = "Skyblue";

            b.P = new pen();

            b.P.Length = "medium";
            b.P.Name = "Montex";
            b.P.Color = "Purple";
            b.P.Type = "Ball_Pen";

            Console.WriteLine(b.Brand_name+"\t"+b.Price+"\t"+b.Color+"\t"+b.P.Length+"\t"+b.P.Name+"\t"+b.P.Color+"\t"+b.P.Type);

           
        }
    }
}
