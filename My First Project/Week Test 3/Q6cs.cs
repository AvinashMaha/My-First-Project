using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Week_Test_3
{

    class Shoppping
    {
        void DoTransaction(int cvv ,string Expiry_date,string bank_name)
        {
            Console.WriteLine(cvv+"\t"+Expiry_date+"\t"+bank_name);
            Console.WriteLine("15% disc on credit card bills");
        }

        void DoTransaction(string customer_name,long card_number,string nik_name)
        {
            Console.WriteLine(customer_name+"\t"+ card_number+"\t"+ nik_name);
            Console.WriteLine("no disc on debit card ");
        }

        static void Main(String[] args)
        {
            Shoppping s = new Shoppping();
            s.DoTransaction("Avinash", 873666, "Avi");
            s.DoTransaction(342, "12June", "BOI");

            




        }
    }
   
}
