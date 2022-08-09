using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ContentMent
{         //using custructor contenment mtd --->
    class Engine
    {
        public string type;
        public string speed; 

        public Engine(string type , string speed )
        {
            this.type = type;
            this.speed = speed; 
        }
        public void ShowEngine()
        {
            Console.Write("\t" +type +"\t"+speed);
        }
    }

    class Car2
    {
        int model_no;
        string cname;
        int price;
        Engine en;

        Car2(int model_no ,string cname ,int price,Engine en)          //parametirized custructor
        {
            this.model_no = model_no;
            this.cname = cname;
            this.price = price;
            this.en = en;
        }
        void ShowCar()
        {
            Console.Write(model_no +"\t"+ cname +"\t"+ price);
            en.ShowEngine();
        }


        static void Main(String[] args)
        {
            Car2 c = new Car2(123,"CRETA",556565,new Engine("Diesel","140.14 km/hr"));
            c.ShowCar();
        }
    }
}
