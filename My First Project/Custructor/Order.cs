using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class Order
    {
        int id;
        string product_name;
        int price;
        int qty;
        int total_bill;

        public Order(int id, string product_name, int price, int qty )
        {
            this.id = id;
            this.product_name = product_name;
            this.price = price;
            this.qty = qty;
           
        }
         Order():this(1,"Pen_Drive",120,10)
        {
            total_bill = price * qty;
            this.display();
        }
        void display()
        {
            Console.WriteLine(id+" "+product_name+" "+price+" "+qty+" "+total_bill);
        }



        static void Main(String[] args)
        {
              // Order r = new Order(1,"pen drive",120,10);
           Order o = new Order();
            
            



        }
    }
}
