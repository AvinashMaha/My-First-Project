using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.EncapsulateDemo
{
    class BankDemo
    {
        int acc_no;
        string c_name;
        int balance;
        public int Acc_No
        {
            get
            {
                return acc_no;
            }
            set
            {
                acc_no = value;
            }
        }
        public string C_Name
        {
            get
            {
                return c_name;
            }
            set
            {
                c_name = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }
    class AccountInfo
    {

        static void Main(String[] args)
        {
                BankDemo b = new BankDemo();
                b.Acc_No = 1213123;
                b.C_Name = "hgdjjhj";
                b.Balance = 46546;

                Console.WriteLine("Acc no = " + b.Acc_No + "name =  " + b.C_Name + "Balance =  " + b.Balance);


        }








        
    }
        
    
}
