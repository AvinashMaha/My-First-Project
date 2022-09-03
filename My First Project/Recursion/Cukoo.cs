using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.Recursion
{
        class Cuckoo
        {
            int coo(int s)
            {
                if (s == 1)
                {
                    s = 0;
                }
                if (s == 2)
                {
                    s = 1;
                }

                return s;
            }
            static void Main(string[] args)
            {


                Cuckoo ck = new Cuckoo();
                int n = Convert.ToInt32(Console.ReadLine());
                int c = 0;
                int cu1 = 0;
                int cu2 = 1;

                if (n == 1)
                {
                    Console.WriteLine("0");
                }
                else if (n == 2)
                {
                    Console.WriteLine("1");

                }
                else if (n > 2)
                {
                    c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                    Console.WriteLine(c);
                }
            }
        }
}

