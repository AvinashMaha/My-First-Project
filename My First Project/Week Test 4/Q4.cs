using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    //using contenment - has a relatiom -------------->
    class Q4
    {
        class Nib
        {
            string materialtype;
            int width;
            public string Materialtype
            {
                get { return materialtype; }
                set { materialtype = value; }
            }
            public int Width
            {
                get { return width; }
                set { width = value; }
            }
            public void shownib()
            {
                Console.WriteLine(Materialtype + " " + Width);
            }
        }
        class Refill
        {
            string inkColour;
            int Length;
            Nib nib;
            public string InkColour
            {
                get { return inkColour; }
                set { inkColour = value; }
            }
            public int length
            {
                get { return Length; }
                set { Length = value; }
            }
            public Nib Nibtype
            {
                get { return nib; }
                set { nib = value; }
            }
            public void showRefill()
            {
                Console.WriteLine(InkColour + " " + Length);
                Nibtype.shownib();
            }

        }
        class Pen
        {
            Refill refill;
            string brand;
            int caplength;

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public int Caplength
            {
                get { return caplength; }
                set { caplength = value; }
            }
            public Refill Refills
            {
                get { return refill; }
                set { refill = value; }
            }
            public void showPen()
            {
                Refills.showRefill();
                Console.WriteLine(Brand + " " + Caplength);

            }
            static void Main(string[] args)
            {
                Pen p = new Pen();
                p.Brand = "reynolds";
                p.caplength = 7;
                p.Refills.InkColour = "red";
                p.Refills.length = 10;
                p.Refills.Nibtype.Materialtype = "stainless steel";
                p.Refills.Nibtype.Width = 2;
                p.showPen();
                Console.ReadLine();
            }
        }
    }
}

