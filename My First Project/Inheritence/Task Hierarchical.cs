using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Inheritence
{
    class Loan
    {
        internal double loan_rate = 8.14;
    }
    class HomeLoan : Loan
    {
        internal double loan_rate = 12;
        public void ShowHomeLoan()
        {
            Console.WriteLine($"Home Loan rate is = {loan_rate}");
        }
    }
    class CarLoan : Loan
    {
        internal double loan_rate = 14;

        public  void ShowCarLoan()
        {
            Console.WriteLine($"Car Loan rate is ={loan_rate} ");
        }
    }
    class Task_Hierarchical
    {
        static void Main(String[] args)
        {
            HomeLoan h = new HomeLoan();
            h.ShowHomeLoan();

            CarLoan c = new CarLoan();
            c.ShowCarLoan();

           
        }
    }
}
