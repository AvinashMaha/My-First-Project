using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class TV
    {
        public string name;
        public int price;
        public string brand;
        public string type;

        public TV(string name, int price, string brand, string type)
        {
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.type = type;

        }
        public void show()
        {
            Console.WriteLine(name + "\t" + price + "\t" + brand + "\t" + type);


        }

        //size, shape, brand, color, type [led/lcd/andoird/smart], price
        public void VolumePlus()
        {
            Console.WriteLine("Volume will rise");
        }
        public void VolumeMinus()
        {
            Console.WriteLine("Volume will Less");
        }
        public void ChannelPlus()
        {
            Console.WriteLine("Channel will rise");
        }
        public void ChannelMinus()
        {
            Console.WriteLine("Channel will Minus");
        }
        public void Jump()
        {
            Console.WriteLine("Jump to specific channel");
        }
        public void ONTV()
        {
            Console.WriteLine("TV will on");
        }
        public void OFFTV()
        {
            Console.WriteLine("Tv will Off");
        }

        static void Main(String[] args)
        {
            TV t = new TV("Hier", 35000, "TV", "32inch");       //Making Object
            t.Jump();
            t.ONTV();
            t.OFFTV();
            t.ChannelMinus();
            t.ChannelPlus();
            t.VolumeMinus();
            t.VolumePlus();
            //mode change TV/HDMI/USB
            //properties ?


            t.show();
        }
    }
 }

