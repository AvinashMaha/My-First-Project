using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    abstract class Television
    {
        public int price;
        public string tvType;
        public string color;
        abstract public string getDetails();
    }
    class LG : Television
    {
        public LG(int price, string tvType, string color)
        {
            this.price = price;
            this.tvType = tvType;
            this.color = color;
        }

        public override string getDetails()
        {
            throw new NotImplementedException();
        }
    }
    //class Samsung : Television
    //{
    //    internal int price = 20000;
    //    internal string Type = "LED";
    //    internal string color = "White";
    //    public override void ShowTV()
    //    {
    //        Console.WriteLine(price + "\t" + Type + "\t" + color);
    //    }
    //}
    //class Eka : Television 
    //{ 
    //     internal int price = 55000;
    //     internal string Type = "LCD";
    //     internal string color = "Gray";
    
    //    public override void ShowTV()
    //    {
    //        Console.WriteLine(price + "\t" + Type + "\t" + color);
    //    }
    //}
    class TV2
    {
        static void Main(String[] args)
        {
            //Eka e = new Eka();
            //e.ShowTV();
            //Samsung s = new Samsung();
            //s.ShowTV();
            LG smartTv = new LG(1000, "smart", "black");
            smartTv.getDetails();

        }
    }
        
    
}

