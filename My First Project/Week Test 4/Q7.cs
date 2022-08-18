using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_4
{
    class Q7
    {
        class Subengine
        {
            string subenginetype;
            public Subengine(string subenginetype)
            {
                this.subenginetype = subenginetype;
            }
            public void showsub()
            {
                Console.WriteLine(subenginetype);
            }
        }
        class Engine
        {
            int engineid;
            string lastenginecleandate;
            Subengine sub;
            public Engine(int engineid, string lastenginecleandate, Subengine sub)
            {
                this.engineid = engineid;
                this.lastenginecleandate = lastenginecleandate;
                this.sub = sub;
            }
            public void showengine()
            {
                Console.WriteLine(engineid + " " + lastenginecleandate);
                sub.showsub();
            }

        }
        class Gear
        {
            string type;
            public Gear(string type)
            {
                this.type = type;
            }
            public void showgear()
            {
                Console.WriteLine(type);
            }
        }
        class Car
        {
            int carId;
            string carcolour;
            Engine engine;
            Gear gear;

            public Car(int carId, string carcolour, Engine engine, Gear gear)
            {
                this.carId = carId;
                this.carcolour = carcolour;
                this.engine = engine;
                this.gear = gear;
            }
            public void showcar()
            {
                Console.WriteLine(carId + " " + carcolour);
                engine.showengine();
                gear.showgear();
            }

        }
        class Car1
        {
            static void Main(string[] args)
            {
                Car c = new Car(123, "white", new Engine(111, "08/2/2022", new Subengine("petrol")), new Gear("auto"));
                c.showcar();
                Console.ReadLine();
            }

        }
    }
}
