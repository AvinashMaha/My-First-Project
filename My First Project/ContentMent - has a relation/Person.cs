using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ContentMent
{       // using custructor Contentment Method ......!
    class Address
    {
        public int pincode;               //modifier type is public ....!
        public string city; 

        public Address (int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void Showaddress()
        {
            Console.WriteLine("\t " + pincode + "\t " + city);
        }
    }
    class Person
    {
        int id ;                                  //default modifier private type .....!
        string name;
        Address adr ;

          Person(int id, string name, Address adr)
          {
            this.id = id;
            this.name = name;
            this.adr = adr;
          }
        void DisplayPerson()
        {
            Console.Write(id + " \t" + name);
            adr.Showaddress();          //has a relationship property
        }


        static void Main(String[] args)
        {
           /* Address a = new Address(41, "Pune");
            Person p = new Person(12, "Jatin", a);             //longcut mtd
*/
            Person P = new Person(12, "Jatin", new Address(41, "Pune"));
            P.DisplayPerson();                                    //shortcut mtd
        }
    }
}
