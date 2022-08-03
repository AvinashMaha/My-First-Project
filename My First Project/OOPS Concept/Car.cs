using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class Car
    { 
        public int model_number ;
        public string car_name;
        public int car_price;
        public string car_color;


        static void Main(String[] args)
        {
            Car audi = new Car();
            audi.car_name = "Audi";
            audi.model_number = 78453;
            audi.car_price = 7880000;
            audi.car_color = "Black";
            Console.WriteLine(audi.car_color + " " + audi.car_name + " " + audi.car_price + " " + audi.model_number);

        }
    }
}
