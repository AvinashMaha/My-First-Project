using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class Vehicle
    {
        public int model_no;
        public string type_of_vehicle;
        public int num_of_wheels;
        public int avg  ;

        public void acceptdetails(int model_num, string type, int wheel_count)
        {
            model_no = model_num;
            type_of_vehicle = type;
            num_of_wheels = wheel_count;


        }
        public void Avg()
        {
            if (num_of_wheels >= 2 && num_of_wheels < 8)
            {
                avg = 65;

            }
            else if (num_of_wheels >= 8 && num_of_wheels <= 14)
            {
                avg = 40;
             
            }
            else if(num_of_wheels >= 15 )
            {
                avg = 10;
            }

        }
        public void display()
        {
            System.Console.WriteLine(model_no +"\t"+ type_of_vehicle +"\t"+ num_of_wheels+"\t"+avg);
        }

        static void Main(String[] args)
        {
            Vehicle v = new Vehicle();
            Console.WriteLine("Enter the vehicle model number : ");
            int model = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the type of vehicle : ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter the no of wheels : ");
            int no = int.Parse(Console.ReadLine());

            v.acceptdetails(model, type, no);
            v.Avg();
            v.display();




        }
    }
}


