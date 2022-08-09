using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project.ArrayDemo
{
    class FloatArray
    {
        public void Float_Array()
        {
            Console.WriteLine("Enter the size of a Array");
            int size = int.Parse(Console.ReadLine());
           
            float[] f = new float[size];            //Array size
            Console.WriteLine("Enter the members of float elements");
            for (int i = 0; i < f.Length; i++)
            {
                f[i] = float.Parse(Console.ReadLine());      // float members loop
            }
            Console.WriteLine("--------------Using For Loop------------------------");
            foreach(float g in f)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("----------------Using Join -------------------");

            Console.WriteLine(string.Join(" \n", f));
            
        }

            

            static void Main(String[] args)
            {
                FloatArray t = new FloatArray();
                t.Float_Array();
            }
        

    }
}

