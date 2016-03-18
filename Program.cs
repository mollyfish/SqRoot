using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part1
{
    class Program
    {
        
       

        static void Main(string[] args)
        {


            int[] Narray = new int[100];
            int[] Garray = new int[100];

            Random rnd1 = new Random();
            Random rnd2 = new Random();

            for (int i = 0; i < 100; i++)
            {
                int num = rnd1.Next(0, 1000);
                Narray[i] = num;
            }

            for (int j = 0; j < Narray.Length; j++)
            {
                int num = rnd1.Next(0, 1000);
                Garray[j] = num;
            }

            //Console.WriteLine(Garray[1]);
            //Console.WriteLine(Garray[10]);
            //Console.WriteLine(Garray[70]);
            //Console.WriteLine(Garray[99]);


            for (int k = 0; k < Narray.Length; k++)
            {
                SquareRoot run = new SquareRoot(Narray[k], 0.0001, Garray[k]);
                run.Heron();
                run.Standard();
                Validate.Validator(run.result, run.G, run.E);
            }
            Console.WriteLine("Valid: " + Validate.valid + " out of " + Narray.Length);
            Console.ReadLine();
        }
    }
}
