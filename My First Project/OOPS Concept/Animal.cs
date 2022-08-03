using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.OOPS_Concept
{
    class Animal
    {
        string name;
        int no_of_legs;
        string food_type;

        static void Main(String[] args)
        {
            Animal tiger = new Animal();
            tiger.name = "Tiger";
            tiger.no_of_legs = 4;
            tiger.food_type = "Non Veg";

            Console.WriteLine(tiger.name + "\t" + tiger.no_of_legs + "\t" + tiger.food_type);



            Animal Cow = new Animal();
            Cow.name = "cow";
            Cow.no_of_legs = 4;
            Cow.food_type = "Vegeterian";

            Console.WriteLine(Cow.name + "\t" + Cow.no_of_legs + "\t" + Cow.food_type);
        }
    }
}
