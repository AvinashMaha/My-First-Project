using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class CarDemo
    {
         string make;
         string name; 
        int insurance_cost;
        double Milage;
        string Engine_type;
        string Safety;


         static void Main(String[] args)
            {
            CarDemo nexon = new CarDemo();
            nexon.make = "TATA";
            nexon.name = "Nexon";
            nexon.insurance_cost = 12000;
            nexon.Milage = 17.0;
            nexon.Engine_type = "Diesel";
            nexon.Safety = "Yes_Sure";

            Console.WriteLine(nexon.name + "\t" + nexon.make + "\t" + nexon.insurance_cost + "\t" + nexon.Milage + "\t" + nexon.Engine_type + "\t" + nexon.Safety);


            CarDemo i10 = new CarDemo();
            nexon.make = "Hyundai";
            i10.name = "i10";
            i10.insurance_cost = 14000;
            i10.Milage = 16.95;
            i10.Engine_type = "petrol";
            i10.Safety = "Good";
            Console.WriteLine(i10.name + "\t" + i10.make + "\t" + i10.insurance_cost + "\t" + i10.Milage + "\t" + i10.Engine_type + "\t" + i10.Safety);

            CarDemo BMW = new CarDemo();
            BMW.make = "GermanCompany";
            BMW.name = "BMW";
            BMW.insurance_cost = 38000;
            BMW.Engine_type = "petrol";
            BMW.Safety = "Excellent";

            Console.WriteLine(BMW.make +"\t" + BMW.name + "\t" + BMW.insurance_cost + "\t" + BMW.Engine_type + "\t" + BMW.Safety);

        }
    }
}